using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeMercado
{
    class Caixa
    {
        private int total {get; set; }
        private int restante{get; set; }

        public Caixa(int total) {
            this.total = total;
            this.restante = total;
        }

        public void setRestante(int restante)
        {
            this.restante = restante;
        }

        public int getRestante()
        {
            return this.restante;
        }

    }
}
