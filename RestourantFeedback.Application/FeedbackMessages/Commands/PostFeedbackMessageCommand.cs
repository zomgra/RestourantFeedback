using MediatR;
using System.ComponentModel.DataAnnotations;

namespace RestourantFeedback.Application.FeedbackMessages.Commands
{
    /// <summary>
    /// Command for post feedback
    /// </summary>
    public class PostFeedbackMessageCommand : IRequest<string>
    {
        [Required]
        public string Username { get; set; }
        [EmailAddress]
        public string? UserEmail { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Message { get; set; }
    }
}
