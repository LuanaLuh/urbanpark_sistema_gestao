using backUrbanPark.Model;
using backUrbanPark.Repository;
using frmUrbanPark.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark
{
    public partial class frmListVagas : Form
    {
        public frmListVagas()
        {
            InitializeComponent();
        }

        private void frmListVagas_Load(object sender, EventArgs e)
        {
            carregarDadosEMontarVisualizacao();
        }


        private void carregarDadosEMontarVisualizacao()
        {
            List<Vaga> listaDeVagas = VagaRepository.ListarTodas();

            flwCardVagas.Controls.Clear();

            foreach (Vaga vaga in listaDeVagas)
            {
                string strNumeroVaga = vaga.Numero_vaga.ToString();
                statusVaga statusVaga = Enum.Parse<statusVaga>(vaga.Tipostatus.ToString());
                int idVaga = vaga.Id;

                ctrStatusVagas cardVaga = new ctrStatusVagas();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;

                cardVaga.CardClicado += cardVaga_click;


                flwCardVagas.Controls.Add(cardVaga);

            }
        }

        public void cardVaga_click(object sender, EventArgs e)
        {
            ctrStatusVagas cardSelecionado = (ctrStatusVagas)sender;
          
            if(cardSelecionado.StatusVaga == statusVaga.Livre)
            {
                // Inicializa o formulario de entrada e passa as informações da vaga.
                frmRegistrarEntrada frmEntrada = new frmRegistrarEntrada(
                cardSelecionado.NumeroVaga,
                cardSelecionado.IdVaga
                );

                frmEntrada.ShowDialog();

            }
            else
            {
                frmRegistrarSaida frmSaida = new frmRegistrarSaida();

                frmSaida.ShowDialog();
            }


        }

        private void flwCardVagas_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}

