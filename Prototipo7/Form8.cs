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
	public partial class Form8 : Form
	{

        private SqlConnection conn;
        private SqlCommand insert1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        private string sCn;



        OleDbConnection cnn = new OleDbConnection();



        public Form8()
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
            if (txtUsuario.Text == "" || txtContraseña1.Text == "" || txtContraseña2.Text == "")
            {
                MessageBox.Show("¡Verifique que los campos no esten vacios!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        void ComparacionContraseña()
        {
            if (txtContraseña1.Text != txtContraseña2.Text)
            {
                MessageBox.Show("¡Verifique que la contraseña coincida!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //Vamos a crear metodo para poder realizar el cambio de la contrañsea de un usuario
        void CambioContraseña()
        {

            //Consulta queda pendiente 
            string ChangePassword;
            ChangePassword = $"UPDATE Users SET Contraseña = '{txtContraseña2.Text}' WHERE Usuario = '{txtUsuario.Text}'" ;
            insert1 = new SqlCommand(ChangePassword, conn);
            insert1.ExecuteNonQuery();

            MessageBox.Show("Contraseña reestablecida con exito!", "Pizza Turbo", MessageBoxButtons.OK,MessageBoxIcon.Information);

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }


        private void btnRestablecer_Click(object sender, EventArgs e)
        {

            if (txtContraseña2.Text == "" || txtContraseña1.Text == "" || txtUsuario.Text == "")
            {
                ErrorCamposVacios();
                ComparacionContraseña();
            }

            string Validando;

            string usuario;


            Validando = $"SELECT * FROM Users WHERE Usuario = '{txtUsuario.Text}'";
            SqlDataAdapter sdu = new SqlDataAdapter(Validando, conn);

            DataTable dtable = new DataTable();
            sdu.Fill(dtable);


            if (dtable.Rows.Count > 0)
            {
                usuario = txtUsuario.Text;
                cnn.Close();


                if (usuario == txtUsuario.Text)
                {
                    CambioContraseña();
                }

            }
            else
            {
                MessageBox.Show("¡El usuario no existe!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
