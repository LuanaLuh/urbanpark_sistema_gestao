namespace frmUrbanPark
{
    partial class frmRegistrarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEntrada));
            pnlCabecalho = new Panel();
            picLogo = new PictureBox();
            lblUrbanPark = new Label();
            label1 = new Label();
            lblTitulo = new Label();
            grpBuscarVeiculo = new GroupBox();
            lblPlacaVeiculo = new Label();
            mskPlacaVeiculo = new MaskedTextBox();
            btnBuscarPorPlaca = new Button();
            grpDadosVeiculo = new GroupBox();
            groupBox2 = new GroupBox();
            lblCliente = new Label();
            txtNomeCliente = new TextBox();
            lblPlaca = new Label();
            lblCorModelo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblVagaSelecionada = new Label();
            lblDataEntrada = new Label();
            lblHoraEntrada = new Label();
            txtVagaSelecionada = new TextBox();
            dtInfoDtEntrada = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(30, 65, 130);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(label1);
            pnlCabecalho.Controls.Add(lblUrbanPark);
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Location = new Point(-1, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(798, 75);
            pnlCabecalho.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(108, 73);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblUrbanPark
            // 
            lblUrbanPark.AutoSize = true;
            lblUrbanPark.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUrbanPark.ForeColor = Color.White;
            lblUrbanPark.Location = new Point(190, 12);
            lblUrbanPark.Name = "lblUrbanPark";
            lblUrbanPark.Size = new Size(155, 38);
            lblUrbanPark.TabIndex = 1;
            lblUrbanPark.Text = "UrbanPark";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(405, 40);
            label1.Name = "label1";
            label1.Size = new Size(366, 20);
            label1.TabIndex = 3;
            label1.Text = "Inicia a movimentação do veículo no estacionamento.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(405, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 31);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Registrar Entrada";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.Navy;
            grpBuscarVeiculo.Location = new Point(12, 81);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(774, 108);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(33, 52);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(108, 17);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // mskPlacaVeiculo
            // 
            mskPlacaVeiculo.Location = new Point(159, 40);
            mskPlacaVeiculo.Name = "mskPlacaVeiculo";
            mskPlacaVeiculo.Size = new Size(202, 34);
            mskPlacaVeiculo.TabIndex = 1;
            mskPlacaVeiculo.Text = "ABC-1234";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPorPlaca.ForeColor = Color.Black;
            btnBuscarPorPlaca.Location = new Point(377, 40);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(239, 34);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(textBox2);
            grpDadosVeiculo.Controls.Add(textBox1);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.Navy;
            grpDadosVeiculo.Location = new Point(12, 195);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(371, 165);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "S";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(dtInfoDtEntrada);
            groupBox2.Controls.Add(txtVagaSelecionada);
            groupBox2.Controls.Add(lblHoraEntrada);
            groupBox2.Controls.Add(lblDataEntrada);
            groupBox2.Controls.Add(lblVagaSelecionada);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.Location = new Point(389, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 165);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movimentação";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(33, 39);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(48, 16);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Bahnschrift SemiLight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(100, 33);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(261, 28);
            txtNomeCliente.TabIndex = 1;
            txtNomeCliente.Text = "João Silva";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaca.ForeColor = Color.Black;
            lblPlaca.Location = new Point(33, 81);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(39, 16);
            lblPlaca.TabIndex = 2;
            lblPlaca.Text = "Placa:";
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(17, 126);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(78, 16);
            lblCorModelo.TabIndex = 3;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 34);
            textBox2.TabIndex = 5;
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVagaSelecionada.ForeColor = Color.Black;
            lblVagaSelecionada.Location = new Point(19, 40);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(105, 16);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(19, 86);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(95, 16);
            lblDataEntrada.TabIndex = 1;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(19, 131);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(96, 16);
            lblHoraEntrada.TabIndex = 4;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(134, 29);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(239, 34);
            txtVagaSelecionada.TabIndex = 5;
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(134, 75);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(240, 34);
            dtInfoDtEntrada.TabIndex = 6;
            dtInfoDtEntrada.Value = new DateTime(2026, 1, 22, 0, 0, 0, 0);
            dtInfoDtEntrada.ValueChanged += dtInfoDtEntrada_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(134, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(127, 34);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2026, 11, 26, 8, 15, 0, 0);
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.Location = new Point(331, 381);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(219, 49);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(579, 381);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 49);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 453);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(groupBox2);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Name = "frmRegistrarEntrada";
            Text = "Registrar Entrada";
            Load += frmRegistrarEntrada_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblUrbanPark;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label label1;
        private GroupBox grpBuscarVeiculo;
        private MaskedTextBox mskPlacaVeiculo;
        private Label lblPlacaVeiculo;
        private Button btnBuscarPorPlaca;
        private GroupBox grpDadosVeiculo;
        private GroupBox groupBox2;
        private TextBox txtNomeCliente;
        private Label lblCliente;
        private Label lblCorModelo;
        private Label lblPlaca;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblHoraEntrada;
        private Label lblDataEntrada;
        private Label lblVagaSelecionada;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtInfoDtEntrada;
        private TextBox txtVagaSelecionada;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
    }
}