using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPonto
{
    class Ponto
    {
        public string DataPonto { get; set; }

        public string Hora { get; set; }

        public Ponto(string dataPonto, string hora)
        {
            DataPonto = dataPonto;
            Hora = hora;
        }
    }
}
