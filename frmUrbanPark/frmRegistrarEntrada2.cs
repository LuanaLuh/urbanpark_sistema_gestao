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
    public partial class frmRegistrarEntrada2  : Form
    {
        private string numVaga;
        private int idVaga;

        public frmRegistrarEntrada2()
        {
            InitializeComponent();
        }

        public frmRegistrarEntrada2(string numVaga, int idVaga) : this()
        {

            this.numVaga = numVaga;
            this.idVaga = idVaga;
        }

       

        private void frmRegistrarEntrada_Load(object sender, EventArgs e)
        {
            txtVagaSelecionada.Text = numVaga;
        }

       
    }
}
