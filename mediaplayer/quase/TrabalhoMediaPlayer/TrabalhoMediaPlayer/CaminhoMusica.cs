using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMediaPlayer
{
   public class CaminhoMusica
    {
        public int index;
        public string caminho;

        public CaminhoMusica(string caminho, int index) {
            this.index = index;
            this.caminho = caminho;
        }

    }
}
