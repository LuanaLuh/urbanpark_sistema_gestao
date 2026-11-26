using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark.Parts
{
    public enum statusVaga
    {
        Livre,
        Ocupada
    }

    public partial class ctrStatusVagas : UserControl
    {
        private statusVaga _statusVaga;
        private string _numeroVaga;
        private int _idVaga;


        // Evento publico com assinatura de delegate EventHandler,
        // que será disparado quando o card for clicado
        // (object sender, EventArgs e)
        public event EventHandler CardClicado;



        private Color _verdeClaro = Color.FromArgb(223, 247, 231);
        private Color _vermelhoClaro = Color.FromArgb(254, 224, 221);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public statusVaga StatusVaga { get => _statusVaga; set => _statusVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdVaga { get => _idVaga; set => _idVaga = value; }

        public ctrStatusVagas()
        {
            InitializeComponent();

            // ==================================================================
            // 2. INSCRIÇÃO NOS EVENTOS INTERNOS (+=)
            // No Windows Forms, clicar em um Label ou PictureBox dentro de um
            // UserControl NÃO dispara o Click do UserControl automaticamente.
            // Por isso, conectamos o Click do fundo, do texto e da imagem
            // ao mesmo método (AoClicarNoCard), garantindo que o card inteiro
            // seja clicável.
            // ==================================================================
            this.Click += AoClicarNoCard;
            this.lblNumeroVaga.Click += AoClicarNoCard;
            this.picStatusVaga.Click += AoClicarNoCard;


        }

        private void AoClicarNoCard(object sender, EventArgs e)
        {
            // Deletegate
            // Dispara o evento CardClicado, passando o próprio controle como remetente
            CardClicado?.Invoke(this, EventArgs.Empty);

        }
                     

        private void atualizarAparenciaCard()
        {

            this.lblNumeroVaga.Text = this.NumeroVaga;

            if (this.StatusVaga == statusVaga.Livre)
            {
                this.BackColor = _verdeClaro;
                this.picStatusVaga.Image = Properties.Resources.carlconVerde;

            }
            else
            {

                this.BackColor = _vermelhoClaro;
                this.picStatusVaga.Image = Properties.Resources.carIconVermelho;

            }
        }

        private void picStatusVaga_Click(object sender, EventArgs e)
        {


        }

        private void ctrStatusVagas_Load_1(object sender, EventArgs e)
        {
            atualizarAparenciaCard();

        }
    }
}