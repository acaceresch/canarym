using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanaryM.Datos;

namespace CanaryM.Controlador
{
    class ClsColor
    {
        ClsConexion objconexion = new ClsConexion();
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Boolean insertar(string nombre, Byte[] imagen, int idcanario)
        {
            //objconexion.conectar();
            return objconexion.insertarcolor(nombre,imagen,idcanario);
        }
        public Boolean eliminar(int id)
        {
            objconexion.conectar();
            string consultaa = "delete from color where id=" + id;
            return objconexion.ejecutarquery(consultaa);
           
        }
        public Boolean actualizar(int id,string nombre, Byte[] imagen, int idcanario, Boolean bu)
        {
            if (bu)
            {
                return objconexion.actualizarvariante(id, nombre,imagen,idcanario, true);
            }
            else
            {
                return objconexion.actualizarvariante(id, nombre, imagen, idcanario, false);

            }
        }
        public System.Data.DataSet llenardatagrid(int id)
        {
            objconexion.conectar();

            string consulta = "select * from color where id_canario=" + id;

            return objconexion.llenardg(consulta, "color");
        }
        public Byte[] regresarimagen(int id)
        {
            return objconexion.getimagen(id);
        }
        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
