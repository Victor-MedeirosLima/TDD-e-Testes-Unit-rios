using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public  class Calculadora
    {

        private List<string> ListaHistorico;

        public Calculadora()
        {
            ListaHistorico = new List<string>();
        }

        public int Somar(int v1,int v2)
        {
            ListaHistorico.Insert(0,$"Res: {v1 + v2}");
            return v1+v2;
        }

        public int Subtrair(int v1, int v2)
        {
            ListaHistorico.Insert(0, $"Res: {v1 - v2}");
            return v1-v2;
        }

        public int Multiplicar(int v1, int v2)
        {
            ListaHistorico.Insert(0, $"Res: {v1 * v2}");
            return v1*v2;
        }

        public int Dividir(int v1, int v2)
        {
            ListaHistorico.Insert(0, $"Res: {v1 / v2}");
            return v1/v2;
        }

        public List<string> Historico()
        {

            ListaHistorico.RemoveRange(3,ListaHistorico.Count-3);
            return ListaHistorico;
        }

    }
}
