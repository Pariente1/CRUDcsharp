namespace ProyectoKamil
{
    partial class frmDeleteEmployee
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
            button_Delete = new Button();
            textBox_DeleteCenterName = new TextBox();
            label_DeleteEmployeeRFC = new Label();
            textBox_RFC = new TextBox();
            label_RFC = new Label();
            SuspendLayout();
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(371, 247);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 16;
            button_Delete.Text = "Borrar";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // textBox_DeleteCenterName
            // 
            textBox_DeleteCenterName.Location = new Point(0, 0);
            textBox_DeleteCenterName.Name = "textBox_DeleteCenterName";
            textBox_DeleteCenterName.Size = new Size(100, 23);
            textBox_DeleteCenterName.TabIndex = 18;
            // 
            // label_DeleteEmployeeRFC
            // 
            label_DeleteEmployeeRFC.Location = new Point(0, 0);
            label_DeleteEmployeeRFC.Name = "label_DeleteEmployeeRFC";
            label_DeleteEmployeeRFC.Size = new Size(100, 23);
            label_DeleteEmployeeRFC.TabIndex = 17;
            // 
            // textBox_RFC
            // 
            textBox_RFC.Location = new Point(371, 158);
            textBox_RFC.Name = "textBox_RFC";
            textBox_RFC.Size = new Size(174, 23);
            textBox_RFC.TabIndex = 19;
            textBox_RFC.TextChanged += textBox1_TextChanged;
            // 
            // label_RFC
            // 
            label_RFC.AutoSize = true;
            label_RFC.Location = new Point(304, 161);
            label_RFC.Name = "label_RFC";
            label_RFC.Size = new Size(28, 15);
            label_RFC.TabIndex = 20;
            label_RFC.Text = "RFC";
            label_RFC.Click += label1_Click;
            // 
            // frmDeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_RFC);
            Controls.Add(textBox_RFC);
            Controls.Add(button_Delete);
            Controls.Add(label_DeleteEmployeeRFC);
            Controls.Add(textBox_DeleteCenterName);
            Name = "frmDeleteEmployee";
            Text = "frmDeleteEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Delete;
        private TextBox textBox_DeleteCenterName;
        private Label label_DeleteEmployeeRFC;
        private TextBox textBox_RFC;
        private Label label_RFC;
    }
}