namespace Vysn.Comons
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct Markdown
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string SingleLineCodeblock(string content)
            => $"`{content}`";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="language"></param>
        /// <returns></returns>
        public static string CodeBlock(string content, string language = default)
            => $"```{language}\n{content}\n```";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string Italics(string content)
            => $"*{content}*";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string Bold(string content)
            => $"**{content}**";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string BoldItalics(string content)
            => $"***{content}***";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string Underline(string content)
            => $"__{content}__";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string Strikethrough(string content)
            => $"~~{content}~~";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string UnderlineItalics(string content)
            => $"__*{content}*__";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string UnderlineBold(string content)
            => $"__**{content}**__";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string UnderlineBoldItalics(string content)
            => $"__***{content}***___";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string SingleLineBlockQuote(string content)
            => $"> {content}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string BlockQuote(string content)
            => $">>> {content}";
    }
}