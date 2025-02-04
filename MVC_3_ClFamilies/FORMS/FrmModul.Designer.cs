namespace MVC_3_ClFamilies.FORMS
{
    partial class FrmModul
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbhdr = new System.Windows.Forms.Label();
            this.cbCicle = new System.Windows.Forms.ComboBox();
            this.ckbTots = new System.Windows.Forms.CheckBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(22, 96);
            this.dgDades.Margin = new System.Windows.Forms.Padding(4);
            this.dgDades.MultiSelect = false;
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(500, 500);
            this.dgDades.TabIndex = 12;
            this.dgDades.DoubleClick += new System.EventHandler(this.dgDades_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(500, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.label1.Size = new System.Drawing.Size(500, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modulo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhdr
            // 
            this.lbhdr.BackColor = System.Drawing.Color.Orange;
            this.lbhdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbhdr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhdr.Location = new System.Drawing.Point(22, 10);
            this.lbhdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhdr.MinimumSize = new System.Drawing.Size(2, 2);
            this.lbhdr.Name = "lbhdr";
            this.lbhdr.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbhdr.Size = new System.Drawing.Size(86, 36);
            this.lbhdr.TabIndex = 10;
            this.lbhdr.Text = "Cicle:";
            this.lbhdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCicle
            // 
            this.cbCicle.FormattingEnabled = true;
            this.cbCicle.Location = new System.Drawing.Point(115, 17);
            this.cbCicle.Name = "cbCicle";
            this.cbCicle.Size = new System.Drawing.Size(291, 24);
            this.cbCicle.TabIndex = 9;
            this.cbCicle.SelectedIndexChanged += new System.EventHandler(this.cbFamilia_SelectedIndexChanged);
            // 
            // ckbTots
            // 
            this.ckbTots.AutoSize = true;
            this.ckbTots.Location = new System.Drawing.Point(439, 20);
            this.ckbTots.Name = "ckbTots";
            this.ckbTots.Size = new System.Drawing.Size(56, 20);
            this.ckbTots.TabIndex = 15;
            this.ckbTots.Text = "Tots";
            this.ckbTots.UseVisualStyleBackColor = true;
            this.ckbTots.CheckedChanged += new System.EventHandler(this.ckbTots_CheckedChanged);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = global::MVC_3_ClFamilies.Properties.Resources.icons8_cancel_50;
            this.btDel.Location = new System.Drawing.Point(536, 529);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 14;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btNou
            // 
            this.btNou.BackColor = System.Drawing.Color.Transparent;
            this.btNou.FlatAppearance.BorderSize = 0;
            this.btNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNou.ForeColor = System.Drawing.Color.Transparent;
            this.btNou.Image = global::MVC_3_ClFamilies.Properties.Resources.icons8_plus_50;
            this.btNou.Location = new System.Drawing.Point(536, 466);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 13;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // FrmModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 608);
            this.Controls.Add(this.ckbTots);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbhdr);
            this.Controls.Add(this.cbCicle);
            this.Name = "FrmModul";
            this.Text = "FrmModul";
            this.Load += new System.EventHandler(this.FrmModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbhdr;
        private System.Windows.Forms.ComboBox cbCicle;
        private System.Windows.Forms.CheckBox ckbTots;
    }
}