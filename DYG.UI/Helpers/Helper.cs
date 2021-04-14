namespace DYG.UI.Helpers
{
    public static class Helper
    {
        public static string ToLink(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            
            var replacedLink = value.Trim().ToLower();
        
            replacedLink = replacedLink.Replace("\t", " ");
            replacedLink = replacedLink.Replace("   ", " ");
            replacedLink = replacedLink.Replace("  ", " ");
            replacedLink = replacedLink.Replace(" ", "-");
            replacedLink = replacedLink.Replace(",", "");
            replacedLink = replacedLink.Replace("ç", "c");
            replacedLink = replacedLink.Replace("ğ", "g");
            replacedLink = replacedLink.Replace("ı", "i");
            replacedLink = replacedLink.Replace("ö", "o");
            replacedLink = replacedLink.Replace("ş", "s");
            replacedLink = replacedLink.Replace("ü", "u");
            replacedLink = replacedLink.Replace("…", "");
            replacedLink = replacedLink.Replace("..", "");
            replacedLink = replacedLink.Replace(".", "");
            replacedLink = replacedLink.Replace("‘", "");
            replacedLink = replacedLink.Replace("”", "");
            replacedLink = replacedLink.Replace("û", "u");
            replacedLink = replacedLink.Replace("â", "a");
            replacedLink = replacedLink.Replace("’", "");
            replacedLink = replacedLink.Replace("–", "-");
            replacedLink = replacedLink.Replace(":", "");
            replacedLink = replacedLink.Replace("�", "");
            
            return replacedLink;
        }

        public static string GetUrl(this string mainCategory, string title, string newsId)
        {
            return $"ntv.com.tr/{mainCategory}/{title.ToLink()},{newsId}";
        }
    }
}