namespace ProyectoKamil
{
    partial class frmAddDirectors
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
            label_Birthdate = new Label();
            label_Name = new Label();
            label_MotherLastname = new Label();
            label_FatherLastname = new Label();
            label2 = new Label();
            numericUpDown_jobPosition = new NumericUpDown();
            label_WorkCenter = new Label();
            NumeroCentroTrabajo = new NumericUpDown();
            dateTimePicker = new DateTimePicker();
            textBoxMotherLastname = new TextBox();
            textBoxFatherLastname = new TextBox();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_jobPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumeroCentroTrabajo).BeginInit();
            SuspendLayout();
            // 
            // label_Birthdate
            // 
            label_Birthdate.AutoSize = true;
            label_Birthdate.Location = new Point(248, 309);
            label_Birthdate.Name = "label_Birthdate";
            label_Birthdate.RightToLeft = RightToLeft.Yes;
            label_Birthdate.Size = new Size(240, 32);
            label_Birthdate.TabIndex = 30;
            label_Birthdate.Text = "Fecha de Nacimiento";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(248, 135);
            label_Name.Name = "label_Name";
            label_Name.RightToLeft = RightToLeft.Yes;
            label_Name.Size = new Size(102, 32);
            label_Name.TabIndex = 29;
            label_Name.Text = "Nombre";
            // 
            // label_MotherLastname
            // 
            label_MotherLastname.AutoSize = true;
            label_MotherLastname.Location = new Point(248, 247);
            label_MotherLastname.Name = "label_MotherLastname";
            label_MotherLastname.RightToLeft = RightToLeft.Yes;
            label_MotherLastname.Size = new Size(200, 32);
            label_MotherLastname.TabIndex = 28;
            label_MotherLastname.Text = "Apellido Materno";
            // 
            // label_FatherLastname
            // 
            label_FatherLastname.AutoSize = true;
            label_FatherLastname.Location = new Point(248, 193);
            label_FatherLastname.Name = "label_FatherLastname";
            label_FatherLastname.RightToLeft = RightToLeft.Yes;
            label_FatherLastname.Size = new Size(190, 32);
            label_FatherLastname.TabIndex = 27;
            label_FatherLastname.Text = "Apellido Paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 424);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 26;
            label2.Text = "Puesto de Trabajo";
            // 
            // numericUpDown_jobPosition
            // 
            numericUpDown_jobPosition.Location = new Point(540, 422);
            numericUpDown_jobPosition.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_jobPosition.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_jobPosition.Name = "numericUpDown_jobPosition";
            numericUpDown_jobPosition.Size = new Size(77, 39);
            numericUpDown_jobPosition.TabIndex = 25;
            numericUpDown_jobPosition.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_WorkCenter
            // 
            label_WorkCenter.AutoSize = true;
            label_WorkCenter.Location = new Point(248, 364);
            label_WorkCenter.Name = "label_WorkCenter";
            label_WorkCenter.Size = new Size(204, 32);
            label_WorkCenter.TabIndex = 24;
            label_WorkCenter.Text = "Centro de Trabajo";
            // 
            // NumeroCentroTrabajo
            // 
            NumeroCentroTrabajo.Location = new Point(540, 362);
            NumeroCentroTrabajo.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            NumeroCentroTrabajo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumeroCentroTrabajo.Name = "NumeroCentroTrabajo";
            NumeroCentroTrabajo.Size = new Size(77, 39);
            NumeroCentroTrabajo.TabIndex = 23;
            NumeroCentroTrabajo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(540, 304);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(482, 39);
            dateTimePicker.TabIndex = 22;
            dateTimePicker.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxMotherLastname
            // 
            textBoxMotherLastname.Location = new Point(540, 244);
            textBoxMotherLastname.Name = "textBoxMotherLastname";
            textBoxMotherLastname.Size = new Size(200, 39);
            textBoxMotherLastname.TabIndex = 21;
            textBoxMotherLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxFatherLastname
            // 
            textBoxFatherLastname.Location = new Point(540, 190);
            textBoxFatherLastname.Name = "textBoxFatherLastname";
            textBoxFatherLastname.Size = new Size(200, 39);
            textBoxFatherLastname.TabIndex = 20;
            textBoxFatherLastname.TextAlign = HorizontalAlignment.Center;
            textBoxFatherLastname.UseWaitCursor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(540, 132);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 39);
            textBoxName.TabIndex = 19;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.UseWaitCursor = true;
            // 
            // frmAddDirectors
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(label_Birthdate);
            Controls.Add(label_Name);
            Controls.Add(label_MotherLastname);
            Controls.Add(label_FatherLastname);
            Controls.Add(label2);
            Controls.Add(numericUpDown_jobPosition);
            Controls.Add(label_WorkCenter);
            Controls.Add(NumeroCentroTrabajo);
            Controls.Add(dateTimePicker);
            Controls.Add(textBoxMotherLastname);
            Controls.Add(textBoxFatherLastname);
            Controls.Add(textBoxName);
            Name = "frmAddDirectors";
            Text = "Agregar Directores";
            Load += frmAddDirectors_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_jobPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumeroCentroTrabajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Birthdate;
        private Label label_Name;
        private Label label_MotherLastname;
        private Label label_FatherLastname;
        private Label label2;
        private NumericUpDown numericUpDown_jobPosition;
        private Label label_WorkCenter;
        private NumericUpDown NumeroCentroTrabajo;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxMotherLastname;
        private TextBox textBoxFatherLastname;
        private TextBox textBoxName;
    }
}