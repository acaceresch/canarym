using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanaryM.Controlador;

namespace CanaryM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsCanario objcanario = new ClsCanario();
        ClsColor objcolor = new ClsColor();
        byte[] img1;
        byte[] img2;
        private void btninsertarcanario_Click(object sender, EventArgs e)
        {
            if (objcanario.insertar(txtnombrecanario.Text,txtdescripcion.Text))
            {
                MessageBox.Show("Canario Registrado", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiar();
            }
        }

        private void btneliminarcanario_Click(object sender, EventArgs e)
        {
            if (objcanario.eliminar(Convert.ToInt32(txtidcanario.Text)))
            {
                MessageBox.Show("Canario Eliminado", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiar();
            }
        }

        private void btnactualizarcanario_Click(object sender, EventArgs e)
        {
            if (objcanario.actualizar(Convert.ToInt32(txtidcanario.Text),txtnombrecanario.Text,txtdescripcion.Text))
            {
                MessageBox.Show("Canario Actualizado", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           dgvcanario .DataSource = objcanario.llenardatagrid(txtbuscarcanario.Text);
            dgvcanario.DataMember = "canario";

            txtidcanario.Text = "";
            txtbuscarcanario.Text = "";
            txtdescripcion.Text = "";
        }
        public void llenarcolor(int canario)
        {
            dgvcolor.DataSource = objcolor.llenardatagrid(canario);
            dgvcolor.DataMember = "color";
            
            txtidcolor.Text = "";
            imagen.Image = null;
            
        }

        private void dgvcanario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcanario.Text = dgvcanario.SelectedRows[0].Cells[0].Value.ToString();
            txtnombrecanario.Text = dgvcanario.SelectedRows[0].Cells[1].Value.ToString();
            
           
            txtdescripcion.Text = dgvcanario.SelectedRows[0].Cells[2].Value.ToString();

            //llamar a llenar dgvcolor
            llenarcolor(Convert.ToInt32( txtidcanario.Text));
            groupBox4.Visible = true;
            limpiarcolor();
            //txtsignificado.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //imagen.Image = obj.ByteToImage(obj.regresarimagen(Convert.ToInt32(txtid.Text)));
            //img2 = obj.regresarimagen(Convert.ToInt32(txtid.Text));
            btninsertarcanario.Visible = false;
            btnactualizarcanario.Visible = true;
            btneliminarcanario.Visible = true;
        }

        private void btnlimpiarcanario_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiarcolor();
            dgvcolor.DataSource = null;
            
        }
        public void limpiar()
        {
            txtidcanario.Text = "";
            txtbuscarcanario.Text = "";
            txtdescripcion.Text = "";
            txtnombrecanario.Text = "";
            
            btninsertarcanario.Visible = true;
            btnactualizarcanario.Visible = false;
            btneliminarcanario.Visible = false;
            //imagen.Image = null;
            dgvcanario.DataSource = null;
            groupBox4.Visible = false;

        }
        public void limpiarcolor()
        {
            txtidcolor.Text = "";
            txtnombrecolor.Text = "";
            
            imagen.Image = null;

            btinsertarcolor.Visible = true;
            btactualizarcolor.Visible = false;
            bteliminarcolor.Visible = false;
            img1 = null;
            //dgvcanario.DataSource = null;

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                //localhost.Service1 lo = new localhost.Service1();

                //label2.Text = lo.algoritmo(,);

                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Abrir archivo";
                open.Filter = "Jpg files (*.jpg)|*.jpg|Jpeg files (*.jpeg)|*.jpeg|Gif files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string strfilename = open.FileName;
                    Bitmap Picture = new Bitmap(strfilename);
                    img1 = objcolor.imageToByteArray((System.Drawing.Image)Picture);
                    imagen.Image = (System.Drawing.Image)Picture;
                    String NombreImg = open.SafeFileName;

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btinsertarcolor_Click(object sender, EventArgs e)
        {
            
            if (objcolor.insertar(txtnombrecolor.Text, img1, Convert.ToInt32(txtidcanario.Text)))
            {
                MessageBox.Show("Color de Canario ingresado", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //limpiar();
                limpiarcolor();
                llenarcolor(Convert.ToInt32(txtidcanario.Text));
            }
            
        }

        private void bteliminarcolor_Click(object sender, EventArgs e)
        {
            if (objcolor.eliminar(Convert.ToInt32(txtidcolor.Text)))
            {
                MessageBox.Show("Color Eliminado", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiarcolor();
                llenarcolor(Convert.ToInt32(txtidcanario.Text));
            }
        }

        private void btactualizarcolor_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {

                if (objcolor.actualizar(Convert.ToInt32(txtidcolor.Text), txtnombrecolor.Text, img1, Convert.ToInt32(txtidcanario.Text), true))
                {
                    MessageBox.Show("Variante modificada", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpiarcolor();
                    llenarcolor(Convert.ToInt32(txtidcanario.Text));
                }
            }
            else
            {
                if (objcolor.actualizar(Convert.ToInt32(txtidcolor.Text), txtnombrecolor.Text, img1, Convert.ToInt32(txtidcanario.Text), false))
                {
                    MessageBox.Show("Variante modificada", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpiarcolor();
                    llenarcolor(Convert.ToInt32(txtidcanario.Text));
                }
            }
        }

        private void dgvcolor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidcolor.Text = dgvcolor.SelectedRows[0].Cells[0].Value.ToString();
            txtnombrecolor.Text = dgvcolor.SelectedRows[0].Cells[1].Value.ToString();
            //
            
            //
            imagen.Image = objcolor.ByteToImage(objcolor.regresarimagen(Convert.ToInt32(txtidcolor.Text)));
            img2 = objcolor.regresarimagen(Convert.ToInt32(txtidcolor.Text));
            btinsertarcolor.Visible = false;
            btactualizarcolor.Visible = true;
            bteliminarcolor.Visible = true;
        }

        private void btlimpiarcolor_Click(object sender, EventArgs e)
        {
            limpiarcolor();
        }
    }
}
