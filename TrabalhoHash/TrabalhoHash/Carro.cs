using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHash
{
    class Carro
    {
        public int Modelo { get; set;}
        public int Portas { get; set; }
        public int Rodas { get; set; }
        public int Som { get; set; }
        public int ArCondicionado { get; set; }
        public int AirBag { get; set; }
        public String Placa { get; set; }

        public Carro(int modelo, int portas, int rodas, int som, int arCondicionado, int airBag, String placa) {

            this.Modelo = modelo;
            this.Portas = portas;
            this.Som = som;
            this.ArCondicionado = arCondicionado;
            this.AirBag = airBag;
            this.Placa = placa;
        }

    }
}
