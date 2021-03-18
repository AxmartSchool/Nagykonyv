
namespace Nagykonyv
{
    partial class FrmListan
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_kereses = new System.Windows.Forms.TextBox();
            this.dgv_konyvek = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szerzokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujKonyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konyvek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kereses szerzo vagy cim alapjan";
            // 
            // tbx_kereses
            // 
            this.tbx_kereses.Location = new System.Drawing.Point(122, 83);
            this.tbx_kereses.Name = "tbx_kereses";
            this.tbx_kereses.Size = new System.Drawing.Size(279, 20);
            this.tbx_kereses.TabIndex = 3;
            this.tbx_kereses.TextChanged += new System.EventHandler(this.tbx_kereses_TextChanged);
            // 
            // dgv_konyvek
            // 
            this.dgv_konyvek.AllowUserToAddRows = false;
            this.dgv_konyvek.AllowUserToDeleteRows = false;
            this.dgv_konyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_konyvek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.helyezes,
            this.nev,
            this.cim});
            this.dgv_konyvek.Location = new System.Drawing.Point(12, 129);
            this.dgv_konyvek.Name = "dgv_konyvek";
            this.dgv_konyvek.ReadOnly = true;
            this.dgv_konyvek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_konyvek.Size = new System.Drawing.Size(517, 309);
            this.dgv_konyvek.TabIndex = 4;
            this.dgv_konyvek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_konyvek_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "konyv(ID)";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // helyezes
            // 
            this.helyezes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.helyezes.HeaderText = "helyezes";
            this.helyezes.Name = "helyezes";
            this.helyezes.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nev.HeaderText = "nev";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // cim
            // 
            this.cim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cim.HeaderText = "cim";
            this.cim.Name = "cim";
            this.cim.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerzokToolStripMenuItem,
            this.ujKonyvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szerzokToolStripMenuItem
            // 
            this.szerzokToolStripMenuItem.Name = "szerzokToolStripMenuItem";
            this.szerzokToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.szerzokToolStripMenuItem.Text = "Szerzok";
            // 
            // ujKonyvToolStripMenuItem
            // 
            this.ujKonyvToolStripMenuItem.Name = "ujKonyvToolStripMenuItem";
            this.ujKonyvToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ujKonyvToolStripMenuItem.Text = "Uj Konyv";
            this.ujKonyvToolStripMenuItem.Click += new System.EventHandler(this.ujKonyvToolStripMenuItem_Click);
            // 
            // FrmListan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.dgv_konyvek);
            this.Controls.Add(this.tbx_kereses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmListan";
            this.Text = "Nagykonyv";
            this.Activated += new System.EventHandler(this.FrmListan_Activated);
            this.Load += new System.EventHandler(this.FrmListan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konyvek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_kereses;
        private System.Windows.Forms.DataGridView dgv_konyvek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerzokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujKonyvToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
    }
}

