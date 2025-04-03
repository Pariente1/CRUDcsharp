namespace ProyectoKamil
{
    partial class frmUpdateWorkCenter
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
            textBox_NewCenterName = new TextBox();
            textBox_CenterName = new TextBox();
            Nombre = new Label();
            label_NewCenterName = new Label();
            label_NewCityName = new Label();
            textBox_NewCityName = new TextBox();
            button_SaveUpdate = new Button();
            SuspendLayout();
            // 
            // textBox_NewCenterName
            // 
            textBox_NewCenterName.Location = new Point(334, 90);
            textBox_NewCenterName.Name = "textBox_NewCenterName";
            textBox_NewCenterName.Size = new Size(100, 23);
            textBox_NewCenterName.TabIndex = 0;
            textBox_NewCenterName.TextChanged += textBox_NewCenterName_TextChanged;
            // 
            // textBox_CenterName
            // 
            textBox_CenterName.Location = new Point(191, 90);
            textBox_CenterName.Name = "textBox_CenterName";
            textBox_CenterName.Size = new Size(100, 23);
            textBox_CenterName.TabIndex = 1;
            textBox_CenterName.TextChanged += textBox_CenterName_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(69, 93);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(109, 15);
            Nombre.TabIndex = 4;
            Nombre.Text = "Nombre del Centro";
            Nombre.Click += Nombre_Click;
            // 
            // label_NewCenterName
            // 
            label_NewCenterName.AutoSize = true;
            label_NewCenterName.Location = new Point(440, 93);
            label_NewCenterName.Name = "label_NewCenterName";
            label_NewCenterName.Size = new Size(147, 15);
            label_NewCenterName.TabIndex = 5;
            label_NewCenterName.Text = "Nuevo Nombre del Centro";
            // 
            // label_NewCityName
            // 
            label_NewCityName.AutoSize = true;
            label_NewCityName.Location = new Point(440, 122);
            label_NewCityName.Name = "label_NewCityName";
            label_NewCityName.Size = new Size(156, 15);
            label_NewCityName.TabIndex = 9;
            label_NewCityName.Text = "Nuevo Nombre de la ciudad";
            // 
            // textBox_NewCityName
            // 
            textBox_NewCityName.Location = new Point(334, 119);
            textBox_NewCityName.Name = "textBox_NewCityName";
            textBox_NewCityName.Size = new Size(100, 23);
            textBox_NewCityName.TabIndex = 6;
            textBox_NewCityName.TextChanged += textBox_NewCityName_TextChanged;
            // 
            // button_SaveUpdate
            // 
            button_SaveUpdate.Location = new Point(284, 239);
            button_SaveUpdate.Name = "button_SaveUpdate";
            button_SaveUpdate.Size = new Size(75, 23);
            button_SaveUpdate.TabIndex = 10;
            button_SaveUpdate.Text = "Guardar";
            button_SaveUpdate.UseVisualStyleBackColor = true;
            button_SaveUpdate.Click += button_SaveUpdate_Click;
            // 
            // frmUpdateWorkCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(button_SaveUpdate);
            Controls.Add(label_NewCityName);
            Controls.Add(textBox_NewCityName);
            Controls.Add(label_NewCenterName);
            Controls.Add(Nombre);
            Controls.Add(textBox_CenterName);
            Controls.Add(textBox_NewCenterName);
            Name = "frmUpdateWorkCenter";
            Text = "frmUpdateWorkCenter";
            Load += frmUpdateWorkCenter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_NewCenterName;
        private TextBox textBox_CenterName;
        private Label Nombre;
        private Label label_NewCenterName;
        private Label label_NewCityName;
        private TextBox textBox_NewCityName;
        private Button button_SaveUpdate;
    }
}