using CQRS.Core.Commands;

namespace Post.Cmd.API.Commands
{
    public class DeletePostCommand : BaseCommand
    {
        public Guid CommentID { get; set; }
        public string Username { get; set; }
    }
}