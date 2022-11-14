namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tr = new System.Windows.Forms.Button();
            this.ct = new System.Windows.Forms.Button();
            this.tl = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.cc = new System.Windows.Forms.Button();
            this.cr = new System.Windows.Forms.Button();
            this.bl = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.Button();
            this.br = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zawodnikLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Controls.Add(this.tr, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cr, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.br, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tr
            // 
            this.tr.Location = new System.Drawing.Point(225, 3);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(93, 100);
            this.tr.TabIndex = 0;
            this.tr.UseVisualStyleBackColor = true;
            this.tr.Click += new System.EventHandler(this.Mark);
            // 
            // ct
            // 
            this.ct.Location = new System.Drawing.Point(114, 3);
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(105, 100);
            this.ct.TabIndex = 1;
            this.ct.UseVisualStyleBackColor = true;
            this.ct.Click += new System.EventHandler(this.Mark);
            // 
            // tl
            // 
            this.tl.Location = new System.Drawing.Point(3, 3);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(105, 100);
            this.tl.TabIndex = 2;
            this.tl.Text = "\r\n";
            this.tl.UseVisualStyleBackColor = true;
            this.tl.Click += new System.EventHandler(this.Mark);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(3, 109);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(105, 100);
            this.cl.TabIndex = 3;
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.Mark);
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(114, 109);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(105, 100);
            this.cc.TabIndex = 4;
            this.cc.UseVisualStyleBackColor = true;
            this.cc.Click += new System.EventHandler(this.Mark);
            // 
            // cr
            // 
            this.cr.Location = new System.Drawing.Point(225, 109);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(93, 100);
            this.cr.TabIndex = 5;
            this.cr.UseVisualStyleBackColor = true;
            this.cr.Click += new System.EventHandler(this.Mark);
            // 
            // bl
            // 
            this.bl.Location = new System.Drawing.Point(3, 215);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(105, 112);
            this.bl.TabIndex = 6;
            this.bl.UseVisualStyleBackColor = true;
            this.bl.Click += new System.EventHandler(this.Mark);
            // 
            // cb
            // 
            this.cb.Location = new System.Drawing.Point(114, 215);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(105, 112);
            this.cb.TabIndex = 7;
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Click += new System.EventHandler(this.Mark);
            // 
            // br
            // 
            this.br.Location = new System.Drawing.Point(225, 215);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(93, 112);
            this.br.TabIndex = 8;
            this.br.UseVisualStyleBackColor = true;
            this.br.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny Ruch";
            // 
            // zawodnikLabel
            // 
            this.zawodnikLabel.AutoSize = true;
            this.zawodnikLabel.Location = new System.Drawing.Point(132, 414);
            this.zawodnikLabel.Name = "zawodnikLabel";
            this.zawodnikLabel.Size = new System.Drawing.Size(0, 15);
            this.zawodnikLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zawodnikLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button tr;
        private Button ct;
        private Button tl;
        private Button cl;
        private Button cc;
        private Button cr;
        private Button bl;
        private Button cb;
        private Button br;
        private Label label1;
        private Label zawodnikLabel;
    }
}