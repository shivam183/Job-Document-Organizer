using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Doc_Organizer
{
    public partial class Job_Doc_Organizer : Form
    {
        string path;
        public Job_Doc_Organizer()
        {
            InitializeComponent();
        }

        private void Create_Directory()
        {
            
            string folderName = @"C:\Users\shivam\Desktop\JOBS";
            path = Path.Combine(folderName, Txt_FolderName.Text);
            Directory.CreateDirectory(path);
        }

        private void Create_JobLinkTxtFile()
        {
            string FileName = "JobLink.txt";
            string newPath = Path.Combine(path, FileName);

            if(!File.Exists(newPath))
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

        private void Copy_Resume()
        {
            if(Cb_Resume.Checked)
            {
                string Orignal_Path = @"C:\Users\shivam\Desktop\Resume.docx";
                string Resume_path = Path.Combine(path,Path.GetFileName(Orignal_Path));
                File.Copy(Orignal_Path, Resume_path);
            }
        }

        private void Copy_CoverLetter()
        {
            if(Cb_CoverLetter.Checked)
            {
                string Orignal_Path = @"C:\Users\shivam\Desktop\Cover_Letter.docx";
                string CL_path = Path.Combine(path, Path.GetFileName(Orignal_Path));
                File.Copy(Orignal_Path, CL_path);
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
