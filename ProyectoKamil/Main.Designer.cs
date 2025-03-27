namespace ProyectoKamil
{
    partial class Main
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            addWorker = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            conexionesToolStripMenuItem = new ToolStripMenuItem();
            conectarABaseDeDatosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(412, 109);
            label1.Name = "label1";
            label1.Size = new Size(332, 32);
            label1.TabIndex = 1;
            label1.Text = "Menú de opciones de Kamil";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(addWorker);
            groupBox1.Location = new Point(21, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 453);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(95, 113);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Ver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += frmViewEmployees_Click;
            // 
            // addWorker
            // 
            addWorker.Location = new Point(95, 61);
            addWorker.Name = "addWorker";
            addWorker.Size = new Size(150, 46);
            addWorker.TabIndex = 0;
            addWorker.Text = "Agregar ";
            addWorker.UseVisualStyleBackColor = true;
            addWorker.Click += btnAddWorker;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(398, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 453);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Directores";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(89, 113);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 1;
            button4.Text = "Ver";
            button4.UseVisualStyleBackColor = true;
            button4.Click += frmViewDirectors_Click;
            // 
            // button3
            // 
            button3.Location = new Point(89, 61);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 0;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += frmAddDirectors_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Location = new Point(789, 203);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(359, 453);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Centros";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button6
            // 
            button6.Location = new Point(92, 113);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 1;
            button6.Text = "Ver";
            button6.UseVisualStyleBackColor = true;
            button6.Click += frmViewWorkCenter_Click;
            // 
            // button5
            // 
            button5.Location = new Point(92, 61);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 0;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += frmAddWorkCenter_Click;
            // 
            // conexionesToolStripMenuItem
            // 
            conexionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conectarABaseDeDatosToolStripMenuItem });
            conexionesToolStripMenuItem.Name = "conexionesToolStripMenuItem";
            conexionesToolStripMenuItem.Size = new Size(158, 36);
            conexionesToolStripMenuItem.Text = "Conexiones";
            // 
            // conectarABaseDeDatosToolStripMenuItem
            // 
            conectarABaseDeDatosToolStripMenuItem.Name = "conectarABaseDeDatosToolStripMenuItem";
            conectarABaseDeDatosToolStripMenuItem.Size = new Size(419, 44);
            conectarABaseDeDatosToolStripMenuItem.Text = "Conectar a Base de Datos";
            conectarABaseDeDatosToolStripMenuItem.Click += conectarABaseDeDatosToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { conexionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1174, 40);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Proyecto Kamil";
            Load += Main_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button2;
        private Button addWorker;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button5;
        private ToolStripMenuItem conexionesToolStripMenuItem;
        private ToolStripMenuItem conectarABaseDeDatosToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
