using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class MODELAnimal
    {
        private Int32 id;
        private string proprietario;
        private string animal;
        private string telefone;
        private string anaminese;
        private string medicacao;
        private DateTime dataConsulta;

        public Int32 Id { get => id; set => id = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
        public string Animal { get => animal; set => animal = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Anaminese { get => anaminese; set => anaminese = value; }
        public string Medicacao { get => medicacao; set => medicacao = value; }
        public DateTime DataConsulta { get => dataConsulta; set => dataConsulta = value; }

        
    }
}
