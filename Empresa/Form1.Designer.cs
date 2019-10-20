namespace Empresa
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
            this.dtgempresa = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtcargo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgempresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgempresa
            // 
            this.dtgempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgempresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Apellido,
            this.FNacimiento,
            this.Cargo});
            this.dtgempresa.Location = new System.Drawing.Point(-3, 395);
            this.dtgempresa.Name = "dtgempresa";
            this.dtgempresa.Size = new System.Drawing.Size(743, 206);
            this.dtgempresa.TabIndex = 0;
            this.dtgempresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgempresa_CellClick);
            this.dtgempresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgempresa_CellContentClick);
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 150;
            // 
            // FNacimiento
            // 
            this.FNacimiento.DataPropertyName = "Fecha de Nacimiento";
            this.FNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FNacimiento.Name = "FNacimiento";
            this.FNacimiento.Width = 150;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cargo:";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(111, 89);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 7;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(163, 159);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 8;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(575, 89);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 10;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(356, 89);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 11;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(237, 346);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(106, 34);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Empresa";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(349, 346);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 34);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(476, 159);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(100, 20);
            this.txtcargo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 613);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgempresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgempresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgempresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.TextBox txtcargo;
    }
}

