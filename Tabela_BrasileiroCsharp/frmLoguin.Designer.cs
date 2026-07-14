namespace Tabela_BrasileiroCsharp
{
    partial class frmLoguin
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
            panel1 = new Panel();
            btnEntrar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(btnSair);
            panel1.Location = new Point(-6, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 118);
            panel1.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Lime;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(627, 20);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(133, 58);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "     Entrar";
            btnEntrar.TextAlign = ContentAlignment.MiddleRight;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += Entrar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(469, 20);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 58);
            btnSair.TabIndex = 0;
            btnSair.Text = "     Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2026_06_16_203518;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(543, 79);
            label1.Name = "label1";
            label1.Size = new Size(245, 129);
            label1.TabIndex = 3;
            label1.Text = "Sistema de \r\ncontrole de \r\nTimes\r\n";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // frmLoguin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmLoguin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Label label1;
    }
}
