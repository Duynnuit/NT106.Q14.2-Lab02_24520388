namespace Lab2
{
    partial class Bai2
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lbtLineCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtCharacterCount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.Location = new System.Drawing.Point(12, 12);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(163, 53);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(581, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(343, 338);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(12, 78);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(109, 25);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "File name";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(12, 127);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(50, 25);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(12, 176);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(61, 25);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "URL";
            // 
            // lbtLineCount
            // 
            this.lbtLineCount.AutoSize = true;
            this.lbtLineCount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtLineCount.Location = new System.Drawing.Point(12, 225);
            this.lbtLineCount.Name = "lbtLineCount";
            this.lbtLineCount.Size = new System.Drawing.Size(119, 25);
            this.lbtLineCount.TabIndex = 5;
            this.lbtLineCount.Text = "Line count";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCount.Location = new System.Drawing.Point(13, 274);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(131, 25);
            this.lblWordCount.TabIndex = 6;
            this.lblWordCount.Text = "Word count";
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterCount.Location = new System.Drawing.Point(12, 319);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(179, 25);
            this.lblCharacterCount.TabIndex = 7;
            this.lblCharacterCount.Text = "Character count";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(222, 75);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(282, 34);
            this.txtFileName.TabIndex = 8;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(222, 124);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(283, 34);
            this.txtSize.TabIndex = 9;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(222, 173);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(283, 34);
            this.txtURL.TabIndex = 10;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineCount.Location = new System.Drawing.Point(222, 222);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.ReadOnly = true;
            this.txtLineCount.Size = new System.Drawing.Size(283, 34);
            this.txtLineCount.TabIndex = 11;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordCount.Location = new System.Drawing.Point(222, 271);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.ReadOnly = true;
            this.txtWordCount.Size = new System.Drawing.Size(284, 34);
            this.txtWordCount.TabIndex = 12;
            // 
            // txtCharacterCount
            // 
            this.txtCharacterCount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterCount.Location = new System.Drawing.Point(222, 316);
            this.txtCharacterCount.Name = "txtCharacterCount";
            this.txtCharacterCount.ReadOnly = true;
            this.txtCharacterCount.Size = new System.Drawing.Size(283, 34);
            this.txtCharacterCount.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(417, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 43);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 422);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCharacterCount);
            this.Controls.Add(this.txtWordCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lbtLineCount);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDocFile);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lbtLineCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblCharacterCount;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtCharacterCount;
        private System.Windows.Forms.Button btnExit;
    }
}