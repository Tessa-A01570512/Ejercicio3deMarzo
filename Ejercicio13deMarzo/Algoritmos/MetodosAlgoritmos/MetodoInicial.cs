using Ejercicio3deMarzo.Algoritmos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3deMarzo.Algoritmos.MetodosAlgoritmos
{
    public class MetodoInicial
    {
        public MetodoInicial()
        {
        }
        public double AlgoritmoInicial(List<Demanda> listaDemandas  )
        {
            double media = 0, suma = 0;
            foreach (Demanda demanda in listaDemandas)
            {
              suma= suma + demanda.Cantidad;       
            }
            media = suma /listaDemandas.Count ;
            return media;
        }
        public List<Demanda> LlenarDatosListDemandas()
        {
            List<Demanda> listaInicial = new List<Demanda>();
            Demanda demanda1= new Demanda("1","01", 20);
            Demanda demanda2 = new Demanda("2", "01", 40);
            Demanda demanda3 = new Demanda("3", "01", 30);
            listaInicial.Add(demanda1);
            listaInicial.Add(demanda2);
            listaInicial.Add(demanda3);

            return listaInicial;
        }
        public double AlgoritmoPrincipal()
        {
            double media = 0;
            List<Demanda> lista = LlenarDatosListDemandas();
            media = AlgoritmoInicial(lista);
            return media;

        }
    }
}
