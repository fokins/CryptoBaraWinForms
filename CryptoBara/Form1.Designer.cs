using System.Threading.Tasks;
using System.Threading;

namespace CryptoBara
{
    partial class Form1
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
            this.BinanceText = new System.Windows.Forms.Label();
            this.BinancePriceBox = new System.Windows.Forms.TextBox();
            this.GetPricesButton = new System.Windows.Forms.Button();
            this.KrakenText = new System.Windows.Forms.Label();
            this.KrakenPriceBox = new System.Windows.Forms.TextBox();
            this.KucoinText = new System.Windows.Forms.Label();
            this.KucoinPriceBox = new System.Windows.Forms.TextBox();
            this.GateioText = new System.Windows.Forms.Label();
            this.GateioPriceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BinanceText
            // 
            this.BinanceText.AutoSize = true;
            this.BinanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinanceText.Location = new System.Drawing.Point(12, 9);
            this.BinanceText.Name = "BinanceText";
            this.BinanceText.Size = new System.Drawing.Size(67, 20);
            this.BinanceText.TabIndex = 0;
            this.BinanceText.Text = "Binance";
            // 
            // BinancePriceBox
            // 
            this.BinancePriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinancePriceBox.Location = new System.Drawing.Point(13, 34);
            this.BinancePriceBox.Multiline = true;
            this.BinancePriceBox.Name = "BinancePriceBox";
            this.BinancePriceBox.Size = new System.Drawing.Size(775, 40);
            this.BinancePriceBox.TabIndex = 1;
            // 
            // GetPricesButton
            // 
            this.GetPricesButton.Location = new System.Drawing.Point(16, 329);
            this.GetPricesButton.Name = "GetPricesButton";
            this.GetPricesButton.Size = new System.Drawing.Size(117, 49);
            this.GetPricesButton.TabIndex = 2;
            this.GetPricesButton.Text = "Get prices";
            this.GetPricesButton.UseVisualStyleBackColor = true;
            this.GetPricesButton.Click += new System.EventHandler(this.GetPricesButton_Click);
            // 
            // KrakenText
            // 
            this.KrakenText.AutoSize = true;
            this.KrakenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KrakenText.Location = new System.Drawing.Point(12, 77);
            this.KrakenText.Name = "KrakenText";
            this.KrakenText.Size = new System.Drawing.Size(59, 20);
            this.KrakenText.TabIndex = 3;
            this.KrakenText.Text = "Kraken";
            // 
            // KrakenPriceBox
            // 
            this.KrakenPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KrakenPriceBox.Location = new System.Drawing.Point(13, 100);
            this.KrakenPriceBox.Multiline = true;
            this.KrakenPriceBox.Name = "KrakenPriceBox";
            this.KrakenPriceBox.Size = new System.Drawing.Size(775, 40);
            this.KrakenPriceBox.TabIndex = 4;
            // 
            // KucoinText
            // 
            this.KucoinText.AutoSize = true;
            this.KucoinText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KucoinText.Location = new System.Drawing.Point(12, 143);
            this.KucoinText.Name = "KucoinText";
            this.KucoinText.Size = new System.Drawing.Size(57, 20);
            this.KucoinText.TabIndex = 5;
            this.KucoinText.Text = "Kucoin";
            // 
            // KucoinPriceBox
            // 
            this.KucoinPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KucoinPriceBox.Location = new System.Drawing.Point(13, 166);
            this.KucoinPriceBox.Multiline = true;
            this.KucoinPriceBox.Name = "KucoinPriceBox";
            this.KucoinPriceBox.Size = new System.Drawing.Size(775, 40);
            this.KucoinPriceBox.TabIndex = 6;
            // 
            // GateioText
            // 
            this.GateioText.AutoSize = true;
            this.GateioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GateioText.Location = new System.Drawing.Point(12, 209);
            this.GateioText.Name = "GateioText";
            this.GateioText.Size = new System.Drawing.Size(59, 20);
            this.GateioText.TabIndex = 7;
            this.GateioText.Text = "GateIo";
            // 
            // GateioPriceBox
            // 
            this.GateioPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GateioPriceBox.Location = new System.Drawing.Point(13, 232);
            this.GateioPriceBox.Multiline = true;
            this.GateioPriceBox.Name = "GateioPriceBox";
            this.GateioPriceBox.Size = new System.Drawing.Size(775, 40);
            this.GateioPriceBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GateioPriceBox);
            this.Controls.Add(this.GateioText);
            this.Controls.Add(this.KucoinPriceBox);
            this.Controls.Add(this.KucoinText);
            this.Controls.Add(this.KrakenPriceBox);
            this.Controls.Add(this.KrakenText);
            this.Controls.Add(this.GetPricesButton);
            this.Controls.Add(this.BinancePriceBox);
            this.Controls.Add(this.BinanceText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BinanceText;
        private System.Windows.Forms.TextBox BinancePriceBox;
        private System.Windows.Forms.Button GetPricesButton;
        private System.Windows.Forms.Label KrakenText;
        private System.Windows.Forms.TextBox KrakenPriceBox;
        private System.Windows.Forms.Label KucoinText;
        private System.Windows.Forms.TextBox KucoinPriceBox;
        private System.Windows.Forms.Label GateioText;
        private System.Windows.Forms.TextBox GateioPriceBox;
    }
}

