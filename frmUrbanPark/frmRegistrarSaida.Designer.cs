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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblUrbanPark = new Label();
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            btnBuscarPorPlaca = new Button();
            mskPlacaVeiculo = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            lblVaga = new Label();
            textBox1 = new TextBox();
            lblCorModelo = new Label();
            lblPlaca = new Label();
            txtNomeCliente = new TextBox();
            lblCliente = new Label();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            dtInfoDtEntrada = new DateTimePicker();
            txtVagaSelecionada = new TextBox();
            lblHoraEntrada = new Label();
            lblDataEntrada = new Label();
            lblVagaSelecionada = new Label();
            btnRegistrarEntrada = new Button();
            btnCancelar = new Button();
            grpCalculo = new GroupBox();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            lblTarifaVigente = new Label();
            lblTempoPermanencia = new Label();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            groupBox2.SuspendLayout();
            grpCalculo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(30, 65, 130);
            pnlCabecalho.Controls.Add(pictureBox1);
            pnlCabecalho.Controls.Add(label1);
            pnlCabecalho.Controls.Add(lblUrbanPark);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.ForeColor = Color.Black;
            pnlCabecalho.Location = new Point(0, -2);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1001, 90);
            pnlCabecalho.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 90);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(543, 58);
            label1.Name = "label1";
            label1.Size = new Size(381, 20);
            label1.TabIndex = 4;
            label1.Text = "Finaliza a movimentação do veículo no estacionamento.";
            // 
            // lblUrbanPark
            // 
            lblUrbanPark.AutoSize = true;
            lblUrbanPark.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUrbanPark.ForeColor = Color.White;
            lblUrbanPark.Location = new Point(239, 21);
            lblUrbanPark.Name = "lblUrbanPark";
            lblUrbanPark.Size = new Size(155, 38);
            lblUrbanPark.TabIndex = 2;
            lblUrbanPark.Text = "UrbanPark";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(543, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 31);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registrar Saída";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarPorPlaca);
            groupBox1.Controls.Add(mskPlacaVeiculo);
            groupBox1.Controls.Add(lblPlacaVeiculo);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Veículo";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPorPlaca.ForeColor = Color.Black;
            btnBuscarPorPlaca.Location = new Point(420, 56);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(269, 34);
            btnBuscarPorPlaca.TabIndex = 3;
            btnBuscarPorPlaca.Text = "Buscar por Placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = true;
            // 
            // mskPlacaVeiculo
            // 
            mskPlacaVeiculo.Location = new Point(155, 56);
            mskPlacaVeiculo.Name = "mskPlacaVeiculo";
            mskPlacaVeiculo.Size = new Size(227, 34);
            mskPlacaVeiculo.TabIndex = 2;
            mskPlacaVeiculo.Text = "ABC-1234";
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(26, 68);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(108, 17);
            lblPlacaVeiculo.TabIndex = 1;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(textBox3);
            grpDadosVeiculo.Controls.Add(textBox2);
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(textBox1);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblPlaca);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.Navy;
            grpDadosVeiculo.Location = new Point(13, 234);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(417, 287);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 34);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 34);
            textBox2.TabIndex = 5;
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaga.ForeColor = Color.Black;
            lblVaga.Location = new Point(37, 173);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(37, 16);
            lblVaga.TabIndex = 0;
            lblVaga.Text = "Vaga:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 34);
            textBox1.TabIndex = 4;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(19, 126);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(78, 16);
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
            lblPlaca.Size = new Size(39, 16);
            lblPlaca.TabIndex = 2;
            lblPlaca.Text = "Placa:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Bahnschrift SemiLight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(112, 33);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(293, 28);
            txtNomeCliente.TabIndex = 1;
            txtNomeCliente.Text = "João Silva";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(37, 39);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(48, 16);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
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
            groupBox2.Location = new Point(436, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 114);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movimentação";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(373, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 34);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2026, 11, 26, 8, 15, 0, 0);
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.CalendarFont = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(107, 69);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(142, 34);
            dtInfoDtEntrada.TabIndex = 6;
            dtInfoDtEntrada.Value = new DateTime(2026, 1, 22, 0, 0, 0, 0);
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.Location = new Point(151, 29);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(268, 34);
            txtVagaSelecionada.TabIndex = 5;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(271, 81);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(96, 16);
            lblHoraEntrada.TabIndex = 4;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(6, 81);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(95, 16);
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
            lblVagaSelecionada.Size = new Size(105, 16);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.White;
            btnRegistrarEntrada.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEntrada.ForeColor = Color.Black;
            btnRegistrarEntrada.Location = new Point(409, 561);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(246, 49);
            btnRegistrarEntrada.TabIndex = 5;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Font = new Font("Bahnschrift SemiBold SemiConden", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(661, 561);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(194, 49);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(label2);
            grpCalculo.Controls.Add(textBox6);
            grpCalculo.Controls.Add(textBox5);
            grpCalculo.Controls.Add(textBox4);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Controls.Add(lblTempoPermanencia);
            grpCalculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCalculo.ForeColor = Color.Navy;
            grpCalculo.Location = new Point(442, 354);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Size = new Size(544, 167);
            grpCalculo.TabIndex = 10;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Cálculo do Estacionamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 124);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 124);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(523, 34);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(183, 75);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(355, 34);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(183, 33);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(355, 34);
            textBox4.TabIndex = 3;
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaVigente.ForeColor = Color.Black;
            lblTarifaVigente.Location = new Point(49, 88);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(83, 16);
            lblTarifaVigente.TabIndex = 2;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // lblTempoPermanencia
            // 
            lblTempoPermanencia.AutoSize = true;
            lblTempoPermanencia.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempoPermanencia.ForeColor = Color.Black;
            lblTempoPermanencia.Location = new Point(26, 40);
            lblTempoPermanencia.Name = "lblTempoPermanencia";
            lblTempoPermanencia.Size = new Size(132, 16);
            lblTempoPermanencia.TabIndex = 1;
            lblTempoPermanencia.Text = "Tempo de Permanência:";
            // 
            // frmRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 645);
            Controls.Add(grpCalculo);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarEntrada);
            Controls.Add(groupBox2);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(groupBox1);
            Controls.Add(pnlCabecalho);
            Name = "frmRegistrarSaida";
            Text = "Registrar Saída";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblTitulo;
        private GroupBox groupBox1;
        private Label lblPlacaVeiculo;
        private MaskedTextBox mskPlacaVeiculo;
        private Button btnBuscarPorPlaca;
        private GroupBox grpDadosVeiculo;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblCorModelo;
        private Label lblPlaca;
        private TextBox txtNomeCliente;
        private Label lblCliente;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtInfoDtEntrada;
        private TextBox txtVagaSelecionada;
        private Label lblHoraEntrada;
        private Label lblDataEntrada;
        private Label lblVagaSelecionada;
        private Label lblUrbanPark;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private GroupBox grpCalculo;
        private Label lblVaga;
        private Label lblTarifaVigente;
        private Label lblTempoPermanencia;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox6;
    }
}