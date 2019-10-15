namespace JxStudioAPICenter.Alipay
{
    public class AuthDto
    {
        public string AccessToken { get; set; }
        public string AuthTokenType { get; set; }
        public string ExpiresIn { get; set; }
        public string ReExpiresIn { get; set; }
        public string RefreshToken { get; set; }
        public string UserId { get; internal set; }
    }
}