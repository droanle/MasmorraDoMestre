namespace MasmorraDoMestre.View
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joinPanel = new System.Windows.Forms.Panel();
            this.join = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.joinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(260, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denilson / Leandro / Jorge / Sara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2022 - Criado por:";
            // 
            // joinPanel
            // 
            this.joinPanel.BackColor = System.Drawing.Color.Transparent;
            this.joinPanel.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.joinPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.joinPanel.Controls.Add(this.join);
            this.joinPanel.Location = new System.Drawing.Point(296, 417);
            this.joinPanel.Name = "joinPanel";
            this.joinPanel.Padding = new System.Windows.Forms.Padding(10);
            this.joinPanel.Size = new System.Drawing.Size(213, 53);
            this.joinPanel.TabIndex = 3;
            this.joinPanel.Click += new System.EventHandler(this.joinPanel_Click);
            this.joinPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.joinPanel_Paint);
            // 
            // join
            // 
            this.join.BackColor = System.Drawing.Color.Transparent;
            this.join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.join.Dock = System.Windows.Forms.DockStyle.Fill;
            this.join.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.join.Location = new System.Drawing.Point(10, 10);
            this.join.Margin = new System.Windows.Forms.Padding(0);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(193, 33);
            this.join.TabIndex = 4;
            this.join.Text = "ENTRAR";
            this.join.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.join.Click += new System.EventHandler(this.joinPanel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.masmorra_menu01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.joinPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Masmorra do Mestre";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.joinPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel joinPanel;
        private System.Windows.Forms.Label join;
    }
}

