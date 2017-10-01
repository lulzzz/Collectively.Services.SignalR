using Collectively.Common.Services;
using Collectively.Messages.Events.Operations;
using Collectively.Messages.Events.Remarks;
using Collectively.Services.SignalR.Services;

namespace Collectively.Services.SignalR.Handlers
{
    public class RemarkVoteSubmittedHandler : HandlerBase<RemarkVoteSubmitted>
    {
        public RemarkVoteSubmittedHandler(IHandler handler,
            IHubService hubService) : base(handler, hubService,
                x => hubService.PublishRemarkVoteSubmittedAsync(x))
        {
        }
    }
}