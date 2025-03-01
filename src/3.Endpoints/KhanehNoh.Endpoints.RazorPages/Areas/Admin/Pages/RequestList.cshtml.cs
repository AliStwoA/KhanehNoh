using KhanehNoh.Domain.Core;
using KhanehNoh.Domain.Core.Contracts.AppService;
using KhanehNoh.Domain.Core.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KhanehNoh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class RequestListModel : PageModel
    {
        private readonly IRequestAppService _requestApp;

        public RequestListModel(IRequestAppService requestApp)
        {
            _requestApp = requestApp;
        }

        public List<Request> Requests { get; set; }

        public async Task OnGetAsync(CancellationToken cancellationToken)
        {
            Requests = await _requestApp.GetRequestsAsync(cancellationToken);
        }
        public async Task<IActionResult> OnPostChangeStatus(int requestId, OrderStatusEnum status, CancellationToken cancellationToken)
        {
            await _requestApp.ChangeStatus(status, requestId, cancellationToken);
            return RedirectToPage();
        }
    }
}
