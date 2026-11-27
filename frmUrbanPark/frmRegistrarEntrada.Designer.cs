
namespace frmUrbanPark
{
    partial class frmRegistrarEntrada
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            label1 = new Label();
            picLogo = new PictureBox();
            lblUrbanPark = new Label();
            grpBuscarVeiculo = new GroupBox();
            picBuscarPlaca = new PictureBox();
            lblPlacaVeiculo = new Label();
            btnBuscarPorPlaca = new Button();
            mskPlacaVeiculo = new MaskedTextBox();
            grpDadosVeiculo = new GroupBox();
            txtCorModelo = new TextBox();
            txtPlaca = new TextBox();
            lblCorModelo = new Label();
            lblPlaca = new Label();
            txtNomeCliente = new TextBox();
            lblCliente = new Label();
            groupBox2 = new GroupBox();
            dtInFoHrSaida = new DateTimePicker();
            dtInfoDtEntrada = new DateTimePicker();
            txtVagaSelecionada = new TextBox();
            lblHoraEntrada = new Label();
            lblDataEntrada = new Label();
            lblVagaSelecionada = new Label();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            picCancelar = new PictureBox();
            picRegistrarEntrada = new PictureBox();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBuscarPlaca).BeginInit();
            grpDadosVeiculo.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegistrarEntrada).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(30, 65, 130);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(label1);
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Controls.Add(lblUrbanPark);
            pnlCabecalho.Location = new Point(-1, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(898, 75);
            pnlCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(456, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(159, 25);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Registrar Entrada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(456, 48);
            label1.Name = "label1";
            label1.Size = new Size(293, 15);
            label1.TabIndex = 3;
            label1.Text = "Inicia a movimentação do veículo no estacionamento.";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(0, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(122, 82);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblUrbanPark
            // 
            lblUrbanPark.AutoSize = true;
            lblUrbanPark.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUrbanPark.ForeColor = Color.White;
            lblUrbanPark.Location = new Point(217, 21);
            lblUrbanPark.Name = "lblUrbanPark";
            lblUrbanPark.Size = new Size(123, 30);
            lblUrbanPark.TabIndex = 1;
            lblUrbanPark.Text = "UrbanPark";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(picBuscarPlaca);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.Navy;
            grpBuscarVeiculo.Location = new Point(14, 81);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(871, 108);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // picBuscarPlaca
            // 
            picBuscarPlaca.Location = new Point(424, 50);
            picBuscarPlaca.Name = "picBuscarPlaca";
            picBuscarPlaca.Size = new Size(37, 31);
            picBuscarPlaca.TabIndex = 4;
            picBuscarPlaca.TabStop = false;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(37, 62);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(92, 13);
            lblPlacaVeiculo.TabIndex = 3;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPorPlaca.ForeColor = Color.Black;
            btnBuscarPorPlaca.Location = new Point(380, 47);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(269, 38);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            btnBuscarPorPlaca.Click += btnBuscarPorPlaca_Click;
            // 
            // mskPlacaVeiculo
            // 
            mskPlacaVeiculo.Location = new Point(147, 52);
            mskPlacaVeiculo.Name = "mskPlacaVeiculo";
            mskPlacaVeiculo.Size = new Size(227, 29);
            mskPlacaVeiculo.TabIndex = 1;
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtPlaca);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.Navy;
            grpDadosVeiculo.Location = new Point(14, 195);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(417, 165);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtCorModelo
            // 
            txtCorModelo.Location = new Point(112, 113);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(293, 29);
            txtCorModelo.TabIndex = 5;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(112, 68);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(293, 29);
            txtPlaca.TabIndex = 4;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(19, 126);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(70, 15);
            lblCorModelo.TabIndex = 3;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaca.ForeColor = Color.Black;
            lblPlaca.Location = new Point(37, 81);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(34, 15);
            lblPlaca.TabIndex = 2;
            lblPlaca.Text = "Placa:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Bahnschrift SemiLight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(112, 33);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(293, 24);
            txtNomeCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(37, 39);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(42, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtInFoHrSaida);
            groupBox2.Controls.Add(dtInfoDtEntrada);
            groupBox2.Controls.Add(txtVagaSelecionada);
            groupBox2.Controls.Add(lblHoraEntrada);
            groupBox2.Controls.Add(lblDataEntrada);
            groupBox2.Controls.Add(lblVagaSelecionada);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.Location = new Point(438, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 165);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movimentação";
            // 
            // dtInFoHrSaida
            // 
            dtInFoHrSaida.CalendarFont = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInFoHrSaida.Format = DateTimePickerFormat.Time;
            dtInFoHrSaida.Location = new Point(151, 126);
            dtInFoHrSaida.Name = "dtInFoHrSaida";
            dtInFoHrSaida.Size = new Size(142, 29);
            dtInFoHrSaida.TabIndex = 7;
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(151, 75);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(270, 29);
            dtInfoDtEntrada.TabIndex = 6;
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(151, 29);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(268, 29);
            txtVagaSelecionada.TabIndex = 5;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(21, 131);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(84, 15);
            lblHoraEntrada.TabIndex = 4;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(21, 86);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(82, 15);
            lblDataEntrada.TabIndex = 1;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVagaSelecionada.ForeColor = Color.Black;
            lblVagaSelecionada.Location = new Point(21, 40);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(90, 15);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.White;
            btnRegistrarEntrada.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEntrada.ForeColor = Color.Black;
            btnRegistrarEntrada.Location = new Point(455, 381);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(232, 49);
            btnRegistrarEntrada.TabIndex = 4;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(696, 381);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(189, 49);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // picCancelar
            // 
            picCancelar.BackColor = Color.Transparent;
            picCancelar.Location = new Point(704, 381);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(45, 49);
            picCancelar.TabIndex = 12;
            picCancelar.TabStop = false;
            // 
            // picRegistrarEntrada
            // 
            picRegistrarEntrada.BackColor = Color.Transparent;
            picRegistrarEntrada.Location = new Point(459, 381);
            picRegistrarEntrada.Name = "picRegistrarEntrada";
            picRegistrarEntrada.Size = new Size(50, 49);
            picRegistrarEntrada.TabIndex = 13;
            picRegistrarEntrada.TabStop = false;
            // 
            // frmRegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 450);
            Controls.Add(pnlCabecalho);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(groupBox2);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(btnCancelar);
            Name = "frmRegistrarEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Entrada";
            Load += frmRegistrarEntrada_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBuscarPlaca).EndInit();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegistrarEntrada).EndInit();
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
        private Button btnBuscarPorPlaca;
        private Label lblPlacaVeiculo;
        private PictureBox picBuscarPlaca;

        private GroupBox grpDadosVeiculo;
        private TextBox txtNomeCliente;
        private Label lblCliente;
        private Label lblCorModelo;
        private Label lblPlaca;
        private TextBox txtCorModelo;
        private TextBox txtPlaca;

        private GroupBox groupBox2;
        private Label lblHoraEntrada;
        private Label lblDataEntrada;
        private Label lblVagaSelecionada;
        private DateTimePicker dtInFoHrSaida;
        private DateTimePicker dtInfoDtEntrada;
        private TextBox txtVagaSelecionada;

        private Button btnRegistrarEntrada;
        private Button btnCancelar;

        private PictureBox picCancelar;
        private PictureBox picRegistrarEntrada;
    }
}
