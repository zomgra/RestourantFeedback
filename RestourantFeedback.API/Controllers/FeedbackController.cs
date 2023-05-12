using Microsoft.AspNetCore.Mvc;
using RestourantFeedback.Application.Commons.Base;
using RestourantFeedback.Application.FeedbackMessages.Commands;

namespace RestourantFeedback.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> PostFeedbackAsync(PostFeedbackMessageCommand command, CancellationToken cancellationToken)
        {
            var result = await Mediator.Send(command, cancellationToken);
            return Ok(result);
        }
    }
}
