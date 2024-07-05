using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Prototipo7
{
    public partial class Form3 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        private string sCn;



        OleDbConnection cnn = new OleDbConnection();
        public Form3()
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

        void ErrorCamposVacios()
        {
            if (txtCliente.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("¡Verifique que los campos no esten vacios!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }



        void CrearCliente()
        {
            string insertCliente;
            insertCliente = "INSERT INTO Clientes (Cliente,Teléfono,Correo_Electrónico,Dirección)";
            insertCliente += "VALUES(@Cliente,@Teléfono,@Correo_Electrónico,@Dirección)";
            insert1 = new SqlCommand(insertCliente, conn);



            insert1.Parameters.Add(new SqlParameter("@Cliente", SqlDbType.VarChar));
            insert1.Parameters["@Cliente"].Value = txtCliente.Text;

            insert1.Parameters.Add(new SqlParameter("@Teléfono", SqlDbType.VarChar));
            insert1.Parameters["@Teléfono"].Value = txtTelefono.Text;


            insert1.Parameters.Add(new SqlParameter("@Correo_Electrónico", SqlDbType.VarChar));
            insert1.Parameters["@Correo_Electrónico"].Value = txtCorreo.Text;

            insert1.Parameters.Add(new SqlParameter("@Dirección", SqlDbType.VarChar));
            insert1.Parameters["@Dirección"].Value = txtDireccion.Text;

            insert1.ExecuteNonQuery();

        }

        void BuscarIdUsuario()
        {
            string seleccion;
            seleccion = "SELECT * FROM Clientes WHERE Cliente ='" + txtCliente.Text + "'";


            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("Cliente", SqlDbType.VarChar);
            prm.Value = txtCliente.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                lblIdCli.Text = dr1["IdCliente"].ToString().Trim();
            }
            dr1.Close();

            Convert.ToInt32(lblIdCli.Text);

            label9.Visible = true;
            label6.Visible = true;

            txtUsuario.Visible = true;
            txtContraseña1.Visible = true;

        }






        void CrearUsuario()
        {
            string insertUsuario;
            insertUsuario = "INSERT INTO Users (Usuario,Contraseña,XCli)";
            insertUsuario += "VALUES(@Usuario,@Contraseña,@XCli)";
            insert1 = new SqlCommand(insertUsuario, conn);



            insert1.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar));
            insert1.Parameters["@Usuario"].Value = txtUsuario.Text;

            insert1.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
            insert1.Parameters["@Contraseña"].Value = txtContraseña1.Text;

            insert1.Parameters.Add(new SqlParameter("@XCli", SqlDbType.Int));
            insert1.Parameters["@XCli"].Value = lblIdCli.Text;

            MessageBox.Show("¡Usuario agregado con éxito!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            insert1.ExecuteNonQuery();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ErrorCamposVacios();

            CrearCliente();
            BuscarIdUsuario();

            label8.Visible = true;

            label2.Visible = true;

            btnRegistrar.Visible = false;
            btn_AgregarUser.Visible = true;









        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {




            if (txtContraseña1.Text == "")
            {

                MessageBox.Show("Escriba la contraseña", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                CrearUsuario();
                Form2 f2 = new Form2();
                f2.ShowDialog();

                this.Hide();
            }



        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private const int MaxLength = 8; // Máximo de caracteres permitidos

             

        

        private void txtTelefono_MouseLeave(object sender, EventArgs e)
        {

            // Obtener el TextBox actual
            TextBox textBox = (TextBox)sender;

            // Verificar si la tecla presionada excede el límite de caracteres
            if (textBox.Text.Length > MaxLength)
            {
                MessageBox.Show("No debe exceder de más de 8 carácteres", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Visible = false;
                txtDireccion.Visible = false;
            }
            else if (textBox.Text.Length == MaxLength)
            {
                txtCorreo.Visible = true;
                txtDireccion.Visible = true;
            }
        }
    }
    }

