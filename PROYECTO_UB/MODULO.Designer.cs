namespace PROYECTO_UB
{
    partial class MODULO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MODULO));
            this.CB_DIA = new System.Windows.Forms.ComboBox();
            this.CB_INICIO = new System.Windows.Forms.ComboBox();
            this.CB_FIN = new System.Windows.Forms.ComboBox();
            this.CODIGO = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.Label();
            this.INICIO = new System.Windows.Forms.Label();
            this.FIN = new System.Windows.Forms.Label();
            this.TXT_COD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_DIA
            // 
            this.CB_DIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_DIA.FormattingEnabled = true;
            this.CB_DIA.Location = new System.Drawing.Point(12, 102);
            this.CB_DIA.Name = "CB_DIA";
            this.CB_DIA.Size = new System.Drawing.Size(121, 21);
            this.CB_DIA.TabIndex = 0;
            // 
            // CB_INICIO
            // 
            this.CB_INICIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_INICIO.FormattingEnabled = true;
            this.CB_INICIO.Location = new System.Drawing.Point(12, 151);
            this.CB_INICIO.Name = "CB_INICIO";
            this.CB_INICIO.Size = new System.Drawing.Size(68, 21);
            this.CB_INICIO.TabIndex = 1;
            // 
            // CB_FIN
            // 
            this.CB_FIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FIN.FormattingEnabled = true;
            this.CB_FIN.Location = new System.Drawing.Point(86, 151);
            this.CB_FIN.Name = "CB_FIN";
            this.CB_FIN.Size = new System.Drawing.Size(64, 21);
            this.CB_FIN.TabIndex = 2;
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSize = true;
            this.CODIGO.Location = new System.Drawing.Point(13, 39);
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Size = new System.Drawing.Size(49, 13);
            this.CODIGO.TabIndex = 3;
            this.CODIGO.Text = "CODIGO";
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSize = true;
            this.NOMBRE.Location = new System.Drawing.Point(13, 86);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(25, 13);
            this.NOMBRE.TabIndex = 4;
            this.NOMBRE.Text = "DIA";
            // 
            // INICIO
            // 
            this.INICIO.AutoSize = true;
            this.INICIO.Location = new System.Drawing.Point(13, 135);
            this.INICIO.Name = "INICIO";
            this.INICIO.Size = new System.Drawing.Size(39, 13);
            this.INICIO.TabIndex = 5;
            this.INICIO.Text = "INICIO";
            // 
            // FIN
            // 
            this.FIN.AutoSize = true;
            this.FIN.Location = new System.Drawing.Point(87, 135);
            this.FIN.Name = "FIN";
            this.FIN.Size = new System.Drawing.Size(24, 13);
            this.FIN.TabIndex = 6;
            this.FIN.Text = "FIN";
            // 
            // TXT_COD
            // 
            this.TXT_COD.Enabled = false;
            this.TXT_COD.Location = new System.Drawing.Point(13, 56);
            this.TXT_COD.Name = "TXT_COD";
            this.TXT_COD.Size = new System.Drawing.Size(100, 20);
            this.TXT_COD.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Location = new System.Drawing.Point(16, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(271, 14);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(81, 38);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Enabled = false;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(180, 14);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(86, 38);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "Modificar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(7, 14);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(82, 38);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(95, 14);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(80, 38);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.Image")));
            this.btn_excel.Location = new System.Drawing.Point(369, 25);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(32, 26);
            this.btn_excel.TabIndex = 13;
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(168, 25);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(195, 26);
            this.txt_buscar.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(233, 133);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MODULO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXT_COD);
            this.Controls.Add(this.FIN);
            this.Controls.Add(this.INICIO);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.CODIGO);
            this.Controls.Add(this.CB_FIN);
            this.Controls.Add(this.CB_INICIO);
            this.Controls.Add(this.CB_DIA);
            this.Name = "MODULO";
            this.Text = "MODULO";
            this.Load += new System.EventHandler(this.MODULO_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_DIA;
        private System.Windows.Forms.ComboBox CB_INICIO;
        private System.Windows.Forms.ComboBox CB_FIN;
        private System.Windows.Forms.Label CODIGO;
        private System.Windows.Forms.Label NOMBRE;
        private System.Windows.Forms.Label INICIO;
        private System.Windows.Forms.Label FIN;
        private System.Windows.Forms.TextBox TXT_COD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}