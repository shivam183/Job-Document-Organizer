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
            path = Path.Combine(path, FileName);

            if(!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
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
