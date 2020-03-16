﻿using System;

namespace vector_array
{
    class Vector
    {
        private object[] array;
        private int tamanho;
        private int current;
        

        public Vector(int size)
        {
            this.tamanho = size;
            
        }
        public int size()
        {
            return this.tamanho;
        }
        public bool isEmpty()
        {
            return tamanho==0;
        }
        public object elementAtRank(int current)
        {
            if(current < 0 || current >= size())
            {
                throw new EIndexOutOfRange("erro de index");
            }
            return array[current];
        }
        public object replaceAtRank(int index, object obj)
        {
            if(index < 0 || index >= size())
            {
                throw new EIndexOutOfRange("erro de index");
            }
            object aux = array[index];
            array[index] = obj;
            return aux;
        }
        public void insertAtRank(int index, object obj)
        {
            if(index < 0 || index >= size())
            {
                throw new EIndexOutOfRange("erro de index");
            }
            if (this.current == this.tamanho)
            {
                int newTamanho = this.tamanho * 2;
                Vector newArray = new Vector(newTamanho);
                newArray.array = this.array;
                this.array = newArray;
            }

        }
    }
}