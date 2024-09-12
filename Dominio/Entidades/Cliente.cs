using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public int Nombre { get; set; }

        private static int ultId = 0;

        private List<Cuenta> _cuentas = new List<Cuenta>();


        public Cliente(string cedula, int nombre)
        {
            Id = ultId++;
            Cedula = cedula;
            Nombre = nombre;
        }
        public void Validar()
        {
            ValidarCedula();

        }
        public bool ValidarCedula() {
            bool val=false;

            if(Cedula !=null && Cedula.Length==8 ) { 
            
                val = true;

                return val;
           
            }else {

                throw new Exception("Cedula invalida");
            }
            

        }

        public override string ToString() { 
            string respuesta=string.Empty;

            respuesta += $"Id: {Id} \n";
            respuesta += $"Cedula: {Cedula} \n";
            respuesta += $"Nombre: {Nombre} \n";
           
            return respuesta;
        }
        public override bool Equals(object? obj)
        {
            Cliente objC = obj as Cliente;
            return objC != null && Cedula == objC.Cedula;  
        }
    }



        }
            
    

