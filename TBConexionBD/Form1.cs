using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TBConexionBD
{
    public partial class Form1 : Form
    {
        static string pointconnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Proyectos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(pointconnection);
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            connection.Open();
            MessageBox.Show("se ha conectado correctamente a: " + connection.Database + "ha sido exitoso");
        }

        private void Btn_disconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            MessageBox.Show("Se ha desconectado correctamente");
        }

        private void Btn_query_Click(object sender, EventArgs e)
        {
            if (txt_query.Text == "")
            {
                string query = "Select * from Personas";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                datagr_query.DataSource = table;
            }
            else
            {
                string query = "Select * from Personas wheere Pais = '" + txt_query.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                datagr_query.DataSource = table;
            }
        }
        public void query()
        {
            string query = "Select * from Personas";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            datagr_query.DataSource = table;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string chain = "Insert into Personas ([Nombre], [Edad], [Pais], [NID]) " +
            "values('" + txt_name.Text + "','" + txt_age.Text + "','" + txt_country.Text + "','" + txt_NID.Text + "')";
            SqlCommand command = new SqlCommand(chain, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("La persona :" + txt_name.Text + " se ha agregado correctamente");


            txt_name.Text = "";
            txt_age.Text = "";
            txt_country.Text = "";
            txt_NID.Text = "";

            query();

            MessageBox.Show("Ningún campo debe estar vacio");
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string chain = "Delete from Personas where Nombre = '" + txt_name.Text + "'";
            SqlCommand command = new SqlCommand(chain, connection);
            flag = command.ExecuteNonQuery(); // Sie es positivo la respuesta va a ser un 1 || si es negativo = 0

            if (flag == 1)
            {
                MessageBox.Show("Se realizó el delete correctamente");
            }
            else
            {
                MessageBox.Show("No se puede borrar");
            }
            txt_name.Text = "";
            query();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string chain = "Update Personas set Nombre = '"+txt_name.Text+"', Edad = '"+txt_age.Text+"', Pais = '"+txt_country.Text+"', NID = '"+txt_NID.Text+"' Where Nombre = '"+txt_name_update.Text+"' ";
            SqlCommand command = new SqlCommand(chain, connection);
            flag = command.ExecuteNonQuery(); // Sie es positivo la respuesta va a ser un 1 || si es negativo = 0

            if (flag == 1)
            {
                MessageBox.Show("Se realizó la actualización correctamente");
            }
            else
            {
                MessageBox.Show("No existe la persona");
            }
            
            txt_name.Text = "";
            txt_age.Text = "";
            txt_country.Text = "";
            txt_NID.Text = "";

            query();
        }
    }
}
