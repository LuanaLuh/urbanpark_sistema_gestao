namespace frmUrbanPark
{
    partial class frmRegistrarSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarSaida));
            pnlCabecalho = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblUrbanPark = new Label();
            lblTitulo = new Label();
            grpBuscarVeiculo = new GroupBox();
            mskPlacaVeiculo = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            txtVaga = new TextBox();
            txtCorModelo = new TextBox();
            lblVaga = new Label();
            txtPlaca = new TextBox();
            lblCorModelo = new Label();
            lblPlaca = new Label();
            txtNomeCliente = new TextBox();
            lblCliente = new Label();
            grpMovimentacao = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            dtInfoDtEntrada = new DateTimePicker();
            txtVagaSelecionada = new TextBox();
            lblHoraEntrada = new Label();
            lblDataEntrada = new Label();
            lblVagaSelecionada = new Label();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            grpCalculo = new GroupBox();
            lblValorAPagar = new Label();
            txtValorApagar = new TextBox();
            txtTarifaVigente = new TextBox();
            txtTempoPermanencia = new TextBox();
            lblTarifaVigente = new Label();
            lblTempoPermanencia = new Label();
            picRegistrarEntrada = new PictureBox();
            picCancelar = new PictureBox();
            btnBuscarPlaca = new Button();
            picBuscarPlaca = new PictureBox();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRegistrarEntrada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscarPlaca).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(30, 65, 130);
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblUrbanPark);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.ForeColor = Color.Black;
            pnlCabecalho.Location = new Point(0, -2);
            pnlCabecalho.Margin = new Padding(3, 2, 3, 2);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(876, 68);
            pnlCabecalho.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(107, 68);
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(475, 44);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(304, 15);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "Finaliza a movimentação do veículo no estacionamento.";
            // 
            // lblUrbanPark
            // 
            lblUrbanPark.AutoSize = true;
            lblUrbanPark.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUrbanPark.ForeColor = Color.White;
            lblUrbanPark.Location = new Point(209, 16);
            lblUrbanPark.Name = "lblUrbanPark";
            lblUrbanPark.Size = new Size(123, 30);
            lblUrbanPark.TabIndex = 2;
            lblUrbanPark.Text = "UrbanPark";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(475, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(139, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registrar Saída";
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(picBuscarPlaca);
            grpBuscarVeiculo.Controls.Add(btnBuscarPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaVeiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.Navy;
            grpBuscarVeiculo.Location = new Point(10, 70);
            grpBuscarVeiculo.Margin = new Padding(3, 2, 3, 2);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Padding = new Padding(3, 2, 3, 2);
            grpBuscarVeiculo.Size = new Size(852, 94);
            grpBuscarVeiculo.TabIndex = 1;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            grpBuscarVeiculo.Enter += grpBuscarVeiculo_Enter;
            // 
            // mskPlacaVeiculo
            // 
            mskPlacaVeiculo.Location = new Point(136, 42);
            mskPlacaVeiculo.Margin = new Padding(3, 2, 3, 2);
            mskPlacaVeiculo.Name = "mskPlacaVeiculo";
            mskPlacaVeiculo.Size = new Size(199, 29);
            mskPlacaVeiculo.TabIndex = 2;
            mskPlacaVeiculo.Text = "ABC-1234";
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(23, 51);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(92, 13);
            lblPlacaVeiculo.TabIndex = 1;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtVaga);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(txtPlaca);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.Navy;
            grpDadosVeiculo.Location = new Point(11, 176);
            grpDadosVeiculo.Margin = new Padding(3, 2, 3, 2);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Padding = new Padding(3, 2, 3, 2);
            grpDadosVeiculo.Size = new Size(365, 215);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtVaga
            // 
            txtVaga.Location = new Point(98, 120);
            txtVaga.Margin = new Padding(3, 2, 3, 2);
            txtVaga.Name = "txtVaga";
            txtVaga.Size = new Size(257, 29);
            txtVaga.TabIndex = 6;
            // 
            // txtCorModelo
            // 
            txtCorModelo.Location = new Point(98, 85);
            txtCorModelo.Margin = new Padding(3, 2, 3, 2);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(257, 29);
            txtCorModelo.TabIndex = 5;
            txtCorModelo.TextChanged += textBox2_TextChanged;
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaga.ForeColor = Color.Black;
            lblVaga.Location = new Point(32, 130);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(32, 15);
            lblVaga.TabIndex = 0;
            lblVaga.Text = "Vaga:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(98, 51);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(257, 29);
            txtPlaca.TabIndex = 4;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(17, 94);
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
            lblPlaca.Location = new Point(32, 61);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(34, 15);
            lblPlaca.TabIndex = 2;
            lblPlaca.Text = "Placa:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Bahnschrift SemiLight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(98, 25);
            txtNomeCliente.Margin = new Padding(3, 2, 3, 2);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(257, 24);
            txtNomeCliente.TabIndex = 1;
            txtNomeCliente.Text = "João Silva";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(32, 29);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(42, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dateTimePicker1);
            grpMovimentacao.Controls.Add(dtInfoDtEntrada);
            grpMovimentacao.Controls.Add(txtVagaSelecionada);
            grpMovimentacao.Controls.Add(lblHoraEntrada);
            grpMovimentacao.Controls.Add(lblDataEntrada);
            grpMovimentacao.Controls.Add(lblVagaSelecionada);
            grpMovimentacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = Color.Navy;
            grpMovimentacao.Location = new Point(382, 176);
            grpMovimentacao.Margin = new Padding(3, 2, 3, 2);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Padding = new Padding(3, 2, 3, 2);
            grpMovimentacao.Size = new Size(481, 86);
            grpMovimentacao.TabIndex = 4;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(326, 52);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 29);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2026, 11, 26, 8, 15, 0, 0);
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(93, 51);
            dtInfoDtEntrada.Margin = new Padding(3, 2, 3, 2);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(134, 29);
            dtInfoDtEntrada.TabIndex = 6;
            dtInfoDtEntrada.Value = new DateTime(2026, 1, 22, 0, 0, 0, 0);
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(132, 22);
            txtVagaSelecionada.Margin = new Padding(3, 2, 3, 2);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(235, 29);
            txtVagaSelecionada.TabIndex = 5;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(237, 61);
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
            lblDataEntrada.Location = new Point(5, 61);
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
            lblVagaSelecionada.Location = new Point(18, 30);
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
            btnRegistrarEntrada.Location = new Point(466, 421);
            btnRegistrarEntrada.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(206, 37);
            btnRegistrarEntrada.TabIndex = 5;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(688, 421);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(lblValorAPagar);
            grpCalculo.Controls.Add(txtValorApagar);
            grpCalculo.Controls.Add(txtTarifaVigente);
            grpCalculo.Controls.Add(txtTempoPermanencia);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Controls.Add(lblTempoPermanencia);
            grpCalculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCalculo.ForeColor = Color.Navy;
            grpCalculo.Location = new Point(387, 266);
            grpCalculo.Margin = new Padding(3, 2, 3, 2);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Padding = new Padding(3, 2, 3, 2);
            grpCalculo.Size = new Size(476, 125);
            grpCalculo.TabIndex = 10;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Cálculo do Estacionamento";
            // 
            // lblValorAPagar
            // 
            lblValorAPagar.AutoSize = true;
            lblValorAPagar.ForeColor = Color.Black;
            lblValorAPagar.Location = new Point(23, 96);
            lblValorAPagar.Name = "lblValorAPagar";
            lblValorAPagar.Size = new Size(360, 21);
            lblValorAPagar.TabIndex = 11;
            lblValorAPagar.Text = "Valor a Pagar:                          R$ 26,50                     ";
            lblValorAPagar.Click += lblValorAPagar_Click;
            // 
            // txtValorApagar
            // 
            txtValorApagar.Location = new Point(13, 93);
            txtValorApagar.Margin = new Padding(3, 2, 3, 2);
            txtValorApagar.Name = "txtValorApagar";
            txtValorApagar.Size = new Size(458, 29);
            txtValorApagar.TabIndex = 5;
            // 
            // txtTarifaVigente
            // 
            txtTarifaVigente.Location = new Point(160, 56);
            txtTarifaVigente.Margin = new Padding(3, 2, 3, 2);
            txtTarifaVigente.Name = "txtTarifaVigente";
            txtTarifaVigente.Size = new Size(311, 29);
            txtTarifaVigente.TabIndex = 4;
            // 
            // txtTempoPermanencia
            // 
            txtTempoPermanencia.Location = new Point(160, 25);
            txtTempoPermanencia.Margin = new Padding(3, 2, 3, 2);
            txtTempoPermanencia.Name = "txtTempoPermanencia";
            txtTempoPermanencia.Size = new Size(311, 29);
            txtTempoPermanencia.TabIndex = 3;
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaVigente.ForeColor = Color.Black;
            lblTarifaVigente.Location = new Point(43, 66);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(72, 15);
            lblTarifaVigente.TabIndex = 2;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // lblTempoPermanencia
            // 
            lblTempoPermanencia.AutoSize = true;
            lblTempoPermanencia.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempoPermanencia.ForeColor = Color.Black;
            lblTempoPermanencia.Location = new Point(23, 30);
            lblTempoPermanencia.Name = "lblTempoPermanencia";
            lblTempoPermanencia.Size = new Size(117, 15);
            lblTempoPermanencia.TabIndex = 1;
            lblTempoPermanencia.Text = "Tempo de Permanência:";
            // 
            // picRegistrarEntrada
            // 
            picRegistrarEntrada.BackColor = Color.Transparent;
            picRegistrarEntrada.Image = (Image)resources.GetObject("picRegistrarEntrada.Image");
            picRegistrarEntrada.Location = new Point(475, 421);
            picRegistrarEntrada.Name = "picRegistrarEntrada";
            picRegistrarEntrada.Size = new Size(35, 37);
            picRegistrarEntrada.TabIndex = 11;
            picRegistrarEntrada.TabStop = false;
            // 
            // picCancelar
            // 
            picCancelar.Image = (Image)resources.GetObject("picCancelar.Image");
            picCancelar.Location = new Point(698, 422);
            picCancelar.Name = "picCancelar";
            picCancelar.Size = new Size(39, 36);
            picCancelar.TabIndex = 12;
            picCancelar.TabStop = false;
            // 
            // btnBuscarPlaca
            // 
            btnBuscarPlaca.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPlaca.ForeColor = Color.Black;
            btnBuscarPlaca.Location = new Point(348, 42);
            btnBuscarPlaca.Name = "btnBuscarPlaca";
            btnBuscarPlaca.Size = new Size(269, 38);
            btnBuscarPlaca.TabIndex = 6;
            btnBuscarPlaca.Text = "Buscar por Placa";
            btnBuscarPlaca.UseVisualStyleBackColor = true;
            // 
            // picBuscarPlaca
            // 
            picBuscarPlaca.Image = (Image)resources.GetObject("picBuscarPlaca.Image");
            picBuscarPlaca.Location = new Point(377, 42);
            picBuscarPlaca.Name = "picBuscarPlaca";
            picBuscarPlaca.Size = new Size(37, 38);
            picBuscarPlaca.TabIndex = 7;
            picBuscarPlaca.TabStop = false;
            // 
            // frmRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 484);
            Controls.Add(picCancelar);
            Controls.Add(picRegistrarEntrada);
            Controls.Add(grpCalculo);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegistrarSaida";
            Text = "Registrar Saída";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRegistrarEntrada).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscarPlaca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblTitulo;
        private GroupBox grpBuscarVeiculo;
        private Label lblPlacaVeiculo;
        private MaskedTextBox mskPlacaVeiculo;
        private GroupBox grpDadosVeiculo;
        private TextBox txtCorModelo;
        private TextBox txtPlaca;
        private Label lblCorModelo;
        private Label lblPlaca;
        private TextBox txtNomeCliente;
        private Label lblCliente;
        private GroupBox grpMovimentacao;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtInfoDtEntrada;
        private TextBox txtVagaSelecionada;
        private Label lblHoraEntrada;
        private Label lblDataEntrada;
        private Label lblVagaSelecionada;
        private Label lblUrbanPark;
        private Label lblSubtitulo;
        private PictureBox picLogo;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private GroupBox grpCalculo;
        private Label lblVaga;
        private Label lblTarifaVigente;
        private Label lblTempoPermanencia;
        private TextBox txtVaga;
        private TextBox txtTarifaVigente;
        private TextBox txtTempoPermanencia;
        private Label lblValorAPagar;
        private TextBox txtValorApagar;
        private PictureBox picRegistrarEntrada;
        private PictureBox picCancelar;
        private Button btnBuscarPlaca;
        private PictureBox picBuscarPlaca;
    }
}