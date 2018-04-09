using System;
using System.Windows.Forms;
using MessageListConverter.Logic;
using static MessageListConverter.Logic.MessageListConversion;

namespace MessageListConverter
{
    /// <summary>
    /// コンバート画面
    /// </summary>
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 変換ボタンのイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConversion_Click(object sender, EventArgs e)
        {
            MessageListConversion logic = new MessageListConversion();

            string result = string.Empty;

            if (rdbUpperSnake.Checked)
                result = logic.Conversion(txtDataSource.Text, ConversionMode.SNAKE);

            if (rdbToTitleCase.Checked)
                result = logic.Conversion(txtDataSource.Text, ConversionMode.TITLE_CAMEL);

            if (rdbPascal.Checked)
                result = logic.Conversion(txtDataSource.Text, ConversionMode.PASCAL_CASE);

            if (rdbNotChange.Checked)
                result = logic.Conversion(txtDataSource.Text, ConversionMode.NO_CHANGE);

            // 変換結果をクリップボードにコピーする。
            Clipboard.SetText(result, TextDataFormat.Text);

            MessageBox.Show("クリップボードにコピーしました");

        }
    }
}