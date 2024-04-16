namespace _01._FluentBuilder
{
    internal class SocialMediaPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public List<string> Tags { get; set; }
        public Uri ImageUri { get; set; }
        public List<string> Links { get; set; }
    }
}
