namespace CQRS.Models
{
    public class PostModel
    {
        public Guid  Id { get; set; }

        public string Title{ get; set; }

        public string Description { get; set; }

        public string Author { get; set; }
    }
}
