using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo7
{

    public partial class Form5 : Form

    {

        private SqlConnection conn;
        private SqlCommand insert1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        private string sCn;



        OleDbConnection cnn = new OleDbConnection();



        public Form5()
        {
            InitializeComponent();

            //Linea de conexion con el servidor de base de datos SQL por OleDb
            cnn.ConnectionString = @"PROVIDER=SQLOLEDB;Server=DESKTOP-BNC8SKO\SQLEXPRESS;Database=BD_PIZZERIA_TURBO;Uid=sa;Pwd=12345";





            Conexion cn1 = new Conexion();
            cn1.conec();
            sCn = cn1.cadena;
            conn = new SqlConnection(sCn);
            conn.Open();


        }




        void LlenarPizza()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Especialidad_Pizza FROM Pizzas", conn);
            da.Fill(ds, "Pizzas");
            cboPizzas.DataSource = ds.Tables[0].DefaultView;
            cboPizzas.ValueMember = "Especialidad_Pizza";
        }

        void LlenarPrecioPizza()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Precio FROM Pizzas", conn);
            da.Fill(ds, "Pizzas");
            cboPrecioP.DataSource = ds.Tables[0].DefaultView;
            cboPrecioP.ValueMember = "Precio";
        }

        void LlenarCantidadP()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cantidad FROM CANTIDADES", conn);
            da.Fill(ds, "CANTIDADES");
            cboCantidadPizzas.DataSource = ds.Tables[0].DefaultView;
            cboCantidadPizzas.ValueMember = "Cantidad";
        }

        void LlenarBebidas()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Bebida FROM Bebidas", conn);
            da.Fill(ds, "Bebidas");
            cboBebidas.DataSource = ds.Tables[0].DefaultView;
            cboBebidas.ValueMember = "Bebida";
        }

        void LlenarCantidadTipoBebida()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cantidad FROM CANTIDADES", conn);
            da.Fill(ds, "CANTIDADES");
            cboCantidadBebidas.DataSource = ds.Tables[0].DefaultView;
            cboCantidadBebidas.ValueMember = "Cantidad";
        }

        void LlenarPrecioBebidas()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Precio FROM Bebidas", conn);
            da.Fill(ds, "Bebidas");
            cboPrecioBebida.DataSource = ds.Tables[0].DefaultView;
            cboPrecioBebida.ValueMember = "Precio";
        }

        void LlenarPostres()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Postre FROM Postres", conn);
            da.Fill(ds, "Postres");
            cboPostres.DataSource = ds.Tables[0].DefaultView;
            cboPostres.ValueMember = "Postre";
        }

        void LlenarCantidadPostres()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cantidad FROM CANTIDADES", conn);
            da.Fill(ds, "CANTIDADES");
            cboCantidadPostres.DataSource = ds.Tables[0].DefaultView;
            cboCantidadPostres.ValueMember = "Cantidad";
        }

        void LlenarPrecioPostres()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Precio FROM Postres", conn);
            da.Fill(ds, "Postres");
            cboPrecioPostre.DataSource = ds.Tables[0].DefaultView;
            cboPrecioPostre.ValueMember = "Precio";
        }

        void SubTotalPizza()
        {
            int cantidadpizza;
            double preciopizza;
            double Totalpizza;

            try
            {
                preciopizza = Convert.ToDouble(cboPrecioP.Text);
                cantidadpizza = Convert.ToInt32(cboCantidadPizzas.Text);


                Totalpizza = cantidadpizza * preciopizza;

                ST1.Text = Convert.ToString(Totalpizza);

            }
            catch
            {

            }
        }

        void SubTotalBebida()
        {
            int cantidadbebidas;
            double preciobebida;
            double Totalbebidas;

            try
            {
                preciobebida = Convert.ToDouble(cboPrecioBebida.Text);
                cantidadbebidas = Convert.ToInt32(cboCantidadBebidas.Text);


                Totalbebidas = cantidadbebidas * preciobebida;


                ST2.Text = Convert.ToString(Totalbebidas);
            }
            catch
            {

            }

        }

        void SubTotalPostres()
        {
            int cantidadpostres;
            double preciopostres;
            double Totalpostres;

            try
            {
                preciopostres = Convert.ToDouble(cboPrecioPostre.Text);
                cantidadpostres = Convert.ToInt32(cboCantidadPostres.Text);

                Totalpostres = preciopostres * cantidadpostres;

                ST3.Text = Convert.ToString(Totalpostres);
            }
            catch
            {

            }
        }



        void CalculoTotal()
        {
            double VentaTotal;
            double SubT1;
            double SubT2;
            double SubT3;

            try
            {
                SubT1 = Convert.ToDouble(ST1.Text);
                SubT2 = Convert.ToDouble(ST2.Text);
                SubT3 = Convert.ToDouble(ST3.Text);

                VentaTotal = SubT1 + SubT2 + SubT3;
                Total.Text = Convert.ToString(VentaTotal);
            }
            catch
            {

            }



        }



        private void Form5_Load(object sender, EventArgs e)
        {



            //Metodos para llenar combo box para pizzas
            LlenarPizza();
            LlenarPrecioPizza();
            LlenarCantidadP();

            //Metodos para llenar combo box para bebidas
            LlenarBebidas();
            LlenarCantidadTipoBebida();
            LlenarPrecioBebidas();

            //Metodo para llenar combo box para postres
            LlenarPostres();
            LlenarCantidadPostres();
            LlenarPrecioPostres();




        }

        //Tercer metodo que se debra ejecutar
        void InsertarOrden()
        {
            string insertOrder;
            insertOrder = "INSERT INTO Orden(xClienteId,PedidoId,Pizza_Detalle,Bebida_Detalle,Postre_Detalle,CantidadPizza,CantidadBebida,CantidadPostre,Total_Pedido)";
            insertOrder += "VALUES(@xClienteId,@PedidoId,@Pizza_Detalle,@Bebida_Detalle,@Postre_Detalle,@CantidadPizza,@CantidadBebida,@CantidadPostre,@Total_Pedido)";
            insert1 = new SqlCommand(insertOrder, conn);


            insert1.Parameters.Add(new SqlParameter("@xClienteId", SqlDbType.Int));
            insert1.Parameters["@xClienteId"].Value = Id.Text; //Pendiente

            insert1.Parameters.Add(new SqlParameter("@PedidoId", SqlDbType.Int));
            insert1.Parameters["@PedidoId"].Value = txtPedido.Text;


            insert1.Parameters.Add(new SqlParameter("@Pizza_Detalle", SqlDbType.VarChar));
            insert1.Parameters["@Pizza_Detalle"].Value = cboPizzas.Text;

            insert1.Parameters.Add(new SqlParameter("@Bebida_Detalle", SqlDbType.VarChar));
            insert1.Parameters["@Bebida_Detalle"].Value = cboBebidas.Text;

            insert1.Parameters.Add(new SqlParameter("@Postre_Detalle", SqlDbType.VarChar));
            insert1.Parameters["@Postre_Detalle"].Value = cboPostres.Text;

            insert1.Parameters.Add(new SqlParameter("@CantidadPizza", SqlDbType.Int));
            insert1.Parameters["@CantidadPizza"].Value = cboCantidadPizzas.Text;

            insert1.Parameters.Add(new SqlParameter("@CantidadBebida", SqlDbType.Int));
            insert1.Parameters["@CantidadBebida"].Value = cboCantidadBebidas.Text;

            insert1.Parameters.Add(new SqlParameter("@CantidadPostre", SqlDbType.Int));
            insert1.Parameters["@CantidadPostre"].Value = cboCantidadPostres.Text;

            insert1.Parameters.Add(new SqlParameter("@Total_Pedido", SqlDbType.Decimal));
            insert1.Parameters["@Total_Pedido"].Value = Total.Text;

            insert1.ExecuteNonQuery();
        }



        //Metodo para encontrar la orden 
        void EncontrarOrden()
        {
            string seleccion;
            seleccion = "SELECT * FROM Orden WHERE PedidoId = '" + txtIDPedido.Text + "'";


            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("PedidoId", SqlDbType.Int);
            prm.Value = txtIDPedido.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                txtIdOrden.Text = dr1["Numero_Orden"].ToString().Trim();
            }
            dr1.Close();


        }


        void MostrarDatosCliente()
        {
            Convert.ToInt32(Id.Text);
            string seleccion;
            seleccion = "SELECT * FROM Clientes WHERE IdCliente = '" + Id.Text + "'";



            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("IdCliente", SqlDbType.Int);
            prm.Value = Id.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                //Falta asignar los datos a mostrar
                txtNombre.Text = dr1["Cliente"].ToString().Trim();
                txtTel.Text = dr1["Teléfono"].ToString().Trim();
                txtCorreo.Text = dr1["Correo_Electrónico"].ToString().Trim();
                txtDireccion.Text = dr1["Dirección"].ToString().Trim();
            }
            dr1.Close();
        }



        //Primer metodo que se ejecutara dentro del label link 1
        void InsertarPedido()
        {
            string insertPedido;
            insertPedido = "INSERT INTO Pedidos(IdCli,Pizza_Detalle,Bebida_Detalle,Postre_Detalle,CantidadPizza,CantidadBebida,CantidadPostre)";
            insertPedido += "VALUES (@IdCli,@Pizza_Detalle,@Bebida_Detalle,@Postre_Detalle,@CantidadPizza,@CantidadBebida,@CantidadPostre)";
            insert1 = new SqlCommand(insertPedido, conn);




            insert1.Parameters.Add(new SqlParameter("@IdCli", SqlDbType.VarChar));
            insert1.Parameters["@IdCli"].Value = Id.Text; //Pendiente

            insert1.Parameters.Add(new SqlParameter("@Pizza_Detalle", SqlDbType.VarChar));
            insert1.Parameters["@Pizza_Detalle"].Value = cboPizzas.Text;

            insert1.Parameters.Add(new SqlParameter("@Bebida_Detalle", SqlDbType.VarChar));
            insert1.Parameters["@Bebida_Detalle"].Value = cboBebidas.Text;

            insert1.Parameters.Add(new SqlParameter("@Postre_Detalle", SqlDbType.VarChar));
            insert1.Parameters["@Postre_Detalle"].Value = cboPostres.Text;

            insert1.Parameters.Add(new SqlParameter("@CantidadPizza", SqlDbType.Int));
            insert1.Parameters["@CantidadPizza"].Value = cboCantidadPizzas.Text;

            insert1.Parameters.Add(new SqlParameter("@CantidadBebida", SqlDbType.Int));
            insert1.Parameters["@CantidadBebida"].Value = cboCantidadBebidas.Text;

            insert1.Parameters.Add(new SqlParameter("@CantidadPostre", SqlDbType.Int));
            insert1.Parameters["@CantidadPostre"].Value = cboCantidadPostres.Text;


            insert1.ExecuteNonQuery();

            MessageBox.Show("¡Pedido ingresado con éxito!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        //Segundo metodo que se ejecutara
        void RealizarPago()
        {
            string insertPago;
            insertPago = "INSERT INTO PAGO(ClienteId,OrdenId,Num_Tarjeta,CVC)";
            insertPago += "VALUES(@ClienteId,@OrdenId,@Num_Tarjeta,@CVC)";
            insert1 = new SqlCommand(insertPago, conn);



            insert1.Parameters.Add(new SqlParameter("@ClienteId", SqlDbType.Int));
            insert1.Parameters["@ClienteId"].Value = Id.Text;

            insert1.Parameters.Add(new SqlParameter("@OrdenId", SqlDbType.Int));
            insert1.Parameters["@OrdenId"].Value = txtIdOrden.Text;


            insert1.Parameters.Add(new SqlParameter("@Num_Tarjeta", SqlDbType.VarChar));
            insert1.Parameters["@Num_Tarjeta"].Value = txtNumTarjeta.Text;

            insert1.Parameters.Add(new SqlParameter("@CVC", SqlDbType.VarChar));
            insert1.Parameters["@CVC"].Value = txtCVC.Text;

            insert1.ExecuteNonQuery();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cboCantidadPizzas.Text == "0")
            {
                MessageBox.Show("¡Seleccione una cantidad de pizzas!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (cboCantidadBebidas.Text == "0")
            {
                MessageBox.Show("¡Seleccione una cantidad de bebidas!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (cboBebidas.Text == "Ninguna" || cboPostres.Text == "Ninguno" && cboCantidadPostres.Text == "0")
            {
                SubTotalPizza();
                SubTotalBebida();
                SubTotalPostres();
                CalculoTotal();
                MessageBox.Show("¡Pedido calculado!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInsertarPedidos.Visible = true;
            }

           

            else if (cboCantidadPostres.Text == "0")
            {
                MessageBox.Show("¡Seleccione una cantidad de postres!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
           

            else
            {
                SubTotalPizza();
                SubTotalBebida();
                SubTotalPostres();
                CalculoTotal();
                MessageBox.Show("¡Pedido calculado!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInsertarPedidos.Visible = true;
            }

        }


        void EncontrarPedido()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pedidos WHERE IdCli = '" + Id.Text + "'", conn);
            da.Fill(ds, "Pedidos");
            dataGridView1.DataSource = ds.Tables["Pedidos"];

        }


        void VerOrdenes()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Orden WHERE xClienteId = '" + Id.Text + "'", conn);
            da.Fill(ds, "Orden");
            dataGridView2.DataSource = ds.Tables["Orden"];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RepositorioMetodos metodos = new RepositorioMetodos();

            metodos.IngresoPedido();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RepositorioMetodos metodos = new RepositorioMetodos();


            metodos.ModificacionPedido();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RepositorioMetodos metodos = new RepositorioMetodos();
            metodos.EliminarPedido();
        }

        private void cboPostres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion;
            seleccion = "SELECT * FROM Postres WHERE Postre ='" + cboPostres.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("Postre", SqlDbType.VarChar);
            prm.Value = cboPostres.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {

                cboPrecioPostre.Text = dr1["Precio"].ToString().Trim();
                ItemPostre.Text = dr1["Id_Postre"].ToString().Trim();
            }
            dr1.Close();
        }

        private void cboBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion;
            seleccion = "SELECT * FROM Bebidas WHERE Bebida ='" + cboBebidas.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("Bebida", SqlDbType.VarChar);
            prm.Value = cboBebidas.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {

                cboPrecioBebida.Text = dr1["Precio"].ToString().Trim();
                ItemBebida.Text = dr1["Id_Bebida"].ToString().Trim();

            }
            dr1.Close();
        }

        private void cboPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion;
            seleccion = "SELECT * FROM Pizzas WHERE Especialidad_Pizza ='" + cboPizzas.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("Especialidad_Pizza", SqlDbType.VarChar);
            prm.Value = cboPizzas.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {

                cboPrecioP.Text = dr1["Precio"].ToString().Trim();
                ItemPizza.Text = dr1["Id_Especialidad"].ToString().Trim();

            }
            dr1.Close();

        }





        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Falta verificar que se pueda completar la orden
        //Establecer que el button mueste el numero de la orden
        private void Btn_EnviarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdOrden.Text is null)
                {
                }
                else
                {
                    InsertarOrden();
                    label31.Visible = true;
                    txtIdOrden.Visible = true;
                    EncontrarOrden();
                    RealizarPago();
                    btn_VerPedido.Visible = true;
                    Btn_EnviarOrden.Visible = false;



                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lblInsertarPedidos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InsertarPedido();

            BuscarPedido();

        }

        void BuscarPedido()
        {
            string seleccion;
            seleccion = "SELECT * FROM Pedidos WHERE IdCli ='" + Id.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("IdCli", SqlDbType.VarChar);
            prm.Value = Id.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {

                txtPedido.Text = dr1["IdPedido"].ToString().Trim();
            }
            dr1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(Id.Text);
            Id.Enabled = false;

            linkLabel1.Visible = true;
            btn_VerPedido.Visible = true;
            MostrarDatosCliente();

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPedido.Text != txtIDPedido.Text)
            {
                MessageBox.Show("El Id del pedido no es válido", "PIZZA TUBRBO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Convert.ToInt32(txtIDPedido.Text);
                txtIDPedido.Enabled = false;
                Btn_EnviarOrden.Visible = true;
            }
        }

        void Deshabilitar()
        {
            label7.Visible = false;
            label10.Visible = false;
            label13.Visible = false;
            ST1.Visible = false;
            ST2.Visible = false;
            ST3.Visible = false;
            linkLabel1.Visible = false;
            lblInsertarPedidos.Visible = false;
        }

        private void btn_VerPedido_Click(object sender, EventArgs e)
        {
            EncontrarPedido();
            Deshabilitar();

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_VerOrdenes_Click(object sender, EventArgs e)
        {
            VerOrdenes();
        }
    }

}







