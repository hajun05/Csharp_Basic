namespace Using_VendingMachine
{
    partial class VendingMachine
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
            this.Card_pay = new System.Windows.Forms.Button();
            this.Cash_pay = new System.Windows.Forms.Button();
            this.Beverage_price = new System.Windows.Forms.Label();
            this.Beverage_name = new System.Windows.Forms.TextBox();
            this.Beverage_output = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.VendingMachineBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Card_pay
            // 
            this.Card_pay.Location = new System.Drawing.Point(15, 151);
            this.Card_pay.Name = "Card_pay";
            this.Card_pay.Size = new System.Drawing.Size(100, 23);
            this.Card_pay.TabIndex = 0;
            this.Card_pay.Text = "카드 결제";
            this.Card_pay.UseVisualStyleBackColor = true;
            this.Card_pay.Click += new System.EventHandler(this.Card_pay_Click);
            // 
            // Cash_pay
            // 
            this.Cash_pay.Location = new System.Drawing.Point(121, 151);
            this.Cash_pay.Name = "Cash_pay";
            this.Cash_pay.Size = new System.Drawing.Size(100, 23);
            this.Cash_pay.TabIndex = 1;
            this.Cash_pay.Text = "현금 결제";
            this.Cash_pay.UseVisualStyleBackColor = true;
            this.Cash_pay.Click += new System.EventHandler(this.Cash_pay_Click);
            // 
            // Beverage_price
            // 
            this.Beverage_price.Location = new System.Drawing.Point(12, 120);
            this.Beverage_price.Name = "Beverage_price";
            this.Beverage_price.Size = new System.Drawing.Size(209, 28);
            this.Beverage_price.TabIndex = 2;
            this.Beverage_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Beverage_name
            // 
            this.Beverage_name.Location = new System.Drawing.Point(12, 12);
            this.Beverage_name.Multiline = true;
            this.Beverage_name.Name = "Beverage_name";
            this.Beverage_name.Size = new System.Drawing.Size(209, 105);
            this.Beverage_name.TabIndex = 3;
            this.Beverage_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Beverage_output
            // 
            this.Beverage_output.Location = new System.Drawing.Point(12, 211);
            this.Beverage_output.Name = "Beverage_output";
            this.Beverage_output.Size = new System.Drawing.Size(209, 25);
            this.Beverage_output.TabIndex = 4;
            this.Beverage_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Beverage_output.Click += new System.EventHandler(this.Beverage_output_Click);
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(12, 180);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(209, 25);
            this.Balance.TabIndex = 5;
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // VendingMachineBack
            // 
            this.VendingMachineBack.Location = new System.Drawing.Point(228, 13);
            this.VendingMachineBack.Name = "VendingMachineBack";
            this.VendingMachineBack.Size = new System.Drawing.Size(43, 224);
            this.VendingMachineBack.TabIndex = 6;
            this.VendingMachineBack.Text = "음료 재고 채우기";
            this.VendingMachineBack.UseVisualStyleBackColor = true;
            this.VendingMachineBack.Click += new System.EventHandler(this.VendingMachineBack_Click);
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 249);
            this.Controls.Add(this.VendingMachineBack);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Beverage_output);
            this.Controls.Add(this.Beverage_name);
            this.Controls.Add(this.Beverage_price);
            this.Controls.Add(this.Cash_pay);
            this.Controls.Add(this.Card_pay);
            this.Name = "VendingMachine";
            this.Text = "Vending Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Card_pay;
        private System.Windows.Forms.Button Cash_pay;
        private System.Windows.Forms.Label Beverage_price;
        private System.Windows.Forms.TextBox Beverage_name;
        private System.Windows.Forms.TextBox Beverage_output;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Button VendingMachineBack;
    }
}

