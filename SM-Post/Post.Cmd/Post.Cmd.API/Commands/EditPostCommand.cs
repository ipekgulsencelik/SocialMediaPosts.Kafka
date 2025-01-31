using CQRS.Core.Commands;

namespace Post.Cmd.API.Commands
{
    public class EditPostCommand : BaseCommand
    {
        public string Message { get; set; }
    }
}