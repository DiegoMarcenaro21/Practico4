using Dominio.Entidades;

namespace Dominio
{
    public class Sistema
    {
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Cuenta> _cuentas = new List<Cuenta>();



       public List<Cuenta> Cuentas { 
        
        get { return _cuentas; }    
        }

        public List<Cliente> Clientes
        {

            get { return _clientes; }
        }




        public void AgregarCliente(Cliente cliente)
        {

            if (cliente == null )
            {
                throw new Exception("Datos inválidos");
            }
            cliente.Validar();
            _clientes.Add(cliente);

        }
    }
}
