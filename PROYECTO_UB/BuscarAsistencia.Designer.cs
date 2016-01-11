namespace PROYECTO_UB
{
    partial class BuscarAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarAsistencia));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_excel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.txt_busapm = new System.Windows.Forms.TextBox();
            this.txt_busapp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_asignatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(785, 286);
            this.dataGridView1.TabIndex = 29;
            // 
            // btn_excel
            // 
            this.btn_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.Image")));
            this.btn_excel.Location = new System.Drawing.Point(768, 30);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(32, 27);
            this.btn_excel.TabIndex = 34;
            this.btn_excel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nombre";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(14, 35);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(128, 26);
            this.txt_buscar.TabIndex = 37;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // txt_busapm
            // 
            this.txt_busapm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busapm.Location = new System.Drawing.Point(326, 35);
            this.txt_busapm.Name = "txt_busapm";
            this.txt_busapm.Size = new System.Drawing.Size(128, 26);
            this.txt_busapm.TabIndex = 42;
            this.txt_busapm.TextChanged += new System.EventHandler(this.txt_busapm_TextChanged);
            // 
            // txt_busapp
            // 
            this.txt_busapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busapp.Location = new System.Drawing.Point(165, 35);
            this.txt_busapp.Name = "txt_busapp";
            this.txt_busapp.Size = new System.Drawing.Size(128, 26);
            this.txt_busapp.TabIndex = 41;
            this.txt_busapp.TextChanged += new System.EventHandler(this.txt_busapp_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(323, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 15);
            this.label14.TabIndex = 40;
            this.label14.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Apellido Paterno";
            // 
            // txt_asignatura
            // 
            this.txt_asignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asignatura.Location = new System.Drawing.Point(498, 35);
            this.txt_asignatura.Name = "txt_asignatura";
            this.txt_asignatura.Size = new System.Drawing.Size(128, 26);
            this.txt_asignatura.TabIndex = 43;
            this.txt_asignatura.TextChanged += new System.EventHandler(this.txt_asignatura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Asignatura";
            // 
            // BuscarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_asignatura);
            this.Controls.Add(this.txt_busapm);
            this.Controls.Add(this.txt_busapp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscarAsistencia";
            this.Text = "BuscarAsistencia";
            this.Load += new System.EventHandler(this.BuscarAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.TextBox txt_busapm;
        private System.Windows.Forms.TextBox txt_busapp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_asignatura;
        private System.Windows.Forms.Label label1;
    }
}