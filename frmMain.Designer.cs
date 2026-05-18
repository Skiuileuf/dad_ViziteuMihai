namespace dad_ViziteuMihai
{
    partial class frmMain
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
            this.btnConturi = new System.Windows.Forms.Button();
            this.btnRulaje = new System.Windows.Forms.Button();
            this.btnBalanta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConturi
            // 
            this.btnConturi.Location = new System.Drawing.Point(46, 38);
            this.btnConturi.Name = "btnConturi";
            this.btnConturi.Size = new System.Drawing.Size(204, 23);
            this.btnConturi.TabIndex = 0;
            this.btnConturi.Text = "Deschide Conturi";
            this.btnConturi.UseVisualStyleBackColor = true;
            this.btnConturi.Click += new System.EventHandler(this.btnConturi_Click);
            // 
            // btnRulaje
            // 
            this.btnRulaje.Location = new System.Drawing.Point(46, 67);
            this.btnRulaje.Name = "btnRulaje";
            this.btnRulaje.Size = new System.Drawing.Size(204, 23);
            this.btnRulaje.TabIndex = 1;
            this.btnRulaje.Text = "Deschide Rulaje";
            this.btnRulaje.UseVisualStyleBackColor = true;
            this.btnRulaje.Click += new System.EventHandler(this.btnRulaje_Click);
            // 
            // btnBalanta
            // 
            this.btnBalanta.Location = new System.Drawing.Point(46, 96);
            this.btnBalanta.Name = "btnBalanta";
            this.btnBalanta.Size = new System.Drawing.Size(204, 23);
            this.btnBalanta.TabIndex = 2;
            this.btnBalanta.Text = "Deschide Balanta";
            this.btnBalanta.UseVisualStyleBackColor = true;
            this.btnBalanta.Click += new System.EventHandler(this.btnBalanta_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBalanta);
            this.Controls.Add(this.btnRulaje);
            this.Controls.Add(this.btnConturi);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConturi;
        private System.Windows.Forms.Button btnRulaje;
        private System.Windows.Forms.Button btnBalanta;
    }
}

