namespace Tabela_BrasileiroCsharp
{
    partial class frmTelaAtualizar
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            cdSerie = new ComboBox();
            btnApagar = new Button();
            btnAtualizar = new Button();
            btnInserir = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNomeTime = new TextBox();
            txtPontosTime = new TextBox();
            txtJogosClube = new TextBox();
            txtSaldoGols = new TextBox();
            label6 = new Label();
            txtPosicaoClube = new TextBox();
            txtDerrotasClube = new TextBox();
            txtVitoriasClube = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            dgvAtualizar = new DataGridView();
            rbNomeTime = new RadioButton();
            rbPosicaoClube = new RadioButton();
            txbBuscar = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cdSerie);
            panel1.Controls.Add(btnApagar);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(btnInserir);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 538);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(160, 419);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(117, 64);
            label2.TabIndex = 5;
            label2.Text = "Atualizar\r\nTimes\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 141);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 4;
            label1.Text = "Série:";
            // 
            // cdSerie
            // 
            cdSerie.BackColor = SystemColors.ScrollBar;
            cdSerie.FormattingEnabled = true;
            cdSerie.Items.AddRange(new object[] { "", "Série A", "Série B", "Série C", "Série D" });
            cdSerie.Location = new Point(30, 165);
            cdSerie.Name = "cdSerie";
            cdSerie.Size = new Size(99, 25);
            cdSerie.TabIndex = 3;
            cdSerie.SelectedValueChanged += cdSerie_SelectedValueChanged;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagar.ForeColor = Color.Black;
            btnApagar.Location = new Point(30, 390);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(99, 52);
            btnApagar.TabIndex = 2;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DodgerBlue;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(30, 308);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(99, 52);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Lime;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(30, 225);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(99, 52);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 27);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 1;
            label3.Text = "Nome Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 96);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 2;
            label4.Text = "Pontos Clube:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(214, 172);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 3;
            label5.Text = "Jogos Clube:";
            // 
            // txtNomeTime
            // 
            txtNomeTime.Location = new Point(214, 55);
            txtNomeTime.Name = "txtNomeTime";
            txtNomeTime.Size = new Size(238, 25);
            txtNomeTime.TabIndex = 4;
            // 
            // txtPontosTime
            // 
            txtPontosTime.Location = new Point(214, 124);
            txtPontosTime.Name = "txtPontosTime";
            txtPontosTime.Size = new Size(238, 25);
            txtPontosTime.TabIndex = 5;
            // 
            // txtJogosClube
            // 
            txtJogosClube.Location = new Point(214, 200);
            txtJogosClube.Name = "txtJogosClube";
            txtJogosClube.Size = new Size(238, 25);
            txtJogosClube.TabIndex = 6;
            // 
            // txtSaldoGols
            // 
            txtSaldoGols.Location = new Point(214, 268);
            txtSaldoGols.Name = "txtSaldoGols";
            txtSaldoGols.Size = new Size(238, 25);
            txtSaldoGols.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(214, 240);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 8;
            label6.Text = "Saldo Gols:";
            // 
            // txtPosicaoClube
            // 
            txtPosicaoClube.Location = new Point(497, 200);
            txtPosicaoClube.Name = "txtPosicaoClube";
            txtPosicaoClube.Size = new Size(238, 25);
            txtPosicaoClube.TabIndex = 14;
            // 
            // txtDerrotasClube
            // 
            txtDerrotasClube.Location = new Point(497, 124);
            txtDerrotasClube.Name = "txtDerrotasClube";
            txtDerrotasClube.Size = new Size(238, 25);
            txtDerrotasClube.TabIndex = 13;
            // 
            // txtVitoriasClube
            // 
            txtVitoriasClube.Location = new Point(497, 56);
            txtVitoriasClube.Name = "txtVitoriasClube";
            txtVitoriasClube.Size = new Size(238, 25);
            txtVitoriasClube.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(497, 172);
            label8.Name = "label8";
            label8.Size = new Size(135, 25);
            label8.TabIndex = 11;
            label8.Text = "Posição Clube:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(497, 96);
            label9.Name = "label9";
            label9.Size = new Size(145, 25);
            label9.TabIndex = 10;
            label9.Text = "Derrotas Clube:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(497, 27);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 9;
            label10.Text = "Vitorias Clube:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.escudoCBF;
            pictureBox1.Location = new Point(162, -36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(622, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // dgvAtualizar
            // 
            dgvAtualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtualizar.Location = new Point(174, 309);
            dgvAtualizar.Name = "dgvAtualizar";
            dgvAtualizar.Size = new Size(600, 134);
            dgvAtualizar.TabIndex = 23;
            dgvAtualizar.CellClick += dgvAtualizar_CellClick;
            // 
            // rbNomeTime
            // 
            rbNomeTime.AutoSize = true;
            rbNomeTime.Location = new Point(191, 471);
            rbNomeTime.Name = "rbNomeTime";
            rbNomeTime.Size = new Size(94, 21);
            rbNomeTime.TabIndex = 25;
            rbNomeTime.TabStop = true;
            rbNomeTime.Text = "Nome Time";
            rbNomeTime.UseVisualStyleBackColor = true;
            // 
            // rbPosicaoClube
            // 
            rbPosicaoClube.AutoSize = true;
            rbPosicaoClube.Location = new Point(320, 471);
            rbPosicaoClube.Name = "rbPosicaoClube";
            rbPosicaoClube.Size = new Size(108, 21);
            rbPosicaoClube.TabIndex = 26;
            rbPosicaoClube.TabStop = true;
            rbPosicaoClube.Text = "Posição Clube";
            rbPosicaoClube.UseVisualStyleBackColor = true;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(460, 470);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(249, 25);
            txbBuscar.TabIndex = 27;
            txbBuscar.TextChanged += txbBuscar_TextChanged;
            // 
            // frmTelaAtualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(778, 515);
            Controls.Add(txbBuscar);
            Controls.Add(rbPosicaoClube);
            Controls.Add(rbNomeTime);
            Controls.Add(dgvAtualizar);
            Controls.Add(txtPosicaoClube);
            Controls.Add(txtDerrotasClube);
            Controls.Add(txtVitoriasClube);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(txtSaldoGols);
            Controls.Add(txtJogosClube);
            Controls.Add(txtPontosTime);
            Controls.Add(txtNomeTime);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "frmTelaAtualizar";
            Text = "frmTelaAtualizar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnApagar;
        private Button btnAtualizar;
        private Button btnInserir;
        private Label label2;
        private Label label1;
        private ComboBox cdSerie;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNomeTime;
        private TextBox txtPontosTime;
        private TextBox txtJogosClube;
        private TextBox txtSaldoGols;
        private Label label6;
        private TextBox txtPosicaoClube;
        private TextBox txtDerrotasClube;
        private TextBox txtVitoriasClube;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private DataGridView dgvAtualizar;
        private Panel panel2;
        private RadioButton rbNomeTime;
        private RadioButton rbPosicaoClube;
        private TextBox txbBuscar;
    }
}