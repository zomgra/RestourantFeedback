using System.ComponentModel.DataAnnotations;

namespace RestourantFeedback.Domain
{
    public class FeedbackMessage
    {
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        [EmailAddress]
        public string? UserEmail { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Message { get; set; }
        public DateOnly Date { get; set; }
    }
}
