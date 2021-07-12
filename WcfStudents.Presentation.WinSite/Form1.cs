using System;
using System.Globalization;
using System.Windows.Forms;

namespace WcfStudents.Presentation.WinSite
{
    public partial class boxNumber : Form
    {
        private int idUpdate;
        public boxNumber()
        {
            InitializeComponent();
            btnCancelUpdate.Enabled = false;
            btnUpdate.Enabled = false;

            LoadStudents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StudentServiceReferent.StudentServiceClient client = new StudentServiceReferent.StudentServiceClient())
            {
                DataGridView aux = studentTable;

                StudentServiceReferent.Student student = new StudentServiceReferent.Student();

                student.Name = nameStudentBox.Text;
                student.Surname = surnameStudentBox.Text;
                student.Birthday = birthdayTimePicker.Value;

                try
                {
                    client.Add(student);
                    LoadStudents();
                    ResetBoxText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido algún problema");
                }
            }
        }

        private void ShowInfo(int id)
        {
            using (StudentServiceReferent.StudentServiceClient client = new StudentServiceReferent.StudentServiceClient())
            {
                var student = client.GetById(id);

                string message = "Seleccionaste el estudiante " + student.Name + " " + student.Surname + "\n";
                message += "Años: " + student.Age + "\n";
                message += "Cumpleaños: " + student.Birthday.ToString("dd-MM-yyyy", CultureInfo.CreateSpecificCulture("es"));

                MessageBox.Show(message);
            }
        }

        private void DropStudent(int id, int index)
        {
            using (StudentServiceReferent.StudentServiceClient client = new StudentServiceReferent.StudentServiceClient())
            {
                client.DeleteById(id);
                LoadStudents();
            }
        }
        private void UpdateStudent(int id)
        {
            using (StudentServiceReferent.StudentServiceClient client = new StudentServiceReferent.StudentServiceClient())
            {
                var student = client.GetById(id);

                idUpdate = student.StudentID;

                nameStudentBox.Text = student.Name;
                surnameStudentBox.Text = student.Surname;
                birthdayTimePicker.Value = student.Birthday;

                btnSave.Enabled = false;
                btnCancelUpdate.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void ResetBoxText()
        {
            nameStudentBox.Text = "";
            surnameStudentBox.Text = "";
            birthdayTimePicker.Value = DateTime.Now;
        }

        private void LoadStudents()
        {
            studentTable.Rows.Clear();

            using (StudentServiceReferent.StudentServiceClient client = new StudentServiceReferent.StudentServiceClient())
            {
                foreach (var student in client.GetAll())
                {
                    studentTable.Rows.Add(student.StudentID, student.Name + " " + student.Surname);
                }
            }
        }

        private void studentTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            try
            {
                if (row != -1)
                {
                    int id = (int)studentTable.Rows[row].Cells[0].Value;

                    switch (column)
                    {
                        default:
                            ShowInfo(id);
                            break;
                        case 2:
                            DropStudent(id, row);
                            break;
                        case 3:
                            UpdateStudent(id);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡CUIDADO! No se ha encontrado el estudiante seleccionado.");
                //throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (StudentServiceReferent.StudentServiceClient client = new StudentServiceReferent.StudentServiceClient())
            {
                StudentServiceReferent.Student student = new StudentServiceReferent.Student();

                student.StudentID = idUpdate;
                student.Name = nameStudentBox.Text;
                student.Surname = surnameStudentBox.Text;
                student.Birthday = birthdayTimePicker.Value;

                client.Update(student);
                btnSave.Enabled = true;
                btnCancelUpdate.Enabled = true;
                btnUpdate.Enabled = false;
                ResetBoxText();
                LoadStudents();
            }
                
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            ResetBoxText();

            btnSave.Enabled = true;
            btnCancelUpdate.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
