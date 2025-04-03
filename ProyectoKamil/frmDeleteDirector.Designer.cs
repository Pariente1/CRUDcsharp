namespace ProyectoKamil
{
    partial class frmDeleteDirector
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
            label_RFC = new Label();
            textBox_RFC = new TextBox();
            button_Delete = new Button();
            SuspendLayout();
            // 
            // label_RFC
            // 
            label_RFC.AutoSize = true;
            label_RFC.Location = new Point(280, 172);
            label_RFC.Name = "label_RFC";
            label_RFC.Size = new Size(28, 15);
            label_RFC.TabIndex = 23;
            label_RFC.Text = "RFC";
            label_RFC.Click += label_RFC_Click;
            // 
            // textBox_RFC
            // 
            textBox_RFC.Location = new Point(357, 169);
            textBox_RFC.Name = "textBox_RFC";
            textBox_RFC.Size = new Size(100, 23);
            textBox_RFC.TabIndex = 25;
            textBox_RFC.TextChanged += textBox_RFC_TextChanged;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(357, 258);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 24;
            button_Delete.Text = "Borrar";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click_1;
            // 
            // frmDeleteDirector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Delete);
            Controls.Add(label_RFC);
            Controls.Add(textBox_RFC);
            Name = "frmDeleteDirector";
            Text = "frmDeleteDirector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_RFC;
        private TextBox textBox_RFC;
        private Button button_Delete;
    }
}