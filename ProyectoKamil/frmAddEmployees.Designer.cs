namespace ProyectoKamil
{
    partial class frmAddEmployees
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
            textBoxName = new TextBox();
            textBoxFatherLastname = new TextBox();
            textBoxMotherLastname = new TextBox();
            btnGuardar = new Button();
            dateTimePicker = new DateTimePicker();
            NumeroCentroTrabajo = new NumericUpDown();
            label_WorkCenter = new Label();
            numericUpDown_jobPosition = new NumericUpDown();
            label1 = new Label();
            checkBoxIsDirective = new RadioButton();
            isNotDirective = new RadioButton();
            textBox_isDirective = new Label();
            label_FatherLastname = new Label();
            label_MotherLastname = new Label();
            label_Name = new Label();
            label_Birthdate = new Label();
            ((System.ComponentModel.ISupportInitialize)NumeroCentroTrabajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_jobPosition).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(433, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 39);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.UseWaitCursor = true;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxFatherLastname
            // 
            textBoxFatherLastname.Location = new Point(433, 142);
            textBoxFatherLastname.Name = "textBoxFatherLastname";
            textBoxFatherLastname.Size = new Size(200, 39);
            textBoxFatherLastname.TabIndex = 2;
            textBoxFatherLastname.TextAlign = HorizontalAlignment.Center;
            textBoxFatherLastname.UseWaitCursor = true;
            textBoxFatherLastname.TextChanged += textBoxFatherLastName_TextChanged;
            // 
            // textBoxMotherLastname
            // 
            textBoxMotherLastname.Location = new Point(433, 196);
            textBoxMotherLastname.Name = "textBoxMotherLastname";
            textBoxMotherLastname.Size = new Size(200, 39);
            textBoxMotherLastname.TabIndex = 3;
            textBoxMotherLastname.TextAlign = HorizontalAlignment.Center;
            textBoxMotherLastname.TextChanged += textBoxMotherLastname_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(515, 567);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += buttonSaveAddWorker_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(433, 256);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(482, 39);
            dateTimePicker.TabIndex = 6;
            dateTimePicker.Value = new DateTime(2025, 3, 27, 11, 39, 49, 0);
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // NumeroCentroTrabajo
            // 
            NumeroCentroTrabajo.Location = new Point(433, 314);
            NumeroCentroTrabajo.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            NumeroCentroTrabajo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumeroCentroTrabajo.Name = "NumeroCentroTrabajo";
            NumeroCentroTrabajo.Size = new Size(77, 39);
            NumeroCentroTrabajo.TabIndex = 8;
            NumeroCentroTrabajo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumeroCentroTrabajo.ValueChanged += NumeroCentroTrabajo_ValueChanged;
            // 
            // label_WorkCenter
            // 
            label_WorkCenter.AutoSize = true;
            label_WorkCenter.Location = new Point(141, 316);
            label_WorkCenter.Name = "label_WorkCenter";
            label_WorkCenter.Size = new Size(204, 32);
            label_WorkCenter.TabIndex = 9;
            label_WorkCenter.Text = "Centro de Trabajo";
            // 
            // numericUpDown_jobPosition
            // 
            numericUpDown_jobPosition.Location = new Point(433, 374);
            numericUpDown_jobPosition.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_jobPosition.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_jobPosition.Name = "numericUpDown_jobPosition";
            numericUpDown_jobPosition.Size = new Size(77, 39);
            numericUpDown_jobPosition.TabIndex = 10;
            numericUpDown_jobPosition.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_jobPosition.ValueChanged += numericUpDown_jobPosition_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 376);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 11;
            label1.Text = "Puesto de Trabajo";
            label1.Click += label1_Click;
            // 
            // isDirective
            // 
            checkBoxIsDirective.AutoSize = true;
            checkBoxIsDirective.Location = new Point(433, 431);
            checkBoxIsDirective.Name = "checkBoxIsDirective";
            checkBoxIsDirective.Size = new Size(64, 36);
            checkBoxIsDirective.TabIndex = 12;
            checkBoxIsDirective.TabStop = true;
            checkBoxIsDirective.Text = "Si";
            checkBoxIsDirective.UseVisualStyleBackColor = true;
            checkBoxIsDirective.CheckedChanged += checkBoxIsDirective_CheckedChanged;
            // 
            // isNotDirective
            // 
            isNotDirective.AutoSize = true;
            isNotDirective.Location = new Point(433, 473);
            isNotDirective.Name = "isNotDirective";
            isNotDirective.Size = new Size(77, 36);
            isNotDirective.TabIndex = 13;
            isNotDirective.TabStop = true;
            isNotDirective.Text = "No";
            isNotDirective.UseVisualStyleBackColor = true;
            isNotDirective.CheckedChanged += isNotDirective_CheckedChanged;
            // 
            // textBox_isDirective
            // 
            textBox_isDirective.AutoSize = true;
            textBox_isDirective.Location = new Point(141, 435);
            textBox_isDirective.Name = "textBox_isDirective";
            textBox_isDirective.Size = new Size(149, 32);
            textBox_isDirective.TabIndex = 14;
            textBox_isDirective.Text = "Es Directivo?";
            // 
            // label_FatherLastname
            // 
            label_FatherLastname.AutoSize = true;
            label_FatherLastname.Location = new Point(141, 145);
            label_FatherLastname.Name = "label_FatherLastname";
            label_FatherLastname.RightToLeft = RightToLeft.Yes;
            label_FatherLastname.Size = new Size(190, 32);
            label_FatherLastname.TabIndex = 15;
            label_FatherLastname.Text = "Apellido Paterno";
            // 
            // label_MotherLastname
            // 
            label_MotherLastname.AutoSize = true;
            label_MotherLastname.Location = new Point(141, 199);
            label_MotherLastname.Name = "label_MotherLastname";
            label_MotherLastname.RightToLeft = RightToLeft.Yes;
            label_MotherLastname.Size = new Size(200, 32);
            label_MotherLastname.TabIndex = 16;
            label_MotherLastname.Text = "Apellido Materno";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(141, 87);
            label_Name.Name = "label_Name";
            label_Name.RightToLeft = RightToLeft.Yes;
            label_Name.Size = new Size(102, 32);
            label_Name.TabIndex = 17;
            label_Name.Text = "Nombre";
            // 
            // label_Birthdate
            // 
            label_Birthdate.AutoSize = true;
            label_Birthdate.Location = new Point(141, 261);
            label_Birthdate.Name = "label_Birthdate";
            label_Birthdate.RightToLeft = RightToLeft.Yes;
            label_Birthdate.Size = new Size(240, 32);
            label_Birthdate.TabIndex = 18;
            label_Birthdate.Text = "Fecha de Nacimiento";
            // 
            // frmAddWorker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(label_Birthdate);
            Controls.Add(label_Name);
            Controls.Add(label_MotherLastname);
            Controls.Add(label_FatherLastname);
            Controls.Add(textBox_isDirective);
            Controls.Add(isNotDirective);
            Controls.Add(checkBoxIsDirective);
            Controls.Add(label1);
            Controls.Add(numericUpDown_jobPosition);
            Controls.Add(label_WorkCenter);
            Controls.Add(NumeroCentroTrabajo);
            Controls.Add(dateTimePicker);
            Controls.Add(btnGuardar);
            Controls.Add(textBoxMotherLastname);
            Controls.Add(textBoxFatherLastname);
            Controls.Add(textBoxName);
            Name = "frmAddWorker";
            Text = "Agregar Empleado - Proyecto Kamil";
            Load += frmAddWorker_Load;
            ((System.ComponentModel.ISupportInitialize)NumeroCentroTrabajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_jobPosition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private TextBox textBoxFatherLastname;
        private TextBox textBoxMotherLastname;
        private Button btnGuardar;
        private DateTimePicker dateTimePicker;
        private NumericUpDown NumeroCentroTrabajo;
        private Label label_WorkCenter;
        private NumericUpDown numericUpDown_jobPosition;
        private Label label1;
        private RadioButton checkBoxIsDirective;
        private RadioButton isNotDirective;
        private Label textBox_isDirective;
        private Label label_FatherLastname;
        private Label label_MotherLastname;
        private Label label_Name;
        private Label label_Birthdate;
    }
}