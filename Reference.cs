namespace Isotope
{
    public readonly struct Reference
    {
        /// <summary>
        /// API URL.
        /// </summary>
        public const string BASE_URL = "https://discordapp.com/api";

        /// <summary>
        /// API Version.
        /// </summary>
        public const int API_VERSION = 6;

        /// <summary>
        /// 
        /// </summary>
        public const string IMAGE_BASE_URL = "https://cdn.discordapp.com/";

        /// <summary>
        /// {0} = Emoji ID | {1} = Emoji Ext
        /// </summary>
        public const string CDN_EMOJI = "emojis/{0}.{1}";

        /// <summary>
        /// {0} = Guild ID, 
        /// </summary>
        public const string CDN_GUILD_ICON = "icons/{0}/{1}.{3}";
    }
}