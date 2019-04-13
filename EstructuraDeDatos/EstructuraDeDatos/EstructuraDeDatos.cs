using System;

namespace EstructuraDeDatos
{
    class Nodo
    {
        private Object valor;
        private Nodo enlaceSiguiente;

        public Nodo()
        {
            valor = null;
            enlaceSiguiente = null;
        }

        public Nodo(Object valor)
        {
            this.valor = valor;
            this.enlaceSiguiente = null;
        }

        public Object getValor()
        {
            return this.valor;
        }

        public void setValor(Object valor)
        {
            this.valor = valor;
        }

        public Nodo getEnlaceSiguiente()
        {
            return this.enlaceSiguiente;
        }

        public void setEnlaceSiguiente(Nodo enlaceSiguiente)
        {
            this.enlaceSiguiente = enlaceSiguiente;
        }
    }

    public class LinkedList
    {
        private Nodo primero;
        private Nodo actual;
        private Nodo ultimo;

        public LinkedList()
        {
            primero = null;
            actual = null;
            ultimo = null;
        }

        public void insertar(Object dato)
        {
            Nodo nodo = new Nodo(dato);
            if (primero == null)
            {
                primero = nodo;
                actual = nodo;
                ultimo = nodo;
            }
            else
            {
                ultimo.setEnlaceSiguiente(nodo);
                ultimo = nodo;
            }
        }

        public Object getActual()
        {
            return actual.getValor();
        }
        public Object getEnlaceActual()
        {
            return actual.getEnlaceSiguiente();
        }
        public Object getUltimo()
        {
            return ultimo.getValor();
        }
        public void next()
        {
            actual = actual.getEnlaceSiguiente();
        }
    }

    public class Cola
    {
        private Nodo primero;
        private Nodo actual;

        public Cola()
        {
            primero = null;
            actual = null;
        }

        public void push(Object valor)
        {
            Nodo nodo = new Nodo(valor);
            if (primero == null)
            {
                primero = nodo;
                actual = primero;
            } else
            {
                actual.setEnlaceSiguiente(nodo);
                actual = nodo;
            }
            
        }
        public Object pop()
        {
            primero = primero.getEnlaceSiguiente();
            return primero;
        }

        public Object getPrimero()
        {
            return primero.getValor();
        }
    }

    public class Pila
    {
        private Nodo primero;

        public Pila()
        {
            primero = null;
        }

        public Object pop()
        {
            primero = primero.getEnlaceSiguiente();
            return primero;
        }

        public void push(Object valor)
        {
            Nodo nodo = new Nodo(valor);
            nodo.setEnlaceSiguiente(primero);
            primero = nodo;
        }
        public Object getPrimero()
        {
            return primero.getValor();
        }
    }
}
