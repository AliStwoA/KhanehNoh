using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages.Ratings
{
    public class IndexModel : PageModel
    {
        private readonly IRatingAppService _ratingApp;

        public IndexModel(IRatingAppService ratingApp)
        {
            _ratingApp = ratingApp;
        }
        public List<Rating> Ratings { get; set; }

        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            Ratings = await _ratingApp.GetRatingsAsync(cancellationToken);
        }

        public async Task<IActionResult> OnPostApprove(int ratingId, CancellationToken cancellationToken)
        {
            await _ratingApp.UpdateStatusAsync(ratingId, true , cancellationToken);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostReject(int ratingId, CancellationToken cancellationToken)
        {

            await _ratingApp.UpdateStatusAsync(ratingId, false, cancellationToken);
            return RedirectToPage();

        }
    }
}
