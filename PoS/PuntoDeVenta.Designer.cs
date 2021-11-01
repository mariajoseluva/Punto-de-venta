
namespace PoS
{
    partial class PuntoDeVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nombreTienda = new System.Windows.Forms.Label();
            this.hora_fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cuadro_desc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalL = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ivaL = new System.Windows.Forms.Label();
            this.subt = new System.Windows.Forms.Label();
            this.eliminarB = new System.Windows.Forms.Button();
            this.pagarB = new System.Windows.Forms.Button();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.pagoL = new System.Windows.Forms.Label();
            this.empleadoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuadro_desc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nombreTienda.ForeColor = System.Drawing.Color.Blue;
            this.nombreTienda.Location = new System.Drawing.Point(1006, 40);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(377, 52);
            this.nombreTienda.TabIndex = 0;
            this.nombreTienda.Text = "Nombre del Super";
            // 
            // hora_fecha
            // 
            this.hora_fecha.AutoSize = true;
            this.hora_fecha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.hora_fecha.ForeColor = System.Drawing.Color.Blue;
            this.hora_fecha.Location = new System.Drawing.Point(1088, 92);
            this.hora_fecha.Name = "hora_fecha";
            this.hora_fecha.Size = new System.Drawing.Size(181, 35);
            this.hora_fecha.TabIndex = 2;
            this.hora_fecha.Text = "Hora y Fecha";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cuadro_desc
            // 
            this.cuadro_desc.AllowUserToAddRows = false;
            this.cuadro_desc.AllowUserToDeleteRows = false;
            this.cuadro_desc.AllowUserToResizeColumns = false;
            this.cuadro_desc.AllowUserToResizeRows = false;
            this.cuadro_desc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cuadro_desc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.cuadro_desc.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cuadro_desc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cuadro_desc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuadro_desc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.cuadro_desc.Location = new System.Drawing.Point(27, 120);
            this.cuadro_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cuadro_desc.MultiSelect = false;
            this.cuadro_desc.Name = "cuadro_desc";
            this.cuadro_desc.ReadOnly = true;
            this.cuadro_desc.RowHeadersVisible = false;
            this.cuadro_desc.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.NullValue = null;
            this.cuadro_desc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cuadro_desc.RowTemplate.Height = 60;
            this.cuadro_desc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cuadro_desc.Size = new System.Drawing.Size(838, 465);
            this.cuadro_desc.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Precio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(27, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(838, 56);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // totalL
            // 
            this.totalL.AutoSize = true;
            this.totalL.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.totalL.ForeColor = System.Drawing.Color.Blue;
            this.totalL.Location = new System.Drawing.Point(928, 792);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(124, 59);
            this.totalL.TabIndex = 5;
            this.totalL.Text = "Total";
            // 
            // logo
            // 
            this.logo.Image = global::PoS.Properties.Resources.supermercado;
            this.logo.Location = new System.Drawing.Point(917, 131);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(523, 519);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // ivaL
            // 
            this.ivaL.AutoSize = true;
            this.ivaL.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ivaL.Location = new System.Drawing.Point(943, 747);
            this.ivaL.Name = "ivaL";
            this.ivaL.Size = new System.Drawing.Size(73, 45);
            this.ivaL.TabIndex = 7;
            this.ivaL.Text = "IVA";
            // 
            // subt
            // 
            this.subt.AutoSize = true;
            this.subt.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.subt.Location = new System.Drawing.Point(943, 700);
            this.subt.Name = "subt";
            this.subt.Size = new System.Drawing.Size(146, 45);
            this.subt.TabIndex = 8;
            this.subt.Text = "Subtotal";
            // 
            // eliminarB
            // 
            this.eliminarB.BackColor = System.Drawing.Color.Red;
            this.eliminarB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eliminarB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eliminarB.Location = new System.Drawing.Point(85, 640);
            this.eliminarB.Name = "eliminarB";
            this.eliminarB.Size = new System.Drawing.Size(261, 71);
            this.eliminarB.TabIndex = 9;
            this.eliminarB.Text = "Eliminar";
            this.eliminarB.UseVisualStyleBackColor = false;
            this.eliminarB.Click += new System.EventHandler(this.eliminarB_Click);
            // 
            // pagarB
            // 
            this.pagarB.BackColor = System.Drawing.Color.Lime;
            this.pagarB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pagarB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pagarB.Location = new System.Drawing.Point(519, 640);
            this.pagarB.Name = "pagarB";
            this.pagarB.Size = new System.Drawing.Size(261, 71);
            this.pagarB.TabIndex = 10;
            this.pagarB.Text = "Pagar";
            this.pagarB.UseVisualStyleBackColor = false;
            this.pagarB.Click += new System.EventHandler(this.pagarB_Click);
            // 
            // txtpago
            // 
            this.txtpago.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtpago.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtpago.Location = new System.Drawing.Point(217, 715);
            this.txtpago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(180, 56);
            this.txtpago.TabIndex = 4;
            // 
            // pagoL
            // 
            this.pagoL.AutoSize = true;
            this.pagoL.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pagoL.ForeColor = System.Drawing.Color.Blue;
            this.pagoL.Location = new System.Drawing.Point(52, 729);
            this.pagoL.Name = "pagoL";
            this.pagoL.Size = new System.Drawing.Size(128, 35);
            this.pagoL.TabIndex = 11;
            this.pagoL.Text = "Pagó con";
            // 
            // empleadoL
            // 
            this.empleadoL.AutoSize = true;
            this.empleadoL.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empleadoL.ForeColor = System.Drawing.Color.Blue;
            this.empleadoL.Location = new System.Drawing.Point(43, 9);
            this.empleadoL.Name = "empleadoL";
            this.empleadoL.Size = new System.Drawing.Size(111, 28);
            this.empleadoL.TabIndex = 12;
            this.empleadoL.Text = "Empleado";
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1381, 788);
            this.Controls.Add(this.empleadoL);
            this.Controls.Add(this.pagoL);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.pagarB);
            this.Controls.Add(this.eliminarB);
            this.Controls.Add(this.subt);
            this.Controls.Add(this.ivaL);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.totalL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cuadro_desc);
            this.Controls.Add(this.hora_fecha);
            this.Controls.Add(this.nombreTienda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PuntoDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntoDeVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PuntoDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuadro_desc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Label hora_fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView cuadro_desc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label totalL;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label ivaL;
        private System.Windows.Forms.Label subt;
        private System.Windows.Forms.Button eliminarB;
        private System.Windows.Forms.Button pagarB;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label pagoL;
        private System.Windows.Forms.Label empleadoL;
    }
}