using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMediaPlayer
{


    class ListaEncadeada<T>
    {



        public Node<T> head { get; private set; }
        public Node<T> end { get; private set; }
        public int qtde { get; private set; }
        public ListaEncadeada()
        {
            this.end = null;
            this.head = null;
            this.qtde = 0;
        }

        public bool IsEmpty
        {
            get { return this.qtde == 0; }
        }
        public int count
        {
            get { return this.qtde; }
        }
        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Proximo;
            }
            qtde--;
        }

        public void RemoveLast()
        {
            if (head == null)
            {

                return;
            }
            if (head.Proximo == null)
            {
                head = null;
            }
            else
            {
                Node<T> last = head.Proximo;
                Node<T> penultimate = head;

                while (last.Proximo != null)
                {
                    penultimate = last;
                    last = last.Proximo;
                }
                penultimate.Proximo = null;
                end = penultimate;
            }
            qtde--;
        }

        public void DeleteNode(object data)
        {
            if (head.Proximo == data)
            {
                head = head.Proximo;
            }
            else
            {
                Node<T> removed = Find(data);
                if (removed.Proximo != null)
                    removed.Proximo = removed.Proximo.Proximo;
                else
                    Console.WriteLine("The give element is not found in the list");
            }
        }
        private Node<T> Find(object data)
        {
            Node<T> n = head;
            while (n.Proximo != null)
            {
                if (n.Proximo != data)
                {
                    n = n.Proximo;
                }
                else
                    return n;
            }
            return n;
        }

        public void InsertFirst(T temp)
        {
            //Cria Nó
            Node<T> newNode = new Node<T>(temp);
            //Novo nó recebe o Valor
            //Verifica se é o primeiro nó
            if (head == null)
            {
                //A cabeça e a Calda recebem o novo valor
                head = newNode;
                end = newNode;

            }
            else
            {
                //o Próximo Nó recebe a cabeça
                newNode.Proximo = head;
            }
            //A cabeça recebe o novo nó
            head = newNode;
            qtde++;
        }

        public void InsertLast(T temp)
        {

            //Cria o nó com os valores que serão recebidos
            Node<T> newNode = new Node<T>(temp);
            //Novo nó recebe o valor 
            //Verifica se é o primeiro
            if (head == null)
            {
                head = newNode;
                end = newNode;
            }
            else
            {
                //Adiciona ao próximo da lista o novo valor
                end.Proximo = newNode;
            }
            //Adiciona a calda o novo valor
            end = newNode;
            qtde++;
        }

    }
}
