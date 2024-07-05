using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo7
{
    public class RepositorioMetodos
    {
     
        public void IngresoPedido()
        {
            MessageBox.Show("¡Su pedido ha sido ingresado con exito!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ModificacionPedido()
        {
            MessageBox.Show("¡Su pedido ha sido modificado con exito!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void EliminarPedido()
        {
            MessageBox.Show("¡Se ha eliminado su pedido con exito!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       


    }
}
