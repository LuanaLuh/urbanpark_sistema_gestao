using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backUrbanPark.Model
{
    public class Vaga
    {
        private int _id;
        private int _numero_vaga;
        private TipoVaga _tipoVaga;
        private TipoStatus _tipostatus;

        public Vaga(int numero_vaga, TipoVaga tipoVaga, TipoStatus tipostatus)
        {
            Numero_vaga = numero_vaga;
            TipoVaga = tipoVaga;
            Tipostatus = tipostatus;
        }

        public Vaga(int id, int numero_vaga, TipoVaga tipoVaga, TipoStatus tipostatus)
        {
            Id = id;
            Numero_vaga = numero_vaga;
            TipoVaga = tipoVaga;
            Tipostatus = tipostatus;
        }

        public int Id { get => _id; set => _id = value; }
        public int Numero_vaga { get => _numero_vaga; set => _numero_vaga = value; }
        public TipoVaga TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }
        public TipoStatus Tipostatus { get => _tipostatus; set => _tipostatus = value; }




    }
}
