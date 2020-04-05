﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeMercado

{


    class Fila<T>
    {
        public Node<T> head { get; private set; }
        public Node<T> end { get; private set; }
        public int qtde { get; private set; }
        public Fila()
        {
            this.end = null;
            this.head = null;
            this.qtde = 0;
        }

        /* Retorna se a lista está vazia ou não*/
        public bool IsEmpty
        {
            get { return this.qtde == 0; }
        }
        /* Retorna a quantidade de elementos da lista */
        public int Count
        {
            get { return this.qtde; }
        }
        /* Remove o primeiro elemento da lista.*/
        public void Dequeue()
        {
            if (head != null)
            {
                head = head.Proximo;
            }
            qtde--;
        }

        public T Peek() {
            return head.Item;
        }

        public void Enqueue(T temp)
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
