using MessageListConverter.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static MessageListConverter.Logic.MessageListConversion;

namespace WindowsFormsApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var logic = new MessageListConversion();

            string str = "";

            ConversionMode mode = ConversionMode.SNAKE;

            string result = logic.Conversion(str, mode);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var logic = new MessageListConversion();

            string str = "Error	エラー\rINFORMATION	情報";

            string result = logic.Conversion(str, ConversionMode.SNAKE);

            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var logic = new MessageListConversion();

            string str = "Error	エラー\rINFORMATION	情報";

            string result = logic.Conversion(str, ConversionMode.SNAKE);

            Assert.AreEqual("public static readonly string ERROR = \"エラー\";\rpublic static readonly string INFORMATION = \"情報\";\r", result);

        }

        [TestMethod]
        public void TestMethod4()
        {
            var logic = new MessageListConversion();

            string str = "Error	エラー\rINFORMATION	情報";

            string result = logic.Conversion(str, ConversionMode.TITLE_CAMEL);

            Assert.AreEqual("public static readonly string Error = \"エラー\";\rpublic static readonly string Information = \"情報\";\r", result);

        }


        [TestMethod]
        public void TestMethod5()
        {
            var logic = new MessageListConversion();

            string str = "Error Message	エラー\r\nINFORMATION	情報";

            string result = logic.Conversion(str, ConversionMode.SNAKE);

            Assert.AreEqual("public static readonly string ERROR_MESSAGE = \"エラー\";\rpublic static readonly string INFORMATION = \"情報\";\r", result);

        }

        [TestMethod]
        public void TestMethod6()
        {
            var logic = new MessageListConversion();

            string str = "Error Message	エラー\rINFORMATION	情報";

            string result = logic.Conversion(str, ConversionMode.PASCAL_CASE);

            Assert.AreEqual("public static readonly string ErrorMessage = \"エラー\";\rpublic static readonly string Information = \"情報\";\r", result);

        }

        [TestMethod]
        public void TestMethod7()
        {
            var logic = new MessageListConversion();

            string str = "Error Message	エラー\rINFORMATION TEST	情報";

            string result = logic.Conversion(str, ConversionMode.PASCAL_CASE);

            Assert.AreEqual("public static readonly string ErrorMessage = \"エラー\";\rpublic static readonly string InformationTest = \"情報\";\r", result);

        }

        [TestMethod]
        public void TestMethod8()
        {
            var logic = new MessageListConversion();

            string str = "Error Message	エラー\rINFORMATION TEST	情報";

            string result = logic.Conversion(str, ConversionMode.TITLE_CAMEL);

            Assert.AreEqual("public static readonly string Errormessage = \"エラー\";\rpublic static readonly string Informationtest = \"情報\";\r", result);

        }

    }
}