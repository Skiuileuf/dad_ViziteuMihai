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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConturi
            // 
            this.btnConturi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConturi.Location = new System.Drawing.Point(3, 3);
            this.btnConturi.Name = "btnConturi";
            this.btnConturi.Size = new System.Drawing.Size(296, 55);
            this.btnConturi.TabIndex = 0;
            this.btnConturi.Text = "Deschide Conturi";
            this.btnConturi.UseVisualStyleBackColor = true;
            this.btnConturi.Click += new System.EventHandler(this.btnConturi_Click);
            // 
            // btnRulaje
            // 
            this.btnRulaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRulaje.Location = new System.Drawing.Point(3, 64);
            this.btnRulaje.Name = "btnRulaje";
            this.btnRulaje.Size = new System.Drawing.Size(296, 55);
            this.btnRulaje.TabIndex = 1;
            this.btnRulaje.Text = "Deschide Rulaje";
            this.btnRulaje.UseVisualStyleBackColor = true;
            this.btnRulaje.Click += new System.EventHandler(this.btnRulaje_Click);
            // 
            // btnBalanta
            // 
            this.btnBalanta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBalanta.Location = new System.Drawing.Point(3, 125);
            this.btnBalanta.Name = "btnBalanta";
            this.btnBalanta.Size = new System.Drawing.Size(296, 55);
            this.btnBalanta.TabIndex = 2;
            this.btnBalanta.Text = "Deschide Balanta";
            this.btnBalanta.UseVisualStyleBackColor = true;
            this.btnBalanta.Click += new System.EventHandler(this.btnBalanta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proiect DAD - Viziteu Mihai\r\nIG 678\r\n2025-2026";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBalanta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConturi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRulaje, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 247);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 247);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConturi;
        private System.Windows.Forms.Button btnRulaje;
        private System.Windows.Forms.Button btnBalanta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

