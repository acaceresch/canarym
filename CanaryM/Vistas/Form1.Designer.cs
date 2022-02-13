namespace CanaryM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvcanario = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbuscarcanario = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiarcanario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombrecanario = new System.Windows.Forms.TextBox();
            this.btninsertarcanario = new System.Windows.Forms.Button();
            this.btneliminarcanario = new System.Windows.Forms.Button();
            this.txtidcanario = new System.Windows.Forms.TextBox();
            this.btnactualizarcanario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvcolor = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btlimpiarcolor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombrecolor = new System.Windows.Forms.TextBox();
            this.btinsertarcolor = new System.Windows.Forms.Button();
            this.bteliminarcolor = new System.Windows.Forms.Button();
            this.txtidcolor = new System.Windows.Forms.TextBox();
            this.btactualizarcolor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcanario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolor)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(818, 219);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Canario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvcanario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtbuscarcanario);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(358, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 180);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // dgvcanario
            // 
            this.dgvcanario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcanario.Location = new System.Drawing.Point(20, 52);
            this.dgvcanario.Name = "dgvcanario";
            this.dgvcanario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcanario.Size = new System.Drawing.Size(408, 113);
            this.dgvcanario.TabIndex = 14;
            this.dgvcanario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcanario_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Buscar:";
            // 
            // txtbuscarcanario
            // 
            this.txtbuscarcanario.Location = new System.Drawing.Point(69, 26);
            this.txtbuscarcanario.Name = "txtbuscarcanario";
            this.txtbuscarcanario.Size = new System.Drawing.Size(100, 20);
            this.txtbuscarcanario.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(175, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiarcanario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtnombrecanario);
            this.groupBox1.Controls.Add(this.btninsertarcanario);
            this.groupBox1.Controls.Add(this.btneliminarcanario);
            this.groupBox1.Controls.Add(this.txtidcanario);
            this.groupBox1.Controls.Add(this.btnactualizarcanario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 180);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnlimpiarcanario
            // 
            this.btnlimpiarcanario.Location = new System.Drawing.Point(251, 142);
            this.btnlimpiarcanario.Name = "btnlimpiarcanario";
            this.btnlimpiarcanario.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiarcanario.TabIndex = 23;
            this.btnlimpiarcanario.Text = "Limpiar";
            this.btnlimpiarcanario.UseVisualStyleBackColor = true;
            this.btnlimpiarcanario.Click += new System.EventHandler(this.btnlimpiarcanario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(117, 82);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 4;
            // 
            // txtnombrecanario
            // 
            this.txtnombrecanario.Location = new System.Drawing.Point(117, 56);
            this.txtnombrecanario.Name = "txtnombrecanario";
            this.txtnombrecanario.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecanario.TabIndex = 4;
            // 
            // btninsertarcanario
            // 
            this.btninsertarcanario.Location = new System.Drawing.Point(8, 142);
            this.btninsertarcanario.Name = "btninsertarcanario";
            this.btninsertarcanario.Size = new System.Drawing.Size(75, 23);
            this.btninsertarcanario.TabIndex = 9;
            this.btninsertarcanario.Text = "Insertar";
            this.btninsertarcanario.UseVisualStyleBackColor = true;
            this.btninsertarcanario.Click += new System.EventHandler(this.btninsertarcanario_Click);
            // 
            // btneliminarcanario
            // 
            this.btneliminarcanario.Location = new System.Drawing.Point(89, 142);
            this.btneliminarcanario.Name = "btneliminarcanario";
            this.btneliminarcanario.Size = new System.Drawing.Size(75, 23);
            this.btneliminarcanario.TabIndex = 10;
            this.btneliminarcanario.Text = "Eliminar";
            this.btneliminarcanario.UseVisualStyleBackColor = true;
            this.btneliminarcanario.Visible = false;
            this.btneliminarcanario.Click += new System.EventHandler(this.btneliminarcanario_Click);
            // 
            // txtidcanario
            // 
            this.txtidcanario.Enabled = false;
            this.txtidcanario.Location = new System.Drawing.Point(117, 26);
            this.txtidcanario.Name = "txtidcanario";
            this.txtidcanario.Size = new System.Drawing.Size(100, 20);
            this.txtidcanario.TabIndex = 13;
            // 
            // btnactualizarcanario
            // 
            this.btnactualizarcanario.Location = new System.Drawing.Point(170, 142);
            this.btnactualizarcanario.Name = "btnactualizarcanario";
            this.btnactualizarcanario.Size = new System.Drawing.Size(75, 23);
            this.btnactualizarcanario.TabIndex = 11;
            this.btnactualizarcanario.Text = "Actualizar";
            this.btnactualizarcanario.UseVisualStyleBackColor = true;
            this.btnactualizarcanario.Visible = false;
            this.btnactualizarcanario.Click += new System.EventHandler(this.btnactualizarcanario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(15, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(818, 238);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color";
            this.groupBox4.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvcolor);
            this.groupBox5.Location = new System.Drawing.Point(358, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(443, 180);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Busqueda";
            // 
            // dgvcolor
            // 
            this.dgvcolor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcolor.Location = new System.Drawing.Point(20, 22);
            this.dgvcolor.Name = "dgvcolor";
            this.dgvcolor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcolor.Size = new System.Drawing.Size(408, 140);
            this.dgvcolor.TabIndex = 14;
            this.dgvcolor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcolor_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.imagen);
            this.groupBox6.Controls.Add(this.btnImagen);
            this.groupBox6.Controls.Add(this.btlimpiarcolor);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtnombrecolor);
            this.groupBox6.Controls.Add(this.btinsertarcolor);
            this.groupBox6.Controls.Add(this.bteliminarcolor);
            this.groupBox6.Controls.Add(this.txtidcolor);
            this.groupBox6.Controls.Add(this.btactualizarcolor);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(15, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(337, 199);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datos";
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(116, 82);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(100, 79);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 32;
            this.imagen.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(220, 139);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(32, 23);
            this.btnImagen.TabIndex = 31;
            this.btnImagen.Text = "...";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // btlimpiarcolor
            // 
            this.btlimpiarcolor.Location = new System.Drawing.Point(251, 169);
            this.btlimpiarcolor.Name = "btlimpiarcolor";
            this.btlimpiarcolor.Size = new System.Drawing.Size(75, 23);
            this.btlimpiarcolor.TabIndex = 23;
            this.btlimpiarcolor.Text = "Limpiar";
            this.btlimpiarcolor.UseVisualStyleBackColor = true;
            this.btlimpiarcolor.Click += new System.EventHandler(this.btlimpiarcolor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Imagen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre:";
            // 
            // txtnombrecolor
            // 
            this.txtnombrecolor.Location = new System.Drawing.Point(117, 56);
            this.txtnombrecolor.Name = "txtnombrecolor";
            this.txtnombrecolor.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecolor.TabIndex = 4;
            // 
            // btinsertarcolor
            // 
            this.btinsertarcolor.Location = new System.Drawing.Point(8, 169);
            this.btinsertarcolor.Name = "btinsertarcolor";
            this.btinsertarcolor.Size = new System.Drawing.Size(75, 23);
            this.btinsertarcolor.TabIndex = 9;
            this.btinsertarcolor.Text = "Insertar";
            this.btinsertarcolor.UseVisualStyleBackColor = true;
            this.btinsertarcolor.Click += new System.EventHandler(this.btinsertarcolor_Click);
            // 
            // bteliminarcolor
            // 
            this.bteliminarcolor.Location = new System.Drawing.Point(89, 169);
            this.bteliminarcolor.Name = "bteliminarcolor";
            this.bteliminarcolor.Size = new System.Drawing.Size(75, 23);
            this.bteliminarcolor.TabIndex = 10;
            this.bteliminarcolor.Text = "Eliminar";
            this.bteliminarcolor.UseVisualStyleBackColor = true;
            this.bteliminarcolor.Visible = false;
            this.bteliminarcolor.Click += new System.EventHandler(this.bteliminarcolor_Click);
            // 
            // txtidcolor
            // 
            this.txtidcolor.Enabled = false;
            this.txtidcolor.Location = new System.Drawing.Point(117, 26);
            this.txtidcolor.Name = "txtidcolor";
            this.txtidcolor.Size = new System.Drawing.Size(100, 20);
            this.txtidcolor.TabIndex = 13;
            // 
            // btactualizarcolor
            // 
            this.btactualizarcolor.Location = new System.Drawing.Point(170, 169);
            this.btactualizarcolor.Name = "btactualizarcolor";
            this.btactualizarcolor.Size = new System.Drawing.Size(75, 23);
            this.btactualizarcolor.TabIndex = 11;
            this.btactualizarcolor.Text = "Actualizar";
            this.btactualizarcolor.UseVisualStyleBackColor = true;
            this.btactualizarcolor.Visible = false;
            this.btactualizarcolor.Click += new System.EventHandler(this.btactualizarcolor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 487);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Mantenimiento";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcanario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcolor)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvcanario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbuscarcanario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlimpiarcanario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombrecanario;
        private System.Windows.Forms.Button btninsertarcanario;
        private System.Windows.Forms.Button btneliminarcanario;
        private System.Windows.Forms.TextBox txtidcanario;
        private System.Windows.Forms.Button btnactualizarcanario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvcolor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btlimpiarcolor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombrecolor;
        private System.Windows.Forms.Button btinsertarcolor;
        private System.Windows.Forms.Button bteliminarcolor;
        private System.Windows.Forms.TextBox txtidcolor;
        private System.Windows.Forms.Button btactualizarcolor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Button btnImagen;
    }
}

