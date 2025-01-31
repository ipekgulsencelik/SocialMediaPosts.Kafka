using CQRS.Core.Commands;

namespace Post.Cmd.API.Commands
{
    public class EditCommentCommand : BaseCommand
    {
        public Guid CommentID { get; set; }
        public string Comment { get; set; }
        public string Username { get; set; }
    }
}