namespace Routine.Api.Models
{
    public class LinkDto
    {
        public string Href { get; }
        public string Rel { get; }
        public string Method { get; }

        public LinkDto(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }
    }
}
