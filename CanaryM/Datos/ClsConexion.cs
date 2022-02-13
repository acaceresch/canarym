using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanaryM.Datos
{
    class ClsConexion
    {
        public string strCon = "";
        public SqlConnection con;
        public SqlCommand xcmd;
        public void conectar()
        {
            try
            {
                strCon = "Data Source=ANTHONY-PC;";
                //strCon = "Data Source=(local);";
                strCon += "Initial Catalog=canaryDB;User ID=anthonycontrol;Password=shania";
                //strCon += "Integrated Security = SSPI; Initial Catalog = empresaDB";
                //strCon = "Server = tcp:anthonycc.database.windows.net,1433; Initial Catalog = canaryDB; Persist Security Info = False; User ID = anthonycontrol; Password =shaniadina1A; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";

                con = new SqlConnection(strCon);
                con.Open();
            }
            catch (Exception ex)
            { }
        }
        public int contar(string consulta)
        {
            try
            {
                xcmd = new SqlCommand();
                xcmd.Connection = con;
                xcmd.CommandText = consulta;
                int rpta = Convert.ToInt32(xcmd.ExecuteScalar());

                return rpta;
            }
            catch (Exception ex)
            { return 0; }

        }
        public System.Data.DataSet llenardg(string consulta, string tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, tabla);
                return ds;
            }
            catch (Exception ex)
            { return null; }

        }
        public System.Data.DataTable llenarcombo(string consulta, string tabla)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                System.Data.DataTable dt = new System.Data.DataTable(tabla);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            { return null; }

        }
        public Boolean insertarcolor(string nombre, Byte[] imagen, int idcanario)
        {
            //int letra,string referencia,Byte[] imagen,int peso
            try
            {

                //// SqlConnection con = new SqlConnection("Data Source=ANTHONY-PC;Initial Catalog=empresaDB;User ID=sa;Password=shania");
                SqlConnection xcon = new SqlConnection("Data Source=(local);Integrated Security = SSPI; Initial Catalog = canaryDB");
                //SqlConnection xcon = new SqlConnection("Server = tcp:anthonycc.database.windows.net,1433; Initial Catalog = canaryDB; Persist Security Info = False; User ID = anthonycontrol; Password = shaniadina1A; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");

                SqlCommand com = new SqlCommand("insert into color(nombre,imagen,id_canario) values(@nombre,@pic,@canario)", xcon);


                com.Parameters.AddWithValue("@Pic", imagen);
                com.Parameters.AddWithValue("@nombre", nombre);
                com.Parameters.AddWithValue("@canario", idcanario);
           
                xcon.Open();
                //Ejecuta una instrucción SQL en la conexión y devuelve el número de filas afectadas.
                com.ExecuteNonQuery();
                xcon.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean actualizarvariante(int id,string nombre, Byte[] imagen, int idcanario, Boolean bu)
        {
            //int letra,string referencia,Byte[] imagen,int peso
            try
            {
                if (bu)
                {
                    ////SqlConnection con = new SqlConnection("Data Source=ANTHONY-PC;Initial Catalog=empresaDB;User ID=sa;Password=shania");
                    SqlConnection xcon = new SqlConnection("Data Source=(local);Integrated Security = SSPI; Initial Catalog = canaryDB");
                    //SqlConnection xcon = new SqlConnection("Server = tcp:anthonycc.database.windows.net,1433; Initial Catalog = canaryDB; Persist Security Info = False; User ID = anthonycontrol; Password = shaniadina1A; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");

                    SqlCommand com = new SqlCommand("update color set nombre=@nombre, imagen=@pic where id=@id", xcon);
                    //update cultivo set estado = 'DESACTIVADO' where id =
                    com.Parameters.AddWithValue("@nombre", nombre);
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@Pic", imagen);
                    
                   
                    xcon.Open();
                    //Ejecuta una instrucción SQL en la conexión y devuelve el número de filas afectadas.
                    com.ExecuteNonQuery();
                    xcon.Close();
                    return true;
                }
                else
                {
                    SqlConnection xcon = new SqlConnection("Data Source=(local);Integrated Security = SSPI; Initial Catalog = canaryDB");

                    ////SqlConnection con = new SqlConnection("Data Source=ANTHONY-PC;Initial Catalog=empresaDB;User ID=sa;Password=shania");
                    //SqlConnection xcon = new SqlConnection("Server = tcp:anthonycc.database.windows.net,1433; Initial Catalog = canaryDB; Persist Security Info = False; User ID = anthonycontrol; Password = shaniadina1A; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");
                    SqlCommand com = new SqlCommand("update color set nombre = @nombre where id = @id", xcon);
                    //update cultivo set estado = 'DESACTIVADO' where id =
                    com.Parameters.AddWithValue("@nombre", nombre);
                    com.Parameters.AddWithValue("@id", id);
                    
                    xcon.Open();
                    //Ejecuta una instrucción SQL en la conexión y devuelve el número de filas afectadas.
                    com.ExecuteNonQuery();
                    xcon.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean ejecutarquery(string consulta)
        {
            try
            {
                xcmd = new SqlCommand();
                xcmd.Connection = con;
                xcmd.CommandText = consulta;
                xcmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            { return false; }

        }
        public Byte[] getimagen(int id)
        {
            //SqlConnection connect = new SqlConnection("Data Source=ANTHONY-PC;Initial Catalog=basedetagavos;User ID=sa;Password=shania");
            SqlCommand command = new SqlCommand("select imagen from color where id= @Clave", con);
            command.Parameters.AddWithValue("@Clave", id);

            //Representa un set de comandos que es utilizado para llenar un DataSet
            SqlDataAdapter dp = new SqlDataAdapter(command);
            //Representa un caché (un espacio) en memoria de los datos.
            DataSet ds = new DataSet("color");

            //Arreglo de byte en donde se almacenara la foto en bytes
            byte[] MyData = new byte[0];

            //Llenamosel DataSet con la tabla. cliente es nombre de la tabla
            dp.Fill(ds, "color");
            //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
            DataRow myRow = ds.Tables["color"].Rows[0];

            //Se almacena el campo foto de la tabla en el arreglo de bytes
            MyData = (byte[])myRow["imagen"];
            return MyData;
        }
    }
}
