namespace _01._FluentBuilder
{
    internal class SocialMediaPostBuilder
    {
        public readonly SocialMediaPost _post = new SocialMediaPost();

        public SocialMediaPostBuilder AddTitle(string title)
        {
            _post.Title = title;
            return this;
        }

        public SocialMediaPostBuilder AddContent(string content)
        {
            _post.Content = content;
            return this;
        }

        public SocialMediaPostBuilder AddAuthor(string author)
        {
            _post.Author = author;
            return this;
        }

        public SocialMediaPostBuilder AddPostDate(DateTime datePosted)
        {
            _post.DatePosted = datePosted;
            return this;
        }

        public SocialMediaPostBuilder AddTag(string tag)
        {
            if(_post.Tags == null) _post.Tags = new List<string>();
            _post.Tags.Add(tag);
            return this;
        }

        public SocialMediaPostBuilder AddLink(string link)
        {
            if (_post.Links == null) _post.Links = new List<string>();
            _post.Tags.Add(link);
            return this;
        }

        public SocialMediaPost Build()
        {
            return _post;
        }
    }
}
