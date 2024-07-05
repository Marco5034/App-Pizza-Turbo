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
    public partial class Form2 : Form
    {

        //Crear nueva conexion

        private SqlConnection conn;
        private SqlCommand insert1;
        private SqlDataReader dr1;

        private string sCn;


        OleDbConnection cnn = new OleDbConnection();


        public Form2()
        {
            InitializeComponent();
            cnn.ConnectionString = @"PROVIDER=SQLOLEDB;Server=DESKTOP-BNC8SKO\SQLEXPRESS;Database=BD_PIZZERIA_TURBO;Uid=sa;Pwd=12345";

            Conexion cn1 = new Conexion();
            cn1.conec();
            sCn = cn1.cadena;
            conn = new SqlConnection(sCn);
             conn.Open();
        }

        void ErrorCamposVacios()
        {
            if (txtCorreo.Text == "" && txtConstraseña.Text == "" || txtCorreo.Text == "" || txtConstraseña.Text == "")
            {
                MessageBox.Show("¡Verifique que los campos no esten vacios!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario, password;

            if (txtCorreo.Text == "" || txtConstraseña.Text == "")
            {
                ErrorCamposVacios();
            }
            else
            {
                string Validando;

                Validando = $"SELECT * FROM Users WHERE Usuario = '{txtCorreo.Text}' AND Contraseña = '{txtConstraseña.Text}'";
                SqlDataAdapter sdu = new SqlDataAdapter(Validando, conn);

                DataTable dtable = new DataTable();
                sdu.Fill(dtable);


                if (dtable.Rows.Count > 0)
                {
                    usuario = txtCorreo.Text;
                    password = txtConstraseña.Text;


                    cnn.Close();

                    if (usuario == txtCorreo.Text && password == txtConstraseña.Text)
                    {
                        MessageBox.Show("¡Bienvenido a Pizza Turbo!", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Hide();
                        Form1 f1 = new Form1();
                        f1.txtUser.Text = txtCorreo.Text;
                        f1.ShowDialog();


                    }
                }
                else 
                {
                    MessageBox.Show("¡Usuario o contraseña incorrectos! o el usuario no existe", "Pizza Turbo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                


            }






        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void lblContraseñaNueva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
