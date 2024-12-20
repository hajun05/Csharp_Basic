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
            this.InputButton = new System.Windows.Forms.Button();
            this.InstructionText = new System.Windows.Forms.TextBox();
            this.StudentsScoreGridView = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Math = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsNum = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsScoreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(76, 34);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(103, 25);
            this.InputText.TabIndex = 0;
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputButton.Location = new System.Drawing.Point(185, 34);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(84, 26);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "Input";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputTextButtonClick);
            // 
            // InstructionText
            // 
            this.InstructionText.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionText.Location = new System.Drawing.Point(13, 3);
            this.InstructionText.Name = "InstructionText";
            this.InstructionText.Size = new System.Drawing.Size(358, 25);
            this.InstructionText.TabIndex = 3;
            this.InstructionText.Text = "학생 수를 입력하십시오.";
            this.InstructionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentsScoreGridView
            // 
            this.StudentsScoreGridView.AllowUserToAddRows = false;
            this.StudentsScoreGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsScoreGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.StudentsScoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsScoreGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Korean,
            this.Math,
            this.English});
            this.StudentsScoreGridView.Location = new System.Drawing.Point(13, 66);
            this.StudentsScoreGridView.Name = "StudentsScoreGridView";
            this.StudentsScoreGridView.RowHeadersVisible = false;
            this.StudentsScoreGridView.RowHeadersWidth = 51;
            this.StudentsScoreGridView.RowTemplate.Height = 27;
            this.StudentsScoreGridView.Size = new System.Drawing.Size(358, 372);
            this.StudentsScoreGridView.TabIndex = 4;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Student.HeaderText = "학생";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.Width = 66;
            // 
            // Korean
            // 
            this.Korean.HeaderText = "국어";
            this.Korean.MinimumWidth = 6;
            this.Korean.Name = "Korean";
            // 
            // Math
            // 
            this.Math.HeaderText = "수학";
            this.Math.MinimumWidth = 6;
            this.Math.Name = "Math";
            // 
            // English
            // 
            this.English.HeaderText = "영어";
            this.English.MinimumWidth = 6;
            this.English.Name = "English";
            // 
            // StudentsNum
            // 
            this.StudentsNum.Location = new System.Drawing.Point(13, 37);
            this.StudentsNum.Name = "StudentsNum";
            this.StudentsNum.Size = new System.Drawing.Size(57, 22);
            this.StudentsNum.TabIndex = 5;
            this.StudentsNum.Text = "학생 수";
            this.StudentsNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExportButton.Location = new System.Drawing.Point(275, 33);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(96, 26);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButtonClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.StudentsNum);
            this.Controls.Add(this.StudentsScoreGridView);
            this.Controls.Add(this.InstructionText);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputText);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsScoreGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.TextBox InstructionText;
        private System.Windows.Forms.DataGridView StudentsScoreGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Math;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private System.Windows.Forms.Label StudentsNum;
        private System.Windows.Forms.Button ExportButton;
    }
}