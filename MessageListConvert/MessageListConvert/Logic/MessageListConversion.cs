using System;
using System.Text;

namespace MessageListConverter.Logic
{
    /// <summary>
    /// メッセージリストを定数stringのコードに変換するクラス
    /// </summary>
    public class MessageListConversion
    {
        private static readonly string PREFIX = "public static readonly string ";

        // コンバート方式
        public enum ConversionMode
        {
            NO_CHANGE = 0,
            SNAKE,
            TITLE_CAMEL,
            PASCAL_CASE,
        }

        /// <summary>
        /// データソースを元に、readonly static string ～～のコードを吐き出す。
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public string Conversion(string dataSource, ConversionMode mode = ConversionMode.NO_CHANGE)
        {
            if (string.IsNullOrEmpty(dataSource))
                return "";

            dataSource = dataSource.Replace(Environment.NewLine, "\r");

            string[] oneLine = dataSource.Split('\r');

            StringBuilder sb = new StringBuilder();
            string variableName = string.Empty;

            // 1行ずつコードに変換していく
            foreach (var item in oneLine)
            {
                // 末尾まで来たらforeachを抜ける
                if (string.IsNullOrEmpty(item))
                    break;

                string[] splited = item.Split('\t');

                switch (mode)
                {
                    case ConversionMode.SNAKE:
                        variableName = splited[0].Replace(' ', '_').ToUpper();
                        break;

                    case ConversionMode.TITLE_CAMEL:

                        variableName = splited[0].Replace(" ", "").ToTitleCase();
                        break;

                    case ConversionMode.PASCAL_CASE:
                        variableName = string.Empty;
                        foreach (var word in splited[0].Split(' '))
                        {
                            variableName += word.ToTitleCase();
                        }

                        break;

                    default:
                        variableName = splited[0].Replace(" ", "");
                        break;
                }

                sb.Append($"{PREFIX}{variableName} = \"{splited[1]}\";\r");
            }

            return sb.ToString();
        }
    }
}