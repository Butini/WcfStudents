
namespace WcfStudents.Presentation.WinSite
{
    partial class boxNumber
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.birthdayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surnameStudentBox = new System.Windows.Forms.TextBox();
            this.nameStudentBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(21, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Actualizar estudiante";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(203, 237);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnCancelUpdate.TabIndex = 21;
            this.btnCancelUpdate.Text = "Cancelar";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // birthdayTimePicker
            // 
            this.birthdayTimePicker.Location = new System.Drawing.Point(143, 144);
            this.birthdayTimePicker.Name = "birthdayTimePicker";
            this.birthdayTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayTimePicker.TabIndex = 20;
            // 
            // studentTable
            // 
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.btnDelete,
            this.btnEdit});
            this.studentTable.Location = new System.Drawing.Point(358, 15);
            this.studentTable.Name = "studentTable";
            this.studentTable.Size = new System.Drawing.Size(449, 311);
            this.studentTable.TabIndex = 19;
            this.studentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellContentClick_1);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "ID";
            this.StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Nombre";
            this.StudentName.Name = "StudentName";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Eliminar";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.ToolTipText = "Eliminar";
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Editar";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Editar";
            this.btnEdit.ToolTipText = "Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // surnameStudentBox
            // 
            this.surnameStudentBox.Location = new System.Drawing.Point(143, 110);
            this.surnameStudentBox.Name = "surnameStudentBox";
            this.surnameStudentBox.Size = new System.Drawing.Size(200, 20);
            this.surnameStudentBox.TabIndex = 15;
            // 
            // nameStudentBox
            // 
            this.nameStudentBox.Location = new System.Drawing.Point(143, 75);
            this.nameStudentBox.Name = "nameStudentBox";
            this.nameStudentBox.Size = new System.Drawing.Size(200, 20);
            this.nameStudentBox.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Agregar estudiante";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // boxNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 341);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.birthdayTimePicker);
            this.Controls.Add(this.studentTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surnameStudentBox);
            this.Controls.Add(this.nameStudentBox);
            this.Controls.Add(this.btnSave);
            this.Name = "boxNumber";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.DateTimePicker birthdayTimePicker;
        private System.Windows.Forms.DataGridView studentTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameStudentBox;
        private System.Windows.Forms.TextBox nameStudentBox;
        private System.Windows.Forms.Button btnSave;
    }
}

