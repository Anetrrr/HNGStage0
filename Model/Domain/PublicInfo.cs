namespace HNGStage0.Model.Domain
{
    public class PublicInfo
    {
        public string Email { get; set; }
        public DateTime CurrentDateTime { get; set; } = DateTime.Now;

        public string GithubUrl { get; set; }
    }
}
