namespace ProyectoKamil
{
    partial class frmViewWorkCenter
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
            button_Consultar = new Button();
            textBox_CityName = new TextBox();
            label_NombreCiudad = new Label();
            SuspendLayout();
            // 
            // button_Consultar
            // 
            button_Consultar.Location = new Point(282, 206);
            button_Consultar.Margin = new Padding(2, 1, 2, 1);
            button_Consultar.Name = "button_Consultar";
            button_Consultar.Size = new Size(81, 22);
            button_Consultar.TabIndex = 10;
            button_Consultar.Text = "Consultar";
            button_Consultar.UseVisualStyleBackColor = true;
            button_Consultar.Click += button_Consultar_Click;
            // 
            // textBox_CityName
            // 
            textBox_CityName.Location = new Point(364, 116);
            textBox_CityName.Margin = new Padding(2, 1, 2, 1);
            textBox_CityName.Name = "textBox_CityName";
            textBox_CityName.Size = new Size(110, 23);
            textBox_CityName.TabIndex = 12;
            textBox_CityName.TextChanged += textBox_CityName_TextChanged;
            // 
            // label_NombreCiudad
            // 
            label_NombreCiudad.AutoSize = true;
            label_NombreCiudad.Location = new Point(195, 117);
            label_NombreCiudad.Margin = new Padding(2, 0, 2, 0);
            label_NombreCiudad.Name = "label_NombreCiudad";
            label_NombreCiudad.Size = new Size(120, 15);
            label_NombreCiudad.TabIndex = 11;
            label_NombreCiudad.Text = "Nombre de la Ciudad";
            // 
            // frmViewWorkCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(textBox_CityName);
            Controls.Add(label_NombreCiudad);
            Controls.Add(button_Consultar);
            Name = "frmViewWorkCenter";
            Text = "frmViewWorkCenter";
            Load += frmViewWorkCenter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Consultar;
        private TextBox textBox_CityName;
        private Label label_NombreCiudad;
    }
}