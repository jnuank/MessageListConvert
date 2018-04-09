namespace MessageListConverter.Logic
{
    /// <summary>
    /// 文字列の拡張クラス
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 先頭を大文字にする拡張メソッド
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ToTitleCase(this string self)
        {
            // 全てが大文字の場合だと、変換をしてくれない為、一旦ToLower()で小文字に変換している。
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(self.ToLower());
        }
    }
}