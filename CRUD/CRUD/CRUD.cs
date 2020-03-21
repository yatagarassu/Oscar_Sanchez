using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
            grid();
        }

        private void grid() //Funcion para abrir mi base de datos
        {

            string cadcon = "workstation id=ParcialOscar.mssql.somee.com;packet size=4096;user id=laxeous_SQLLogin_1;pwd=57cl9aahy6;data source=ParcialOscar.mssql.somee.com;persist security info=False;initial catalog=ParcialOscar";
            SqlConnection conexion = new SqlConnection(cadcon);
            conexion.Open();
            //Configurar la consulta
            string consulta = "SELECT * FROM [Alumnos]";
            SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
            DataTable t = new DataTable();
            da.Fill(t);
            //Mostrar los datos en el grid
            dataGridView1.DataSource = t;
            // dataGridView1.DataBind();
        }

        
    }
}

