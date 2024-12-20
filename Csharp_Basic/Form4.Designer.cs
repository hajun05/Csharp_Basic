namespace Csharp_Basic
{
    partial class Form4
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.InstructionText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(13, 34);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(152, 25);
            this.InputText.TabIndex = 0;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(13, 65);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(233, 328);
            this.OutputText.TabIndex = 1;
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputButton.Location = new System.Drawing.Point(171, 31);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 25);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "input";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputTextButtonClick);
            // 
            // InstructionText
            // 
            this.InstructionText.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionText.Location = new System.Drawing.Point(13, 3);
            this.InstructionText.Name = "InstructionText";
            this.InstructionText.Size = new System.Drawing.Size(233, 25);
            this.InstructionText.TabIndex = 3;
            this.InstructionText.Text = "학생 수를 입력하십시오.";
            this.InstructionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 450);
            this.Controls.Add(this.InstructionText);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.InputText);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.TextBox InstructionText;
    }
}