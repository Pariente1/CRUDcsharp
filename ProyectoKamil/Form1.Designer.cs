namespace ProyectoKamil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConectar = new Button();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(106, 88);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(150, 46);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 229);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Coneccion a Base de datos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConectar;
    }
}
