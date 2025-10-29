namespace Lab2
{
    partial class Bai4
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCourse1 = new System.Windows.Forms.TextBox();
            this.txtCourse2 = new System.Windows.Forms.TextBox();
            this.txtCourse3 = new System.Windows.Forms.TextBox();
            this.txtAVG = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAVGRead = new System.Windows.Forms.TextBox();
            this.txtCourse3Read = new System.Windows.Forms.TextBox();
            this.txtCourse2Read = new System.Windows.Forms.TextBox();
            this.txtCourse1Read = new System.Windows.Forms.TextBox();
            this.txtPhoneRead = new System.Windows.Forms.TextBox();
            this.txtIDRead = new System.Windows.Forms.TextBox();
            this.txtNameRead = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(132, 31);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(160, 39);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write to file";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(948, 31);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(160, 39);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read from file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(132, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(132, 136);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 30);
            this.txtID.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(132, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // txtCourse1
            // 
            this.txtCourse1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse1.Location = new System.Drawing.Point(132, 224);
            this.txtCourse1.Name = "txtCourse1";
            this.txtCourse1.Size = new System.Drawing.Size(160, 30);
            this.txtCourse1.TabIndex = 6;
            // 
            // txtCourse2
            // 
            this.txtCourse2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse2.Location = new System.Drawing.Point(132, 270);
            this.txtCourse2.Name = "txtCourse2";
            this.txtCourse2.Size = new System.Drawing.Size(160, 30);
            this.txtCourse2.TabIndex = 7;
            // 
            // txtCourse3
            // 
            this.txtCourse3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse3.Location = new System.Drawing.Point(132, 327);
            this.txtCourse3.Name = "txtCourse3";
            this.txtCourse3.Size = new System.Drawing.Size(160, 30);
            this.txtCourse3.TabIndex = 8;
            // 
            // txtAVG
            // 
            this.txtAVG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAVG.Location = new System.Drawing.Point(132, 375);
            this.txtAVG.Name = "txtAVG";
            this.txtAVG.ReadOnly = true;
            this.txtAVG.Size = new System.Drawing.Size(160, 30);
            this.txtAVG.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(132, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 39);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAVGRead
            // 
            this.txtAVGRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAVGRead.Location = new System.Drawing.Point(948, 375);
            this.txtAVGRead.Name = "txtAVGRead";
            this.txtAVGRead.ReadOnly = true;
            this.txtAVGRead.Size = new System.Drawing.Size(160, 30);
            this.txtAVGRead.TabIndex = 17;
            // 
            // txtCourse3Read
            // 
            this.txtCourse3Read.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse3Read.Location = new System.Drawing.Point(948, 327);
            this.txtCourse3Read.Name = "txtCourse3Read";
            this.txtCourse3Read.ReadOnly = true;
            this.txtCourse3Read.Size = new System.Drawing.Size(160, 30);
            this.txtCourse3Read.TabIndex = 16;
            // 
            // txtCourse2Read
            // 
            this.txtCourse2Read.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse2Read.Location = new System.Drawing.Point(948, 270);
            this.txtCourse2Read.Name = "txtCourse2Read";
            this.txtCourse2Read.ReadOnly = true;
            this.txtCourse2Read.Size = new System.Drawing.Size(160, 30);
            this.txtCourse2Read.TabIndex = 15;
            // 
            // txtCourse1Read
            // 
            this.txtCourse1Read.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse1Read.Location = new System.Drawing.Point(948, 224);
            this.txtCourse1Read.Name = "txtCourse1Read";
            this.txtCourse1Read.ReadOnly = true;
            this.txtCourse1Read.Size = new System.Drawing.Size(160, 30);
            this.txtCourse1Read.TabIndex = 14;
            // 
            // txtPhoneRead
            // 
            this.txtPhoneRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneRead.Location = new System.Drawing.Point(948, 181);
            this.txtPhoneRead.Name = "txtPhoneRead";
            this.txtPhoneRead.ReadOnly = true;
            this.txtPhoneRead.Size = new System.Drawing.Size(160, 30);
            this.txtPhoneRead.TabIndex = 13;
            // 
            // txtIDRead
            // 
            this.txtIDRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRead.Location = new System.Drawing.Point(948, 136);
            this.txtIDRead.Name = "txtIDRead";
            this.txtIDRead.ReadOnly = true;
            this.txtIDRead.Size = new System.Drawing.Size(160, 30);
            this.txtIDRead.TabIndex = 12;
            // 
            // txtNameRead
            // 
            this.txtNameRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRead.Location = new System.Drawing.Point(948, 91);
            this.txtNameRead.Name = "txtNameRead";
            this.txtNameRead.ReadOnly = true;
            this.txtNameRead.Size = new System.Drawing.Size(160, 30);
            this.txtNameRead.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(907, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 39);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1055, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 39);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Course 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Course 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Course 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Average";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(1009, 428);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(44, 16);
            this.lblPage.TabIndex = 29;
            this.lblPage.Text = "label8";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(414, 31);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(349, 369);
            this.txtOutput.TabIndex = 30;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 521);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAVGRead);
            this.Controls.Add(this.txtCourse3Read);
            this.Controls.Add(this.txtCourse2Read);
            this.Controls.Add(this.txtCourse1Read);
            this.Controls.Add(this.txtPhoneRead);
            this.Controls.Add(this.txtIDRead);
            this.Controls.Add(this.txtNameRead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAVG);
            this.Controls.Add(this.txtCourse3);
            this.Controls.Add(this.txtCourse2);
            this.Controls.Add(this.txtCourse1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCourse1;
        private System.Windows.Forms.TextBox txtCourse2;
        private System.Windows.Forms.TextBox txtCourse3;
        private System.Windows.Forms.TextBox txtAVG;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAVGRead;
        private System.Windows.Forms.TextBox txtCourse3Read;
        private System.Windows.Forms.TextBox txtCourse2Read;
        private System.Windows.Forms.TextBox txtCourse1Read;
        private System.Windows.Forms.TextBox txtPhoneRead;
        private System.Windows.Forms.TextBox txtIDRead;
        private System.Windows.Forms.TextBox txtNameRead;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox txtOutput;
    }
}