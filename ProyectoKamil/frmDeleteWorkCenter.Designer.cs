namespace ProyectoKamil
{
    partial class frmDeleteWorkCenter
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
            label_DeleteNameCenter = new Label();
            textBox_DeleteCenterName = new TextBox();
            SuspendLayout();
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(279, 210);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 13;
            button_Delete.Text = "Borrar";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // label_DeleteNameCenter
            // 
            label_DeleteNameCenter.AutoSize = true;
            label_DeleteNameCenter.Location = new Point(197, 146);
            label_DeleteNameCenter.Name = "label_DeleteNameCenter";
            label_DeleteNameCenter.Size = new Size(109, 15);
            label_DeleteNameCenter.TabIndex = 12;
            label_DeleteNameCenter.Text = "Nombre del Centro";
            label_DeleteNameCenter.Click += label_DeleteNameCenter_Click;
            // 
            // textBox_DeleteCenterName
            // 
            textBox_DeleteCenterName.Location = new Point(319, 143);
            textBox_DeleteCenterName.Name = "textBox_DeleteCenterName";
            textBox_DeleteCenterName.Size = new Size(100, 23);
            textBox_DeleteCenterName.TabIndex = 11;
            textBox_DeleteCenterName.TextChanged += textBox_DeleteCenterName_TextChanged;
            // 
            // frmDeleteWorkCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(button_Delete);
            Controls.Add(label_DeleteNameCenter);
            Controls.Add(textBox_DeleteCenterName);
            Name = "frmDeleteWorkCenter";
            Text = "frmDeleteWorkCenter";
            Load += frmDeleteWorkCenter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Delete;
        private Label label_DeleteNameCenter;
        private TextBox textBox_DeleteCenterName;
    }
}