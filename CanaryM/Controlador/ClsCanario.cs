using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanaryM.Datos;

namespace CanaryM.Controlador
{
    class ClsCanario
    {
        ClsConexion objconexion = new ClsConexion();
        public Boolean insertar(string nombre, string descripcion)
        {
            objconexion.conectar();      
            string consulta="insert into canario(nombre,descripcion) values('"+nombre+"','"+descripcion+"')";
            return objconexion.ejecutarquery(consulta);
        }
        public Boolean eliminar(int id)
        {
            objconexion.conectar();
            string consultaa = "delete from color where id_canario=" + id;
            if (objconexion.ejecutarquery(consultaa))
            {
                string consultab = "delete from canario where id=" + id;
                return objconexion.ejecutarquery(consultab);
            }
            else
            { return false; }
        }
        public Boolean actualizar(int id,string nombre, string descripcion)
        {
            objconexion.conectar();
            string consulta = "update canario set nombre='" + nombre + "', descripcion='" + descripcion + "' where id="+id;
            return objconexion.ejecutarquery(consulta);
        }
        public System.Data.DataSet llenardatagrid(string bus)
        {
            objconexion.conectar();

            string consulta = "select * from canario where nombre like '%" + bus + "%'";

            return objconexion.llenardg(consulta, "canario");
        }

    }
}
