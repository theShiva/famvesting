namespace SingleFamProperties.Dtos
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string ResourceType { get; set; }
        public bool IsPublic { get; set; }
        public object Description { get; set; }
        public string Filename { get; set; }
        public object SizeInByte { get; set; }
        public string ContentType { get; set; }
        public string Url { get; set; }
        public string UrlMedium { get; set; }
        public string UrlSmall { get; set; }
        public object TextContent { get; set; }
    }
}