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
	public partial class Form1 : Form
	{
        private SqlConnection conn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        private string sCn;
        OleDbConnection cnn = new OleDbConnection();

        public Form1()
		{
			InitializeComponent();
            cnn.ConnectionString = @"PROVIDER=SQLOLEDB;Server=DESKTOP-BNC8SKO\SQLEXPRESS;Database=BD_PIZZERIA_TURBO;Uid=sa;Pwd=12345";

            Conexion cn1 = new Conexion();
            cn1.conec();
            sCn = cn1.cadena;
            conn = new SqlConnection(sCn);
            conn.Open();

            customizeDesing();
		}
		private void customizeDesing()
		{
			PanelmenuSubMenu.Visible = false;
			PanelregistroSubMenu.Visible = false;
			//panelayuda.Visible = false;

		}
		private void HideSubMenu()
		{
			if (PanelmenuSubMenu.Visible == true)
				PanelmenuSubMenu.Visible = false;
			if (PanelregistroSubMenu.Visible == true)
				PanelregistroSubMenu.Visible = false;
			//if (panelayuda.Visible == true)
			//	panelayuda.Visible = false;

		}

		private void ShowSubMenu(Panel subMenu)
		{
			if (!subMenu.Visible)
			{
				HideSubMenu();
				subMenu.Visible = true;
			}
			else
			{
				subMenu.Visible = false;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

            string seleccion;
            seleccion = "SELECT * FROM Users WHERE  Usuario='" + txtUser.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn);
            SqlParameter prm = new SqlParameter("Usuario", SqlDbType.VarChar);
            prm.Value = txtUser.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
              IdCliente.Text = dr1["XCli"].ToString().Trim();
            }
            dr1.Close();


        }

		private void Desplegar_Click(object sender, EventArgs e)
		{
			ShowSubMenu(PanelmenuSubMenu);
		}

		private void Menu_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Form4());
			HideSubMenu();
		}
		private Form activeForm = null;
		private void OpenChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();



		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShowSubMenu(PanelregistroSubMenu);
		}

		private void Promociones_Click(object sender, EventArgs e)
		{

			OpenChildForm(new Form6());
			HideSubMenu();
		}

		private void Entradas_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Form7());
			HideSubMenu();
		}

		

        private void button5_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Form10());
			HideSubMenu();
		}

		private void button4_Click(object sender, EventArgs e)
		{

			OpenChildForm(new Form3());
			HideSubMenu();
		}

		//private void button2_Click(object sender, EventArgs e)
		//{
		//	ShowSubMenu(panelayuda);
	
		//}

		private void button6_Click(object sender, EventArgs e)
		{
			

			OpenChildForm(new Form8());
			HideSubMenu();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void PanelregistroSubMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelayuda_Paint(object sender, PaintEventArgs e)
		{

		}

        private void btnAyuda_Click(object sender, EventArgs e)
        {

            

        }
    }
}
