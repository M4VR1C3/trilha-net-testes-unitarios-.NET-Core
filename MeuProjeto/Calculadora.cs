using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }

        public int somar(int a, int b)
        {
            int resp = a + b;
            listahistorico.Insert(0, "Resp: " + resp + " Data: " + data);
            return resp;
        }
        public int subtrair(int a, int b)
        {
            int resp = a - b;
            listahistorico.Insert(0, "Resp: " + resp + " Data: " + data);
            return resp;
        }
        public int multiplicar(int a, int b)
        {
            int resp = a * b;
            listahistorico.Insert(0, "Resp: " + resp + " Data: " + data);
            return resp;
        }
        public int dividir(int a, int b)
        {
            int resp = a / b;
            listahistorico.Insert(0, "Resp: " + resp + " Data: " + data);
            return resp;
        }
        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico; 
        }
    }
}
