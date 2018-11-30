namespace konverter1
{
    partial class CurrencyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageBox = new System.Windows.Forms.TextBox();
            this.fromAmount = new System.Windows.Forms.TextBox();
            this.toAmount = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.fromCurrency = new System.Windows.Forms.ComboBox();
            this.toCurrency = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(124, 11);
            this.messageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(252, 211);
            this.messageBox.TabIndex = 0;
            // 
            // fromAmount
            // 
            this.fromAmount.Location = new System.Drawing.Point(124, 256);
            this.fromAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromAmount.Name = "fromAmount";
            this.fromAmount.Size = new System.Drawing.Size(102, 20);
            this.fromAmount.TabIndex = 1;
            this.fromAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FromAmont_KeyUp);
            // 
            // toAmount
            // 
            this.toAmount.Location = new System.Drawing.Point(273, 255);
            this.toAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toAmount.Name = "toAmount";
            this.toAmount.ReadOnly = true;
            this.toAmount.Size = new System.Drawing.Size(103, 20);
            this.toAmount.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(124, 295);
            this.convertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(252, 26);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Перевести";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // fromCurrency
            // 
            this.fromCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromCurrency.FormattingEnabled = true;
            this.fromCurrency.Items.AddRange(new object[] {
            "BYN",
            "USD",
            "EUR",
            "RUB"});
            this.fromCurrency.Location = new System.Drawing.Point(28, 255);
            this.fromCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromCurrency.Name = "fromCurrency";
            this.fromCurrency.Size = new System.Drawing.Size(92, 21);
            this.fromCurrency.TabIndex = 6;
            // 
            // toCurrency
            // 
            this.toCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toCurrency.FormattingEnabled = true;
            this.toCurrency.Items.AddRange(new object[] {
            "BYN",
            "USD",
            "EUR",
            "RUB"});
            this.toCurrency.Location = new System.Drawing.Point(380, 254);
            this.toCurrency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toCurrency.Name = "toCurrency";
            this.toCurrency.Size = new System.Drawing.Size(92, 21);
            this.toCurrency.TabIndex = 7;
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 355);
            this.Controls.Add(this.toCurrency);
            this.Controls.Add(this.fromCurrency);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.toAmount);
            this.Controls.Add(this.fromAmount);
            this.Controls.Add(this.messageBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CurrencyForm";
            this.Text = "Currency-Converter by Smotruk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox fromAmount;
        private System.Windows.Forms.TextBox toAmount;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox fromCurrency;
        private System.Windows.Forms.ComboBox toCurrency;
    }
}

