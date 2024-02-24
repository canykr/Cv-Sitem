namespace WinFormsApp1
{
    partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            toolStrip1 = new ToolStrip();
            btnYeniKayit = new ToolStripButton();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnAra = new Button();
            label1 = new Label();
            gridListe = new DataGridView();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridListe).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnYeniKayit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.Image = (Image)resources.GetObject("btnYeniKayit.Image");
            btnYeniKayit.ImageTransparentColor = Color.Magenta;
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(78, 22);
            btnYeniKayit.Text = "Yeni Kayıt";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAra);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 49);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(94, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "sddd";
            // 
            // btnAra
            // 
            btnAra.Image = (Image)resources.GetObject("btnAra.Image");
            btnAra.Location = new Point(593, 5);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(34, 29);
            btnAra.TabIndex = 1;
            btnAra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Müşteri Ara :";
            label1.Click += label1_Click;
            // 
            // gridListe
            // 
            gridListe.AllowUserToAddRows = false;
            gridListe.AllowUserToDeleteRows = false;
            gridListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridListe.Dock = DockStyle.Fill;
            gridListe.Location = new Point(0, 74);
            gridListe.Name = "gridListe";
            gridListe.ReadOnly = true;
            gridListe.Size = new Size(800, 376);
            gridListe.TabIndex = 2;
            // 
            // frmMusteriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridListe);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "frmMusteriler";
            Text = "Müşteri Listesi";
            WindowState = FormWindowState.Maximized;
            Load += frmMusteriler_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnYeniKayit;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button btnAra;
        private DataGridView gridListe;
    }
}