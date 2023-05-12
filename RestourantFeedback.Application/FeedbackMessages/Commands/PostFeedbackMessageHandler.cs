using MediatR;
using RestourantFeedback.Application.Commons.Interfaces;
using RestourantFeedback.Domain;

namespace RestourantFeedback.Application.FeedbackMessages.Commands
{
    public class PostFeedbackMessageHandler : IRequestHandler<PostFeedbackMessageCommand, string>
    {
        private readonly IAppDbContext _context;

        public PostFeedbackMessageHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PostFeedbackMessageCommand request, CancellationToken cancellationToken)
        {
            var entity = new FeedbackMessage { Date = DateOnly.FromDateTime(DateTime.Today), Message = request.Message, UserEmail = request.UserEmail, Username = request.Username };

            await _context.Feedbacks.AddAsync(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return "Feedback post";
        }
    }
}
