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
            label_WorkCenter = new Label();
            dateTimePicker = new DateTimePicker();
            textBoxMotherLastname = new TextBox();
            textBoxFatherLastname = new TextBox();
            textBoxName = new TextBox();
            btnGuardar = new Button();
            comboBoxWorkCenter = new ComboBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // label_Birthdate
            // 
            label_Birthdate.AutoSize = true;
            label_Birthdate.Location = new Point(134, 145);
            label_Birthdate.Margin = new Padding(2, 0, 2, 0);
            label_Birthdate.Name = "label_Birthdate";
            label_Birthdate.RightToLeft = RightToLeft.Yes;
            label_Birthdate.Size = new Size(119, 15);
            label_Birthdate.TabIndex = 30;
            label_Birthdate.Text = "Fecha de Nacimiento";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(134, 63);
            label_Name.Margin = new Padding(2, 0, 2, 0);
            label_Name.Name = "label_Name";
            label_Name.RightToLeft = RightToLeft.Yes;
            label_Name.Size = new Size(51, 15);
            label_Name.TabIndex = 29;
            label_Name.Text = "Nombre";
            // 
            // label_MotherLastname
            // 
            label_MotherLastname.AutoSize = true;
            label_MotherLastname.Location = new Point(134, 116);
            label_MotherLastname.Margin = new Padding(2, 0, 2, 0);
            label_MotherLastname.Name = "label_MotherLastname";
            label_MotherLastname.RightToLeft = RightToLeft.Yes;
            label_MotherLastname.Size = new Size(99, 15);
            label_MotherLastname.TabIndex = 28;
            label_MotherLastname.Text = "Apellido Materno";
            // 
            // label_FatherLastname
            // 
            label_FatherLastname.AutoSize = true;
            label_FatherLastname.Location = new Point(134, 90);
            label_FatherLastname.Margin = new Padding(2, 0, 2, 0);
            label_FatherLastname.Name = "label_FatherLastname";
            label_FatherLastname.RightToLeft = RightToLeft.Yes;
            label_FatherLastname.Size = new Size(95, 15);
            label_FatherLastname.TabIndex = 27;
            label_FatherLastname.Text = "Apellido Paterno";
            // 
            // label_WorkCenter
            // 
            label_WorkCenter.AutoSize = true;
            label_WorkCenter.Location = new Point(134, 171);
            label_WorkCenter.Margin = new Padding(2, 0, 2, 0);
            label_WorkCenter.Name = "label_WorkCenter";
            label_WorkCenter.Size = new Size(101, 15);
            label_WorkCenter.TabIndex = 24;
            label_WorkCenter.Text = "Centro de Trabajo";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(291, 139);
            dateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(261, 23);
            dateTimePicker.TabIndex = 22;
            dateTimePicker.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxMotherLastname
            // 
            textBoxMotherLastname.Location = new Point(291, 113);
            textBoxMotherLastname.Margin = new Padding(2, 1, 2, 1);
            textBoxMotherLastname.Name = "textBoxMotherLastname";
            textBoxMotherLastname.Size = new Size(110, 23);
            textBoxMotherLastname.TabIndex = 21;
            textBoxMotherLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxFatherLastname
            // 
            textBoxFatherLastname.Location = new Point(291, 87);
            textBoxFatherLastname.Margin = new Padding(2, 1, 2, 1);
            textBoxFatherLastname.Name = "textBoxFatherLastname";
            textBoxFatherLastname.Size = new Size(110, 23);
            textBoxFatherLastname.TabIndex = 20;
            textBoxFatherLastname.TextAlign = HorizontalAlignment.Center;
            textBoxFatherLastname.UseWaitCursor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(291, 60);
            textBoxName.Margin = new Padding(2, 1, 2, 1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 19;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.UseWaitCursor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(251, 257);
            btnGuardar.Margin = new Padding(2, 1, 2, 1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 22);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboBoxWorkCenter
            // 
            comboBoxWorkCenter.FormattingEnabled = true;
            comboBoxWorkCenter.Items.AddRange(new object[] { "Centro Culiacan", "Centro Guasave", "Centro Navolato" });
            comboBoxWorkCenter.Location = new Point(291, 168);
            comboBoxWorkCenter.Margin = new Padding(2, 1, 2, 1);
            comboBoxWorkCenter.Name = "comboBoxWorkCenter";
            comboBoxWorkCenter.Size = new Size(132, 23);
            comboBoxWorkCenter.TabIndex = 32;
            comboBoxWorkCenter.SelectedIndexChanged += comboBoxWorkCenter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 195);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 33;
            label1.Text = "Prestación de combustible";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(291, 193);
            radioButton1.Name = "FuelAllowance";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 34;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sí";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += FuelAllowance_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(291, 218);
            radioButton2.Name = "notFuelAllowance";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 35;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmAddDirectors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 342);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(comboBoxWorkCenter);
            Controls.Add(btnGuardar);
            Controls.Add(label_Birthdate);
            Controls.Add(label_Name);
            Controls.Add(label_MotherLastname);
            Controls.Add(label_FatherLastname);
            Controls.Add(label_WorkCenter);
            Controls.Add(dateTimePicker);
            Controls.Add(textBoxMotherLastname);
            Controls.Add(textBoxFatherLastname);
            Controls.Add(textBoxName);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmAddDirectors";
            Text = "Agregar Directores";
            Load += frmAddDirectors_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Birthdate;
        private Label label_Name;
        private Label label_MotherLastname;
        private Label label_FatherLastname;
        private Label label_WorkCenter;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxMotherLastname;
        private TextBox textBoxFatherLastname;
        private TextBox textBoxName;
        private Button btnGuardar;
        private ComboBox comboBoxWorkCenter;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}