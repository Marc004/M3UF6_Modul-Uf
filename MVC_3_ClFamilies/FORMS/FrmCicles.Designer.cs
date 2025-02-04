namespace MVC_3_ClFamilies.FORMS
{
    partial class FrmCicles
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
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.lbhdr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            this.btQuants = new System.Windows.Forms.Button();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lbPobl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(106, 24);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(407, 24);
            this.cbFamilia.TabIndex = 0;
            this.cbFamilia.SelectedIndexChanged += new System.EventHandler(this.cbFamilia_SelectedIndexChanged);
            // 
            // lbhdr
            // 
            this.lbhdr.BackColor = System.Drawing.Color.Orange;
            this.lbhdr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbhdr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhdr.Location = new System.Drawing.Point(13, 17);
            this.lbhdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhdr.MinimumSize = new System.Drawing.Size(2, 2);
            this.lbhdr.Name = "lbhdr";
            this.lbhdr.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbhdr.Size = new System.Drawing.Size(86, 36);
            this.lbhdr.TabIndex = 2;
            this.lbhdr.Text = "Familia: ";
            this.lbhdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(500, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.label1.Size = new System.Drawing.Size(500, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cicles Formatius";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgDades.Location = new System.Drawing.Point(13, 103);
            this.dgDades.Margin = new System.Windows.Forms.Padding(4);
            this.dgDades.MultiSelect = false;
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(500, 500);
            this.dgDades.TabIndex = 4;
            this.dgDades.DoubleClick += new System.EventHandler(this.dgDades_DoubleClick);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = global::MVC_3_ClFamilies.Properties.Resources.icons8_cancel_50;
            this.btDel.Location = new System.Drawing.Point(527, 536);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 8;
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
            this.btNou.Location = new System.Drawing.Point(527, 473);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 7;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // btQuants
            // 
            this.btQuants.BackColor = System.Drawing.Color.SteelBlue;
            this.btQuants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuants.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuants.ForeColor = System.Drawing.Color.White;
            this.btQuants.Location = new System.Drawing.Point(13, 651);
            this.btQuants.Margin = new System.Windows.Forms.Padding(4);
            this.btQuants.Name = "btQuants";
            this.btQuants.Size = new System.Drawing.Size(259, 42);
            this.btQuants.TabIndex = 13;
            this.btQuants.Text = "&Quantes n\'hi ha amb aquest prefix?";
            this.btQuants.UseVisualStyleBackColor = false;
            this.btQuants.Click += new System.EventHandler(this.btQuants_Click);
            // 
            // tbPrefix
            // 
            this.tbPrefix.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrefix.Location = new System.Drawing.Point(183, 616);
            this.tbPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(353, 26);
            this.tbPrefix.TabIndex = 12;
            // 
            // lbPobl
            // 
            this.lbPobl.AutoSize = true;
            this.lbPobl.BackColor = System.Drawing.Color.Gray;
            this.lbPobl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPobl.ForeColor = System.Drawing.Color.White;
            this.lbPobl.Location = new System.Drawing.Point(13, 616);
            this.lbPobl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPobl.Name = "lbPobl";
            this.lbPobl.Padding = new System.Windows.Forms.Padding(4);
            this.lbPobl.Size = new System.Drawing.Size(160, 26);
            this.lbPobl.TabIndex = 11;
            this.lbPobl.Text = "Introdueix un prefix";
            // 
            // FrmCicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 720);
            this.Controls.Add(this.btQuants);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.lbPobl);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbhdr);
            this.Controls.Add(this.cbFamilia);
            this.Name = "FrmCicles";
            this.Text = "Cicles Formatius";
            this.Load += new System.EventHandler(this.FrmCicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFamilia;
        private System.Windows.Forms.Label lbhdr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
        private System.Windows.Forms.Button btQuants;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label lbPobl;
    }
}