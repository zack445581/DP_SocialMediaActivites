namespace digitaPartnership
{
    partial class Client
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumTele = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRaisonSocial = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtAdress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateDebut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(86, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(306, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Raison sociale :";
            // 
            // TxtNumTele
            // 
            this.TxtNumTele.BorderColorFocused = System.Drawing.Color.DarkRed;
            this.TxtNumTele.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNumTele.BorderColorMouseHover = System.Drawing.Color.DarkRed;
            this.TxtNumTele.BorderThickness = 1;
            this.TxtNumTele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNumTele.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNumTele.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNumTele.isPassword = false;
            this.TxtNumTele.Location = new System.Drawing.Point(310, 177);
            this.TxtNumTele.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumTele.Name = "TxtNumTele";
            this.TxtNumTele.Size = new System.Drawing.Size(386, 32);
            this.TxtNumTele.TabIndex = 39;
            this.TxtNumTele.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNumTele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumTele_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(306, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "numéro de téléphone  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(306, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Adresse :";
            // 
            // TxtRaisonSocial
            // 
            this.TxtRaisonSocial.BorderColorFocused = System.Drawing.Color.DarkRed;
            this.TxtRaisonSocial.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRaisonSocial.BorderColorMouseHover = System.Drawing.Color.DarkRed;
            this.TxtRaisonSocial.BorderThickness = 1;
            this.TxtRaisonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRaisonSocial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtRaisonSocial.ForeColor = System.Drawing.Color.DimGray;
            this.TxtRaisonSocial.isPassword = false;
            this.TxtRaisonSocial.Location = new System.Drawing.Point(310, 101);
            this.TxtRaisonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRaisonSocial.Name = "TxtRaisonSocial";
            this.TxtRaisonSocial.Size = new System.Drawing.Size(386, 32);
            this.TxtRaisonSocial.TabIndex = 45;
            this.TxtRaisonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtAdress
            // 
            this.TxtAdress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtAdress.ForeColor = System.Drawing.Color.DimGray;
            this.TxtAdress.Location = new System.Drawing.Point(310, 329);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(386, 89);
            this.TxtAdress.TabIndex = 47;
            this.TxtAdress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(306, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Date de debut :";
            // 
            // DateDebut
            // 
            this.DateDebut.BackColor = System.Drawing.Color.DimGray;
            this.DateDebut.BorderRadius = 0;
            this.DateDebut.ForeColor = System.Drawing.Color.White;
            this.DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateDebut.FormatCustom = null;
            this.DateDebut.Location = new System.Drawing.Point(310, 250);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(386, 36);
            this.DateDebut.TabIndex = 49;
            this.DateDebut.Value = new System.DateTime(2019, 4, 3, 11, 44, 30, 862);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 5;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Enregistrer";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(61)))), ((int)(((byte)(50)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(726, 428);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(132, 54);
            this.bunifuThinButton21.TabIndex = 50;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.DateDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdress);
            this.Controls.Add(this.TxtRaisonSocial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNumTele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(863, 482);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtNumTele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtRaisonSocial;
        private System.Windows.Forms.RichTextBox TxtAdress;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker DateDebut;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
