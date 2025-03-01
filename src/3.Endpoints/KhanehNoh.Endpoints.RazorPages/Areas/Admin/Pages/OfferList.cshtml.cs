using KhanehNoh.Domain.Core;
using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class OfferListModel : PageModel
    {
        private readonly IOfferAppService _offerApp;

        public OfferListModel(IOfferAppService offerApp)
        {
            _offerApp = offerApp;
        }
        public List<Offer> Offers { get; set; }
        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            Offers = await _offerApp.GetOfferesAsync(cancellationToken);
        }

        //public async Task<IActionResult> OnPostChangeStatus(int offerId, OrderStatusEnum newStatus, CancellationToken cancellationToken)
        //{
        //    await _offerApp.ChangeStatus(newStatus, offerId, cancellationToken);
        //    return RedirectToPage();
        //}
    }
}
