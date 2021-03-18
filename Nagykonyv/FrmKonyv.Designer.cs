
namespace Nagykonyv
{
    partial class FrmKonyv
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.tbx_cim = new System.Windows.Forms.TextBox();
            this.tb_helyezes = new System.Windows.Forms.TextBox();
            this.btn_rogzites = new System.Windows.Forms.Button();
            this.btn_modositas = new System.Windows.Forms.Button();
            this.btn_torles = new System.Windows.Forms.Button();
            this.cbx_szerzo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "szerzo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "helyezes:";
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(70, 47);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(175, 20);
            this.tbx_id.TabIndex = 4;
            // 
            // tbx_cim
            // 
            this.tbx_cim.Location = new System.Drawing.Point(70, 108);
            this.tbx_cim.Name = "tbx_cim";
            this.tbx_cim.Size = new System.Drawing.Size(175, 20);
            this.tbx_cim.TabIndex = 6;
            // 
            // tb_helyezes
            // 
            this.tb_helyezes.Location = new System.Drawing.Point(70, 135);
            this.tb_helyezes.Name = "tb_helyezes";
            this.tb_helyezes.Size = new System.Drawing.Size(175, 20);
            this.tb_helyezes.TabIndex = 7;
            // 
            // btn_rogzites
            // 
            this.btn_rogzites.Location = new System.Drawing.Point(12, 172);
            this.btn_rogzites.Name = "btn_rogzites";
            this.btn_rogzites.Size = new System.Drawing.Size(65, 56);
            this.btn_rogzites.TabIndex = 8;
            this.btn_rogzites.Text = "Rogzites";
            this.btn_rogzites.UseVisualStyleBackColor = true;
            this.btn_rogzites.Click += new System.EventHandler(this.btn_rogzites_Click);
            // 
            // btn_modositas
            // 
            this.btn_modositas.Location = new System.Drawing.Point(95, 172);
            this.btn_modositas.Name = "btn_modositas";
            this.btn_modositas.Size = new System.Drawing.Size(65, 56);
            this.btn_modositas.TabIndex = 9;
            this.btn_modositas.Text = "Modositas";
            this.btn_modositas.UseVisualStyleBackColor = true;
            this.btn_modositas.Click += new System.EventHandler(this.btn_modositas_Click);
            // 
            // btn_torles
            // 
            this.btn_torles.Location = new System.Drawing.Point(180, 172);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(65, 56);
            this.btn_torles.TabIndex = 10;
            this.btn_torles.Text = "Torles";
            this.btn_torles.UseVisualStyleBackColor = true;
            this.btn_torles.Click += new System.EventHandler(this.btn_torles_Click);
            // 
            // cbx_szerzo
            // 
            this.cbx_szerzo.FormattingEnabled = true;
            this.cbx_szerzo.Location = new System.Drawing.Point(70, 80);
            this.cbx_szerzo.Name = "cbx_szerzo";
            this.cbx_szerzo.Size = new System.Drawing.Size(175, 21);
            this.cbx_szerzo.TabIndex = 11;
            // 
            // FrmKonyv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 258);
            this.Controls.Add(this.cbx_szerzo);
            this.Controls.Add(this.btn_torles);
            this.Controls.Add(this.btn_modositas);
            this.Controls.Add(this.btn_rogzites);
            this.Controls.Add(this.tb_helyezes);
            this.Controls.Add(this.tbx_cim);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKonyv";
            this.Text = "FrmKonyv";
            this.Load += new System.EventHandler(this.FrmKonyv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox tbx_cim;
        private System.Windows.Forms.TextBox tb_helyezes;
        private System.Windows.Forms.Button btn_rogzites;
        private System.Windows.Forms.Button btn_modositas;
        private System.Windows.Forms.Button btn_torles;
        private System.Windows.Forms.ComboBox cbx_szerzo;
    }
}