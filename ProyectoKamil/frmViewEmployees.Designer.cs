namespace ProyectoKamil
{
    partial class frmViewEmployees
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxName = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 173);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label_Name_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 223);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 1;
            label2.Text = "RFC";
            label2.Click += label_RFC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 268);
            label3.Name = "label3";
            label3.Size = new Size(204, 32);
            label3.TabIndex = 2;
            label3.Text = "Centro de Trabajo";
            label3.Click += label_workCenter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 312);
            label4.Name = "label4";
            label4.Size = new Size(240, 32);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento";
            label4.Click += label_birthDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(438, 312);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker_birthDay_ValueChanged;
            // 
            // textBox1
            // 
            textBoxName.Location = new Point(438, 170);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 39);
            textBoxName.TabIndex = 5;
            textBoxName.TextChanged += textBox_selectName_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(438, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox_selectRFC_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(438, 265);
            numericUpDown1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 39);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown_selectWorkCenter_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(498, 494);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Buscar_Click;
            // 
            // frmViewEmployees
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBoxName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmViewEmployees";
            Text = "Ver empleados";
            Load += frmViewEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxName;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}