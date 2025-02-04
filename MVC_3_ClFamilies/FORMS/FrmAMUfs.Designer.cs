namespace MVC_3_ClFamilies.FORMS
{
    partial class FrmAMUfs
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
            this.cbModul = new System.Windows.Forms.ComboBox();
            this.lbFamila = new System.Windows.Forms.Label();
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.cbCicle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbModul
            // 
            this.cbModul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModul.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModul.FormattingEnabled = true;
            this.cbModul.Location = new System.Drawing.Point(156, 160);
            this.cbModul.Name = "cbModul";
            this.cbModul.Size = new System.Drawing.Size(540, 26);
            this.cbModul.TabIndex = 26;
            // 
            // lbFamila
            // 
            this.lbFamila.AutoSize = true;
            this.lbFamila.BackColor = System.Drawing.Color.Gray;
            this.lbFamila.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFamila.ForeColor = System.Drawing.Color.White;
            this.lbFamila.Location = new System.Drawing.Point(13, 159);
            this.lbFamila.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFamila.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbFamila.Name = "lbFamila";
            this.lbFamila.Padding = new System.Windows.Forms.Padding(4);
            this.lbFamila.Size = new System.Drawing.Size(123, 26);
            this.lbFamila.TabIndex = 25;
            this.lbFamila.Text = "Modul";
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Tomato;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(390, 200);
            this.btNo.Margin = new System.Windows.Forms.Padding(4);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(128, 44);
            this.btNo.TabIndex = 24;
            this.btNo.Text = "&Descartar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(230, 200);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(128, 44);
            this.btOK.TabIndex = 23;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(156, 76);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.MaxLength = 100;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(540, 26);
            this.tbNom.TabIndex = 22;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.Gray;
            this.lbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(13, 77);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(4);
            this.lbNom.Size = new System.Drawing.Size(123, 26);
            this.lbNom.TabIndex = 21;
            this.lbNom.Text = "Nom";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(156, 26);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.MaxLength = 10;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(145, 26);
            this.tbId.TabIndex = 20;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Gray;
            this.lbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(13, 29);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(4);
            this.lbId.Size = new System.Drawing.Size(107, 26);
            this.lbId.TabIndex = 19;
            this.lbId.Text = "Identificador";
            // 
            // cbCicle
            // 
            this.cbCicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCicle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCicle.FormattingEnabled = true;
            this.cbCicle.Location = new System.Drawing.Point(156, 120);
            this.cbCicle.Name = "cbCicle";
            this.cbCicle.Size = new System.Drawing.Size(540, 26);
            this.cbCicle.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(123, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cicle";
            // 
            // FrmAMUfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 267);
            this.Controls.Add(this.cbCicle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbModul);
            this.Controls.Add(this.lbFamila);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmAMUfs";
            this.Text = "FrmAMUfs";
            this.Load += new System.EventHandler(this.FrmAMUfs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbModul;
        private System.Windows.Forms.Label lbFamila;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.ComboBox cbCicle;
        private System.Windows.Forms.Label label1;
    }
}