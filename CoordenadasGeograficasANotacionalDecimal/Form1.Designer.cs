namespace CoordenadasGeograficasANotacionalDecimal
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
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnCargarExcel = new System.Windows.Forms.Button();
            this.grpExcelCargado = new System.Windows.Forms.GroupBox();
            this.dgvExcelSeleccionado = new System.Windows.Forms.DataGridView();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.opnSeleccionArchivo = new System.Windows.Forms.OpenFileDialog();
            this.grpColumnas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboColumnaLongitud = new System.Windows.Forms.ComboBox();
            this.cboColumnaLatitud = new System.Windows.Forms.ComboBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.grpExcelCargado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelSeleccionado)).BeginInit();
            this.grpColumnas.SuspendLayout();
            this.grpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(12, 12);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(378, 20);
            this.txtRutaArchivo.TabIndex = 5;
            // 
            // btnCargarExcel
            // 
            this.btnCargarExcel.Location = new System.Drawing.Point(401, 10);
            this.btnCargarExcel.Name = "btnCargarExcel";
            this.btnCargarExcel.Size = new System.Drawing.Size(75, 23);
            this.btnCargarExcel.TabIndex = 4;
            this.btnCargarExcel.Text = "Cargar Excel";
            this.btnCargarExcel.UseVisualStyleBackColor = true;
            this.btnCargarExcel.Click += new System.EventHandler(this.btnCargarExcel_Click);
            // 
            // grpExcelCargado
            // 
            this.grpExcelCargado.Controls.Add(this.dgvExcelSeleccionado);
            this.grpExcelCargado.Location = new System.Drawing.Point(12, 38);
            this.grpExcelCargado.Name = "grpExcelCargado";
            this.grpExcelCargado.Size = new System.Drawing.Size(509, 585);
            this.grpExcelCargado.TabIndex = 6;
            this.grpExcelCargado.TabStop = false;
            this.grpExcelCargado.Text = "Archivo de Excel ";
            // 
            // dgvExcelSeleccionado
            // 
            this.dgvExcelSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExcelSeleccionado.Location = new System.Drawing.Point(3, 16);
            this.dgvExcelSeleccionado.Name = "dgvExcelSeleccionado";
            this.dgvExcelSeleccionado.Size = new System.Drawing.Size(503, 566);
            this.dgvExcelSeleccionado.TabIndex = 0;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(728, 597);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // opnSeleccionArchivo
            // 
            this.opnSeleccionArchivo.FileName = "openFileDialog1";
            // 
            // grpColumnas
            // 
            this.grpColumnas.Controls.Add(this.label2);
            this.grpColumnas.Controls.Add(this.label1);
            this.grpColumnas.Controls.Add(this.cboColumnaLongitud);
            this.grpColumnas.Controls.Add(this.cboColumnaLatitud);
            this.grpColumnas.Location = new System.Drawing.Point(527, 38);
            this.grpColumnas.Name = "grpColumnas";
            this.grpColumnas.Size = new System.Drawing.Size(276, 553);
            this.grpColumnas.TabIndex = 8;
            this.grpColumnas.TabStop = false;
            this.grpColumnas.Text = "Columnas a seleccionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columna Longitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Columna Latitud";
            // 
            // cboColumnaLongitud
            // 
            this.cboColumnaLongitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnaLongitud.FormattingEnabled = true;
            this.cboColumnaLongitud.Location = new System.Drawing.Point(110, 46);
            this.cboColumnaLongitud.Name = "cboColumnaLongitud";
            this.cboColumnaLongitud.Size = new System.Drawing.Size(160, 21);
            this.cboColumnaLongitud.TabIndex = 1;
            // 
            // cboColumnaLatitud
            // 
            this.cboColumnaLatitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnaLatitud.FormattingEnabled = true;
            this.cboColumnaLatitud.Location = new System.Drawing.Point(110, 19);
            this.cboColumnaLatitud.Name = "cboColumnaLatitud";
            this.cboColumnaLatitud.Size = new System.Drawing.Size(160, 21);
            this.cboColumnaLatitud.TabIndex = 0;
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.dgvResultado);
            this.grpResultado.Location = new System.Drawing.Point(819, 38);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(598, 585);
            this.grpResultado.TabIndex = 9;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultado.Location = new System.Drawing.Point(3, 16);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(592, 566);
            this.dgvResultado.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 624);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpColumnas);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.grpExcelCargado);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.btnCargarExcel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Convertir coordenadas geográficas a notación decimal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpExcelCargado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelSeleccionado)).EndInit();
            this.grpColumnas.ResumeLayout(false);
            this.grpColumnas.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnCargarExcel;
        private System.Windows.Forms.GroupBox grpExcelCargado;
        private System.Windows.Forms.DataGridView dgvExcelSeleccionado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.OpenFileDialog opnSeleccionArchivo;
        private System.Windows.Forms.GroupBox grpColumnas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboColumnaLongitud;
        private System.Windows.Forms.ComboBox cboColumnaLatitud;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
    }
}

