namespace CodePulse.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Content { get; set; }

        public string FeaturedImageUrl { get; set; }

        public string Urlhandle { get; set; }

        public DateOnly PublishedDate { get; set; }

        public string Author { get; set; }

        public bool IsVisible { get; set; }
    }
}
