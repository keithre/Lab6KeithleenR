
namespace Lab6KeithleenR
{
    partial class FormAlquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.FechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.FechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dataGridViewResumen = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.dataGridalquileres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridalquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(184, 42);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(100, 23);
            this.txtNIT.TabIndex = 0;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(184, 99);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 1;
            // 
            // TxtKm
            // 
            this.TxtKm.Location = new System.Drawing.Point(184, 163);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(100, 23);
            this.TxtKm.TabIndex = 2;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.Location = new System.Drawing.Point(204, 241);
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.Size = new System.Drawing.Size(200, 23);
            this.FechaPrestamo.TabIndex = 3;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.Location = new System.Drawing.Point(204, 307);
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.Size = new System.Drawing.Size(200, 23);
            this.FechaDevolucion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kms recorridos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Prestamo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Devolucion";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(162, 366);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(132, 49);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar Datos";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dataGridViewResumen
            // 
            this.dataGridViewResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResumen.Location = new System.Drawing.Point(492, 31);
            this.dataGridViewResumen.Name = "dataGridViewResumen";
            this.dataGridViewResumen.RowTemplate.Height = 25;
            this.dataGridViewResumen.Size = new System.Drawing.Size(361, 155);
            this.dataGridViewResumen.TabIndex = 11;
            this.dataGridViewResumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(173, 458);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(102, 49);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar Informacion";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridVehiculos
            // 
            this.dataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehiculos.Location = new System.Drawing.Point(492, 209);
            this.dataGridVehiculos.Name = "dataGridVehiculos";
            this.dataGridVehiculos.RowTemplate.Height = 25;
            this.dataGridVehiculos.Size = new System.Drawing.Size(361, 150);
            this.dataGridVehiculos.TabIndex = 14;
            // 
            // dataGridalquileres
            // 
            this.dataGridalquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridalquileres.Location = new System.Drawing.Point(492, 385);
            this.dataGridalquileres.Name = "dataGridalquileres";
            this.dataGridalquileres.RowTemplate.Height = 25;
            this.dataGridalquileres.Size = new System.Drawing.Size(361, 153);
            this.dataGridalquileres.TabIndex = 15;
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 557);
            this.Controls.Add(this.dataGridalquileres);
            this.Controls.Add(this.dataGridVehiculos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridViewResumen);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaDevolucion);
            this.Controls.Add(this.FechaPrestamo);
            this.Controls.Add(this.TxtKm);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtNIT);
            this.Name = "FormAlquiler";
            this.Text = "FormAlquiler";
            this.Load += new System.EventHandler(this.FormAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridalquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.DateTimePicker FechaPrestamo;
        private System.Windows.Forms.DateTimePicker FechaDevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dataGridViewResumen;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridVehiculos;
        private System.Windows.Forms.DataGridView dataGridalquileres;
    }
}