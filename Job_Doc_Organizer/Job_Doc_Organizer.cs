using System;
using System.IO;
using System.Windows.Forms;

namespace Job_Doc_Organizer
{
    public partial class Job_Doc_Organizer : Form
    {
        string folderName = @"C:\Users\shivam\Desktop\JOBS";
        string FileName = "JobLink.txt";
        string Orignal_ResumePath = @"C:\Users\shivam\Desktop\Resume.docx";
        string Orignal_CoverLetterPath = @"C:\Users\shivam\Desktop\Cover_Letter.docx";
        string path;
        public Job_Doc_Organizer()
        {
            InitializeComponent();
        }

        private void Create_Directory()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_FolderName.Text) || string.IsNullOrWhiteSpace(Txt_FolderName.Text))
                {
                    MessageBox.Show("Folder Name can't be empty", "Empty Folder Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    path = Path.Combine(folderName, Txt_FolderName.Text);
                    if (Directory.Exists(path))
                    {
                        MessageBox.Show("Directory Name Already Exists", "Duplicate Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Create_JobLinkTxtFile()
        {
            try
            {
                if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show($"Cant Find Folder {Txt_FolderName.Text}", "Invalid Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (string.IsNullOrEmpty(Txt_JobLink.Text) || string.IsNullOrWhiteSpace(Txt_JobLink.Text))
                    {
                        var output = MessageBox.Show("Job link Textbox is Empty, Create Empty TextFile?", "Textbox Empty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (output == DialogResult.Yes)
                        {
                            string newPath = Path.Combine(path, FileName);

                            if (!File.Exists(newPath))
                            {
                                using (FileStream fs = File.Create(newPath))
                                {

                                }
                            }
                        }
                    }
                    else
                    {
                        string newPath = Path.Combine(path, FileName);

                        if (!File.Exists(newPath))
                        {
                            using (FileStream fs = File.Create(newPath))
                            {
                                using (StreamWriter sw = new StreamWriter(fs))
                                {
                                    sw.WriteLine(Txt_JobLink.Text);
                                }
                            }
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Copy_Resume()
        {
            if (Cb_Resume.Checked)
            {
                try
                {
                    string Resume_path = Path.Combine(path, Path.GetFileName(Orignal_ResumePath));
                    File.Copy(Orignal_ResumePath, Resume_path);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Copy_CoverLetter()
        {
            if (Cb_CoverLetter.Checked)
            {
                try
                {
                    string CL_path = Path.Combine(path, Path.GetFileName(Orignal_CoverLetterPath));
                    File.Copy(Orignal_CoverLetterPath, CL_path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void Btn_SaveData_Click(object sender, EventArgs e)
        {
            Create_Directory();
            Create_JobLinkTxtFile();
            Copy_Resume();
            Copy_CoverLetter();
        }
    }
}
