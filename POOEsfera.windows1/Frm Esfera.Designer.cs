
namespace POOEsfera.windows1
{
    partial class Frm_Esfera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Esfera));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevotoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrartoolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.RestaurartoolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EsferadataGridView2 = new System.Windows.Forms.DataGridView();
            this.Arecolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumecolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadlabel = new System.Windows.Forms.Label();
            this.Radiocolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salirtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.GuardartoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsferadataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevotoolStripButton1,
            this.EditartoolStripButton2,
            this.BorrartoolStripButton3,
            this.toolStripSeparator1,
            this.FiltrartoolStripButton4,
            this.RestaurartoolStripButton5,
            this.salirtoolStripButton1,
            this.GuardartoolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevotoolStripButton1
            // 
            this.NuevotoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("NuevotoolStripButton1.Image")));
            this.NuevotoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevotoolStripButton1.Name = "NuevotoolStripButton1";
            this.NuevotoolStripButton1.Size = new System.Drawing.Size(46, 35);
            this.NuevotoolStripButton1.Text = "Nuevo";
            this.NuevotoolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevotoolStripButton1.Click += new System.EventHandler(this.NuevotoolStripButton1_Click);
            // 
            // EditartoolStripButton2
            // 
            this.EditartoolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("EditartoolStripButton2.Image")));
            this.EditartoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton2.Name = "EditartoolStripButton2";
            this.EditartoolStripButton2.Size = new System.Drawing.Size(41, 35);
            this.EditartoolStripButton2.Text = "Editar";
            this.EditartoolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditartoolStripButton2.Click += new System.EventHandler(this.EditartoolStripButton2_Click);
            // 
            // BorrartoolStripButton3
            // 
            this.BorrartoolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("BorrartoolStripButton3.Image")));
            this.BorrartoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrartoolStripButton3.Name = "BorrartoolStripButton3";
            this.BorrartoolStripButton3.Size = new System.Drawing.Size(43, 35);
            this.BorrartoolStripButton3.Text = "Borrar";
            this.BorrartoolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrartoolStripButton3.Click += new System.EventHandler(this.BorrartoolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // FiltrartoolStripButton4
            // 
            this.FiltrartoolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("FiltrartoolStripButton4.Image")));
            this.FiltrartoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrartoolStripButton4.Name = "FiltrartoolStripButton4";
            this.FiltrartoolStripButton4.Size = new System.Drawing.Size(39, 35);
            this.FiltrartoolStripButton4.Text = "filtrar";
            this.FiltrartoolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // RestaurartoolStripButton5
            // 
            this.RestaurartoolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("RestaurartoolStripButton5.Image")));
            this.RestaurartoolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestaurartoolStripButton5.Name = "RestaurartoolStripButton5";
            this.RestaurartoolStripButton5.Size = new System.Drawing.Size(60, 35);
            this.RestaurartoolStripButton5.Text = "Restaurar";
            this.RestaurartoolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RestaurartoolStripButton5.Click += new System.EventHandler(this.RestaurartoolStripButton5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // EsferadataGridView2
            // 
            this.EsferadataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EsferadataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arecolum,
            this.volumecolumna,
            this.Radiocolum});
            this.EsferadataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EsferadataGridView2.Location = new System.Drawing.Point(0, 38);
            this.EsferadataGridView2.Name = "EsferadataGridView2";
            this.EsferadataGridView2.Size = new System.Drawing.Size(800, 262);
            this.EsferadataGridView2.TabIndex = 2;
            this.EsferadataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EsferadataGridView2_CellContentClick);
            // 
            // Arecolum
            // 
            this.Arecolum.HeaderText = "AREA";
            this.Arecolum.Name = "Arecolum";
            // 
            // volumecolumna
            // 
            this.volumecolumna.HeaderText = "Volumen";
            this.volumecolumna.Name = "volumecolumna";
            // 
            // cantidadlabel
            // 
            this.cantidadlabel.AutoSize = true;
            this.cantidadlabel.Location = new System.Drawing.Point(72, 357);
            this.cantidadlabel.Name = "cantidadlabel";
            this.cantidadlabel.Size = new System.Drawing.Size(48, 13);
            this.cantidadlabel.TabIndex = 3;
            this.cantidadlabel.Text = "cantidad";
            // 
            // Radiocolum
            // 
            this.Radiocolum.HeaderText = "Radio";
            this.Radiocolum.Name = "Radiocolum";
            // 
            // salirtoolStripButton1
            // 
            this.salirtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("salirtoolStripButton1.Image")));
            this.salirtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salirtoolStripButton1.Name = "salirtoolStripButton1";
            this.salirtoolStripButton1.Size = new System.Drawing.Size(32, 35);
            this.salirtoolStripButton1.Text = "salir";
            this.salirtoolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salirtoolStripButton1.Click += new System.EventHandler(this.salirtoolStripButton1_Click);
            // 
            // GuardartoolStripButton1
            // 
            this.GuardartoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("GuardartoolStripButton1.Image")));
            this.GuardartoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardartoolStripButton1.Name = "GuardartoolStripButton1";
            this.GuardartoolStripButton1.Size = new System.Drawing.Size(53, 35);
            this.GuardartoolStripButton1.Text = "Guardar";
            this.GuardartoolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardartoolStripButton1.Click += new System.EventHandler(this.GuardartoolStripButton1_Click);
            // 
            // Frm_Esfera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cantidadlabel);
            this.Controls.Add(this.EsferadataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Esfera";
            this.Text = "Frm_Esfera";
            this.Load += new System.EventHandler(this.Frm_Esfera_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsferadataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevotoolStripButton1;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton2;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton FiltrartoolStripButton4;
        private System.Windows.Forms.ToolStripButton RestaurartoolStripButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView EsferadataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arecolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumecolumna;
        private System.Windows.Forms.Label cantidadlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radiocolum;
        private System.Windows.Forms.ToolStripButton salirtoolStripButton1;
        private System.Windows.Forms.ToolStripButton GuardartoolStripButton1;
    }
}