namespace MVC_3_ClFamilies.FORMS
{
    partial class FrmAMCicles
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
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Tomato;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(416, 205);
            this.btNo.Margin = new System.Windows.Forms.Padding(4);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(128, 44);
            this.btNo.TabIndex = 16;
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
            this.btOK.Location = new System.Drawing.Point(256, 205);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(128, 44);
            this.btOK.TabIndex = 15;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(172, 90);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.MaxLength = 100;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(540, 26);
            this.tbNom.TabIndex = 14;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.Gray;
            this.lbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(29, 91);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(4);
            this.lbNom.Size = new System.Drawing.Size(123, 26);
            this.lbNom.TabIndex = 13;
            this.lbNom.Text = "Nom";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(172, 40);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.MaxLength = 10;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(145, 26);
            this.tbId.TabIndex = 12;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Gray;
            this.lbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(29, 42);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(4);
            this.lbId.Size = new System.Drawing.Size(107, 26);
            this.lbId.TabIndex = 11;
            this.lbId.Text = "Identificador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Identificador Familia";
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(214, 145);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(423, 24);
            this.cbFamilia.TabIndex = 18;
            this.cbFamilia.SelectedIndexChanged += new System.EventHandler(this.cbFamilia_SelectedIndexChanged);
            // 
            // FrmAMCicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.cbFamilia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmAMCicles";
            this.Text = "FrmAMCicles";
            this.Load += new System.EventHandler(this.FrmAMCicles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFamilia;
    }
}