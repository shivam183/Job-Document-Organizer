namespace Job_Doc_Organizer
{
    partial class Job_Doc_Organizer
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
            this.Txt_FolderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_JobLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_SaveData = new System.Windows.Forms.Button();
            this.Btn_ClearForm = new System.Windows.Forms.Button();
            this.Cb_Resume = new System.Windows.Forms.CheckBox();
            this.Cb_CoverLetter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Txt_FolderName
            // 
            this.Txt_FolderName.Location = new System.Drawing.Point(113, 12);
            this.Txt_FolderName.Name = "Txt_FolderName";
            this.Txt_FolderName.Size = new System.Drawing.Size(191, 20);
            this.Txt_FolderName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Folder Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Link:";
            // 
            // Txt_JobLink
            // 
            this.Txt_JobLink.Location = new System.Drawing.Point(113, 41);
            this.Txt_JobLink.Name = "Txt_JobLink";
            this.Txt_JobLink.Size = new System.Drawing.Size(191, 20);
            this.Txt_JobLink.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Include Resume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Include CoverLetter:";
            // 
            // Btn_SaveData
            // 
            this.Btn_SaveData.Location = new System.Drawing.Point(35, 140);
            this.Btn_SaveData.Name = "Btn_SaveData";
            this.Btn_SaveData.Size = new System.Drawing.Size(129, 23);
            this.Btn_SaveData.TabIndex = 10;
            this.Btn_SaveData.Text = "SaveData";
            this.Btn_SaveData.UseVisualStyleBackColor = true;
            this.Btn_SaveData.Click += new System.EventHandler(this.Btn_SaveData_Click);
            // 
            // Btn_ClearForm
            // 
            this.Btn_ClearForm.Location = new System.Drawing.Point(181, 140);
            this.Btn_ClearForm.Name = "Btn_ClearForm";
            this.Btn_ClearForm.Size = new System.Drawing.Size(123, 23);
            this.Btn_ClearForm.TabIndex = 11;
            this.Btn_ClearForm.Text = "Clear Form";
            this.Btn_ClearForm.UseVisualStyleBackColor = true;
            this.Btn_ClearForm.Click += new System.EventHandler(this.Btn_ClearForm_Click);
            // 
            // Cb_Resume
            // 
            this.Cb_Resume.AutoSize = true;
            this.Cb_Resume.Location = new System.Drawing.Point(113, 77);
            this.Cb_Resume.Name = "Cb_Resume";
            this.Cb_Resume.Size = new System.Drawing.Size(15, 14);
            this.Cb_Resume.TabIndex = 5;
            this.Cb_Resume.UseVisualStyleBackColor = true;
            // 
            // Cb_CoverLetter
            // 
            this.Cb_CoverLetter.AutoSize = true;
            this.Cb_CoverLetter.Location = new System.Drawing.Point(113, 108);
            this.Cb_CoverLetter.Name = "Cb_CoverLetter";
            this.Cb_CoverLetter.Size = new System.Drawing.Size(15, 14);
            this.Cb_CoverLetter.TabIndex = 6;
            this.Cb_CoverLetter.UseVisualStyleBackColor = true;
            // 
            // Job_Doc_Organizer
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 175);
            this.Controls.Add(this.Cb_CoverLetter);
            this.Controls.Add(this.Cb_Resume);
            this.Controls.Add(this.Btn_ClearForm);
            this.Controls.Add(this.Btn_SaveData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_JobLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_FolderName);
            this.MaximizeBox = false;
            this.Name = "Job_Doc_Organizer";
            this.Text = "Job Document Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_FolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_JobLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_SaveData;
        private System.Windows.Forms.Button Btn_ClearForm;
        private System.Windows.Forms.CheckBox Cb_Resume;
        private System.Windows.Forms.CheckBox Cb_CoverLetter;
    }
}

