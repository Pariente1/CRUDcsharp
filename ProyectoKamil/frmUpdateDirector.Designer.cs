namespace ProyectoKamil
{
    partial class frmUpdateDirector
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
            comboBoxJobPosition = new ComboBox();
            comboBoxWorkCenter = new ComboBox();
            label_Birthdate = new Label();
            label_Name = new Label();
            label_MotherLastname = new Label();
            label_FatherLastname = new Label();
            label1 = new Label();
            label_WorkCenter = new Label();
            dateTimePicker = new DateTimePicker();
            textBoxMotherLastname = new TextBox();
            textBoxFatherLastname = new TextBox();
            textBoxName = new TextBox();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // comboBoxJobPosition
            // 
            comboBoxJobPosition.FormattingEnabled = true;
            comboBoxJobPosition.Items.AddRange(new object[] { "Vendedor ", "Cajero" });
            comboBoxJobPosition.Location = new Point(318, 192);
            comboBoxJobPosition.Margin = new Padding(2, 1, 2, 1);
            comboBoxJobPosition.Name = "comboBoxJobPosition";
            comboBoxJobPosition.Size = new Size(132, 23);
            comboBoxJobPosition.TabIndex = 64;
            comboBoxJobPosition.SelectedIndexChanged += comboBoxJobPosition_SelectedIndexChanged;
            // 
            // comboBoxWorkCenter
            // 
            comboBoxWorkCenter.FormattingEnabled = true;
            comboBoxWorkCenter.Items.AddRange(new object[] { "Centro Culiacan", "Centro Guasave", "Centro Navolato" });
            comboBoxWorkCenter.Location = new Point(318, 164);
            comboBoxWorkCenter.Margin = new Padding(2, 1, 2, 1);
            comboBoxWorkCenter.Name = "comboBoxWorkCenter";
            comboBoxWorkCenter.Size = new Size(132, 23);
            comboBoxWorkCenter.TabIndex = 63;
            comboBoxWorkCenter.SelectedIndexChanged += comboBoxWorkCenter_SelectedIndexChanged;
            // 
            // label_Birthdate
            // 
            label_Birthdate.AutoSize = true;
            label_Birthdate.Location = new Point(161, 139);
            label_Birthdate.Margin = new Padding(2, 0, 2, 0);
            label_Birthdate.Name = "label_Birthdate";
            label_Birthdate.RightToLeft = RightToLeft.Yes;
            label_Birthdate.Size = new Size(119, 15);
            label_Birthdate.TabIndex = 62;
            label_Birthdate.Text = "Fecha de Nacimiento";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(161, 58);
            label_Name.Margin = new Padding(2, 0, 2, 0);
            label_Name.Name = "label_Name";
            label_Name.RightToLeft = RightToLeft.Yes;
            label_Name.Size = new Size(51, 15);
            label_Name.TabIndex = 61;
            label_Name.Text = "Nombre";
            // 
            // label_MotherLastname
            // 
            label_MotherLastname.AutoSize = true;
            label_MotherLastname.Location = new Point(161, 110);
            label_MotherLastname.Margin = new Padding(2, 0, 2, 0);
            label_MotherLastname.Name = "label_MotherLastname";
            label_MotherLastname.RightToLeft = RightToLeft.Yes;
            label_MotherLastname.Size = new Size(99, 15);
            label_MotherLastname.TabIndex = 60;
            label_MotherLastname.Text = "Apellido Materno";
            // 
            // label_FatherLastname
            // 
            label_FatherLastname.AutoSize = true;
            label_FatherLastname.Location = new Point(161, 85);
            label_FatherLastname.Margin = new Padding(2, 0, 2, 0);
            label_FatherLastname.Name = "label_FatherLastname";
            label_FatherLastname.RightToLeft = RightToLeft.Yes;
            label_FatherLastname.Size = new Size(95, 15);
            label_FatherLastname.TabIndex = 59;
            label_FatherLastname.Text = "Apellido Paterno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 193);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 58;
            label1.Text = "Puesto de Trabajo";
            // 
            // label_WorkCenter
            // 
            label_WorkCenter.AutoSize = true;
            label_WorkCenter.Location = new Point(161, 165);
            label_WorkCenter.Margin = new Padding(2, 0, 2, 0);
            label_WorkCenter.Name = "label_WorkCenter";
            label_WorkCenter.Size = new Size(101, 15);
            label_WorkCenter.TabIndex = 57;
            label_WorkCenter.Text = "Centro de Trabajo";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(318, 137);
            dateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(261, 23);
            dateTimePicker.TabIndex = 56;
            dateTimePicker.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxMotherLastname
            // 
            textBoxMotherLastname.Location = new Point(318, 109);
            textBoxMotherLastname.Margin = new Padding(2, 1, 2, 1);
            textBoxMotherLastname.Name = "textBoxMotherLastname";
            textBoxMotherLastname.Size = new Size(110, 23);
            textBoxMotherLastname.TabIndex = 55;
            textBoxMotherLastname.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxFatherLastname
            // 
            textBoxFatherLastname.Location = new Point(318, 84);
            textBoxFatherLastname.Margin = new Padding(2, 1, 2, 1);
            textBoxFatherLastname.Name = "textBoxFatherLastname";
            textBoxFatherLastname.Size = new Size(110, 23);
            textBoxFatherLastname.TabIndex = 54;
            textBoxFatherLastname.TextAlign = HorizontalAlignment.Center;
            textBoxFatherLastname.UseWaitCursor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(318, 56);
            textBoxName.Margin = new Padding(2, 1, 2, 1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 53;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.UseWaitCursor = true;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(231, 271);
            btnConsultar.Margin = new Padding(2, 1, 2, 1);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(182, 22);
            btnConsultar.TabIndex = 52;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // frmUpdateDirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(comboBoxJobPosition);
            Controls.Add(comboBoxWorkCenter);
            Controls.Add(label_Birthdate);
            Controls.Add(label_Name);
            Controls.Add(label_MotherLastname);
            Controls.Add(label_FatherLastname);
            Controls.Add(label1);
            Controls.Add(label_WorkCenter);
            Controls.Add(dateTimePicker);
            Controls.Add(textBoxMotherLastname);
            Controls.Add(textBoxFatherLastname);
            Controls.Add(textBoxName);
            Controls.Add(btnConsultar);
            Name = "frmUpdateDirector";
            Text = "Formulario para consultar director";
            Load += frmUpdateDirector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxJobPosition;
        private ComboBox comboBoxWorkCenter;
        private Label label_Birthdate;
        private Label label_Name;
        private Label label_MotherLastname;
        private Label label_FatherLastname;
        private Label label1;
        private Label label_WorkCenter;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxMotherLastname;
        private TextBox textBoxFatherLastname;
        private TextBox textBoxName;
        private Button btnConsultar;
    }
}