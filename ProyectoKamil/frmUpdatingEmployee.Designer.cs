namespace ProyectoKamil
{
    partial class frmUpdatingEmployee
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
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(292, 313);
            btnGuardar.Margin = new Padding(2, 1, 2, 1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(182, 22);
            btnGuardar.TabIndex = 39;
            btnGuardar.Text = "Modificar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(133, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(511, 287);
            dataGridView1.TabIndex = 51;
            // 
            // frmUpdatingEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            Name = "frmUpdatingEmployee";
            Text = "frmUpdatingEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dataGridView1;
    }
}