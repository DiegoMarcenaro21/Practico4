using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio.Entidades
{
    public class Cuenta
    {
       public int Id;
        public string Moneda;
        public int Saldo;

        private static int ultId= 0;
        public Cuenta( string moneda, int saldo)
        {
            Id = ultId++;
            Moneda = moneda;
            Saldo = saldo;

        }


     



        public override string ToString() { 
        string respuesta=string.Empty;

            respuesta += $"Id: {Id} \n";
            respuesta += $"Moneda: {Moneda} \n";
            respuesta += $"Saldo: {Saldo} \n";

            return respuesta;
        }

    }
}
