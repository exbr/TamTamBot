namespace ExLib.TamTam.Bot
{
    public static class Version
    {
        private const int Major = 0;
        private const int Minor = 2;
        private const int Build = 0;
        private static readonly string _version = $"{Major}.{Minor}.{Build}";


        public static string Get()
        {
            return _version;
        }
    }
}
