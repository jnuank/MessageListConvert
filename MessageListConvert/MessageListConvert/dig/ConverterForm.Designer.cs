namespace MessageListConverter
{
    partial class ConverterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.rdbUpperSnake = new System.Windows.Forms.RadioButton();
            this.rdbToTitleCase = new System.Windows.Forms.RadioButton();
            this.rdbPascal = new System.Windows.Forms.RadioButton();
            this.rdbNotChange = new System.Windows.Forms.RadioButton();
            this.btnConversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(28, 90);
            this.txtDataSource.Multiline = true;
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(364, 246);
            this.txtDataSource.TabIndex = 0;
            // 
            // rdbUpperSnake
            // 
            this.rdbUpperSnake.AutoSize = true;
            this.rdbUpperSnake.Checked = true;
            this.rdbUpperSnake.Location = new System.Drawing.Point(28, 26);
            this.rdbUpperSnake.Name = "rdbUpperSnake";
            this.rdbUpperSnake.Size = new System.Drawing.Size(114, 19);
            this.rdbUpperSnake.TabIndex = 1;
            this.rdbUpperSnake.TabStop = true;
            this.rdbUpperSnake.Text = "SNAKE_CASE";
            this.rdbUpperSnake.UseVisualStyleBackColor = true;
            // 
            // rdbToTitleCase
            // 
            this.rdbToTitleCase.AutoSize = true;
            this.rdbToTitleCase.Location = new System.Drawing.Point(157, 26);
            this.rdbToTitleCase.Name = "rdbToTitleCase";
            this.rdbToTitleCase.Size = new System.Drawing.Size(105, 19);
            this.rdbToTitleCase.TabIndex = 2;
            this.rdbToTitleCase.Text = "ToTitleCase";
            this.rdbToTitleCase.UseVisualStyleBackColor = true;
            // 
            // rdbPascal
            // 
            this.rdbPascal.AutoSize = true;
            this.rdbPascal.Location = new System.Drawing.Point(291, 26);
            this.rdbPascal.Name = "rdbPascal";
            this.rdbPascal.Size = new System.Drawing.Size(101, 19);
            this.rdbPascal.TabIndex = 3;
            this.rdbPascal.Text = "PascalCase";
            this.rdbPascal.UseVisualStyleBackColor = true;
            // 
            // rdbNotChange
            // 
            this.rdbNotChange.AutoSize = true;
            this.rdbNotChange.Location = new System.Drawing.Point(291, 65);
            this.rdbNotChange.Name = "rdbNotChange";
            this.rdbNotChange.Size = new System.Drawing.Size(82, 19);
            this.rdbNotChange.TabIndex = 4;
            this.rdbNotChange.Text = "変換なし";
            this.rdbNotChange.UseVisualStyleBackColor = true;
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(181, 356);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(211, 35);
            this.btnConversion.TabIndex = 5;
            this.btnConversion.Text = "変換＆クリップボードにコピー";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 403);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.rdbNotChange);
            this.Controls.Add(this.rdbPascal);
            this.Controls.Add(this.rdbToTitleCase);
            this.Controls.Add(this.rdbUpperSnake);
            this.Controls.Add(this.txtDataSource);
            this.Name = "ConverterForm";
            this.Text = "ConverterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.RadioButton rdbUpperSnake;
        private System.Windows.Forms.RadioButton rdbToTitleCase;
        private System.Windows.Forms.RadioButton rdbPascal;
        private System.Windows.Forms.RadioButton rdbNotChange;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Label lblResult;
    }
}