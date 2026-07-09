namespace Tabela_BrasileiroCsharp
{
    partial class frmTelaConsultar
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
            panel1 = new Panel();
            label1 = new Label();
            dgvConsultar = new DataGridView();
            cbSeries = new ComboBox();
            label2 = new Label();
            btnConsultar = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(cbSeries);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 454);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 39);
            label1.Name = "label1";
            label1.Size = new Size(113, 60);
            label1.TabIndex = 1;
            label1.Text = "Consultar \r\nTimes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvConsultar
            // 
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Location = new Point(245, 22);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.Size = new Size(553, 312);
            dgvConsultar.TabIndex = 2;
            // 
            // cbSeries
            // 
            cbSeries.BackColor = SystemColors.ScrollBar;
            cbSeries.FormattingEnabled = true;
            cbSeries.Items.AddRange(new object[] { "", "Série A", "Série B", "Série C", "Série D" });
            cbSeries.Location = new Point(59, 296);
            cbSeries.Name = "cbSeries";
            cbSeries.Size = new Size(121, 25);
            cbSeries.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 192);
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 254);
            label2.Name = "label2";
            label2.Size = new Size(67, 30);
            label2.TabIndex = 2;
            label2.Text = "Série:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Lime;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.FromArgb(0, 0, 192);
            btnConsultar.Location = new Point(59, 327);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 41);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.TextAlign = ContentAlignment.MiddleRight;
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CBF_estuda_renomear_as_divisoes_do_Brasileirao_par01367535002025110715371;
            pictureBox1.Location = new Point(62, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 461);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmTelaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultar);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "frmTelaConsultar";
            Text = "frmTelaConsultar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnConsultar;
        private ComboBox cbSeries;
        private DataGridView dgvConsultar;
        private PictureBox pictureBox1;
    }
}