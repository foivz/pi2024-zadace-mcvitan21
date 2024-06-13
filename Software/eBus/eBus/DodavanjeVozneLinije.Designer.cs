namespace eBus
{
    partial class DodavanjeVozneLinije
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opisLinije = new System.Windows.Forms.TextBox();
            this.brojLinije = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.idAzuriraj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metodaAzuriraj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj liniju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis linije:";
            // 
            // opisLinije
            // 
            this.opisLinije.Location = new System.Drawing.Point(120, 133);
            this.opisLinije.Name = "opisLinije";
            this.opisLinije.Size = new System.Drawing.Size(271, 22);
            this.opisLinije.TabIndex = 5;
            // 
            // brojLinije
            // 
            this.brojLinije.Location = new System.Drawing.Point(120, 76);
            this.brojLinije.Name = "brojLinije";
            this.brojLinije.Size = new System.Drawing.Size(271, 22);
            this.brojLinije.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Azuriraj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idAzuriraj
            // 
            this.idAzuriraj.Location = new System.Drawing.Point(498, 76);
            this.idAzuriraj.Name = "idAzuriraj";
            this.idAzuriraj.Size = new System.Drawing.Size(271, 22);
            this.idAzuriraj.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // metodaAzuriraj
            // 
            this.metodaAzuriraj.Location = new System.Drawing.Point(498, 133);
            this.metodaAzuriraj.Name = "metodaAzuriraj";
            this.metodaAzuriraj.Size = new System.Drawing.Size(271, 22);
            this.metodaAzuriraj.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Model:";
            // 
            // DodavanjeVozneLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 308);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metodaAzuriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idAzuriraj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.brojLinije);
            this.Controls.Add(this.opisLinije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DodavanjeVozneLinije";
            this.Text = "DodavanjeVozila";
            this.Load += new System.EventHandler(this.DodavanjeVozneLinije_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opisLinije;
        private System.Windows.Forms.TextBox brojLinije;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idAzuriraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metodaAzuriraj;
        private System.Windows.Forms.Label label4;
    }
}