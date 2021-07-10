using System;
using System.Windows.Forms;

namespace WcfStudents.Presentation.WinSite
{
    public partial class boxNumber : Form
    {
        public boxNumber()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (StudentServiceReference.StudentServiceClient client = new StudentServiceReference.StudentServiceClient())
            {
                txtLabel.Text = client.GetStudentById(int.Parse(textBox1.Text));
            }
        }
    }
}
