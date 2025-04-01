namespace ProyectoKamil
{
    partial class frmAddWorkCenter
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
            label_Name = new Label();
            label_FatherLastname = new Label();
            textBoxCity = new TextBox();
            textBoxName = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(174, 79);
            label_Name.Margin = new Padding(2, 0, 2, 0);
            label_Name.Name = "label_Name";
            label_Name.RightToLeft = RightToLeft.Yes;
            label_Name.Size = new Size(109, 15);
            label_Name.TabIndex = 33;
            label_Name.Text = "Nombre del Centro";
            label_Name.Click += label_Name_Click;
            // 
            // label_FatherLastname
            // 
            label_FatherLastname.AutoSize = true;
            label_FatherLastname.Location = new Point(174, 106);
            label_FatherLastname.Margin = new Padding(2, 0, 2, 0);
            label_FatherLastname.Name = "label_FatherLastname";
            label_FatherLastname.RightToLeft = RightToLeft.Yes;
            label_FatherLastname.Size = new Size(144, 15);
            label_FatherLastname.TabIndex = 32;
            label_FatherLastname.Text = "Ciudad a la que pertenece";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(331, 103);
            textBoxCity.Margin = new Padding(2, 1, 2, 1);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(110, 23);
            textBoxCity.TabIndex = 31;
            textBoxCity.TextAlign = HorizontalAlignment.Center;
            textBoxCity.UseWaitCursor = true;
            textBoxCity.TextChanged += textBoxCity_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(331, 76);
            textBoxName.Margin = new Padding(2, 1, 2, 1);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 30;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.UseWaitCursor = true;
            textBoxName.TextChanged += textBoxNameCenter_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(266, 165);
            btnGuardar.Margin = new Padding(2, 1, 2, 1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(81, 22);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmAddWorkCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 342);
            Controls.Add(btnGuardar);
            Controls.Add(label_Name);
            Controls.Add(label_FatherLastname);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxName);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmAddWorkCenter";
            Text = "Agregar centro de trabajo";
            Load += frmAddWorkCenter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private Label label_FatherLastname;
        private TextBox textBoxCity;
        private TextBox textBoxName;
        private Button btnGuardar;
    }
}