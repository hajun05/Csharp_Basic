namespace Csharp_Basic
{
    partial class PP_MultiThread
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
            this.comboBoxMultiThread = new System.Windows.Forms.ComboBox();
            this.buttonStartFileSearch = new System.Windows.Forms.Button();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.dataGridViewFileInform = new System.Windows.Forms.DataGridView();
            this.FileExtention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileInform)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMultiThread
            // 
            this.comboBoxMultiThread.FormattingEnabled = true;
            this.comboBoxMultiThread.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMultiThread.Name = "comboBoxMultiThread";
            this.comboBoxMultiThread.Size = new System.Drawing.Size(182, 23);
            this.comboBoxMultiThread.TabIndex = 0;
            this.comboBoxMultiThread.Text = "멀티 스레드 방식";
            // 
            // buttonStartFileSearch
            // 
            this.buttonStartFileSearch.Location = new System.Drawing.Point(200, 12);
            this.buttonStartFileSearch.Name = "buttonStartFileSearch";
            this.buttonStartFileSearch.Size = new System.Drawing.Size(179, 24);
            this.buttonStartFileSearch.TabIndex = 1;
            this.buttonStartFileSearch.Text = "파일 검색 시작";
            this.buttonStartFileSearch.UseVisualStyleBackColor = true;
            this.buttonStartFileSearch.Click += new System.EventHandler(this.buttonStartFileSearch_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(13, 42);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(366, 25);
            this.textBoxDirectory.TabIndex = 2;
            // 
            // dataGridViewFileInform
            // 
            this.dataGridViewFileInform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFileInform.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewFileInform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileInform.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileExtention,
            this.FileName,
            this.FileDirectory});
            this.dataGridViewFileInform.Location = new System.Drawing.Point(13, 108);
            this.dataGridViewFileInform.Name = "dataGridViewFileInform";
            this.dataGridViewFileInform.RowHeadersVisible = false;
            this.dataGridViewFileInform.RowHeadersWidth = 51;
            this.dataGridViewFileInform.RowTemplate.Height = 27;
            this.dataGridViewFileInform.Size = new System.Drawing.Size(366, 362);
            this.dataGridViewFileInform.TabIndex = 3;
            // 
            // FileExtention
            // 
            this.FileExtention.FillWeight = 30F;
            this.FileExtention.HeaderText = "확장자";
            this.FileExtention.MinimumWidth = 6;
            this.FileExtention.Name = "FileExtention";
            // 
            // FileName
            // 
            this.FileName.FillWeight = 50F;
            this.FileName.HeaderText = "파일 이름";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            // 
            // FileDirectory
            // 
            this.FileDirectory.FillWeight = 85.5615F;
            this.FileDirectory.HeaderText = "파일 경로";
            this.FileDirectory.MinimumWidth = 6;
            this.FileDirectory.Name = "FileDirectory";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 74);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(284, 23);
            this.progressBar.TabIndex = 4;
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(303, 74);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(76, 23);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = ":ms";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PP_MultiThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 482);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dataGridViewFileInform);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.buttonStartFileSearch);
            this.Controls.Add(this.comboBoxMultiThread);
            this.Name = "PP_MultiThread";
            this.Text = "Form_1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileInform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMultiThread;
        private System.Windows.Forms.Button buttonStartFileSearch;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.DataGridView dataGridViewFileInform;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileExtention;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDirectory;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelTime;
    }
}