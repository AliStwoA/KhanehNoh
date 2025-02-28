﻿using KhanehNoh.Domain.Core.Contracts.Repository;
using KhanehNoh.Domain.Core.Entities.Users;
using KhanehNoh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanehNoh.Infrastructure.EfCore.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public CustomerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Customer>> GetCustomersAsync(CancellationToken cancellationToken)
               => await _appDbContext.Customers
               .ToListAsync(cancellationToken);

        public async Task<Customer?> GetCustomerByIdAsync(int id, CancellationToken cancellationToken)
         => await _appDbContext
         .Customers
         .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);

        public async Task<List<Customer>> GetCustomersWithDetailsAsync(CancellationToken cancellationToken)
           => await _appDbContext
            .Customers
            .Include(c => c.Requests)
            .ThenInclude(c => c.Offers)
            .Include(c => c.Ratings)
            .Include(c => c.User)
            .ThenInclude(c => c.City)
            .ToListAsync(cancellationToken);


        public async Task<Customer?> GetCustomerByIdWithDetailsAsync(int userId, CancellationToken cancellationToken)
            => await _appDbContext
            .Customers
            .Include(c => c.Requests)
            .ThenInclude(c => c.Offers)
            .Include(c => c.Ratings)
            .Include(c => c.User)
            .ThenInclude(c => c.City)
            .FirstOrDefaultAsync(e => e.Id == userId, cancellationToken);

        public async Task<bool> CreateAsync(Customer customer, CancellationToken cancellationToken)
        {
            try
            {
                await _appDbContext.Customers.AddAsync(customer, cancellationToken);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Customer customer, CancellationToken cancellationToken)
        {
            try
            {
                _appDbContext.Customers.Remove(customer);
                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }



        public async Task<bool> UpdateAsync(Customer customer, CancellationToken cancellationToken)
        {
            try
            {
                var existCustomer = await _appDbContext.Customers.FirstOrDefaultAsync(c => c.Id == customer.Id, cancellationToken);

                if (existCustomer == null)
                    return false;

                existCustomer.User.Address = customer.User.Address;
                existCustomer.User.FirstName = customer.User.FirstName;
                existCustomer.User.LastName = customer.User.LastName;
                existCustomer.User.Email = customer.User.Email;
                existCustomer.User.CityId = customer.User.CityId;
                existCustomer.User.PictureUrl = customer.User.PictureUrl;
                existCustomer.User.PhoneNumber = customer.User.PhoneNumber;

                await _appDbContext.SaveChangesAsync(cancellationToken);
                return true;

            }
            catch
            {
                throw new Exception("Logic Errorr!!!");
            }
        }
    }
}
