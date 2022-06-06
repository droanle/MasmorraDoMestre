namespace MasmorraDoMestre
{
    partial class testes
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
            this.item = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.Panel();
            this.item.SuspendLayout();
            this.lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item.Controls.Add(this.date);
            this.item.Controls.Add(this.text);
            this.item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.item.Location = new System.Drawing.Point(3, 3);
            this.item.Name = "item";
            this.item.Padding = new System.Windows.Forms.Padding(10);
            this.item.Size = new System.Drawing.Size(493, 50);
            this.item.TabIndex = 0;
            this.item.Click += new System.EventHandler(this.item_Click);
            this.item.Paint += new System.Windows.Forms.PaintEventHandler(this.item_Paint);
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(332, 8);
            this.date.Margin = new System.Windows.Forms.Padding(0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(149, 30);
            this.date.TabIndex = 1;
            this.date.Text = "[Data de criação do Sistema]";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(15, 10);
            this.text.Margin = new System.Windows.Forms.Padding(0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(317, 30);
            this.text.TabIndex = 0;
            this.text.Text = "[Nome do Sistema]";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lista
            // 
            this.lista.AutoScroll = true;
            this.lista.BackColor = System.Drawing.Color.Silver;
            this.lista.Controls.Add(this.item);
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(514, 424);
            this.lista.TabIndex = 2;
            // 
            // testes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista);
            this.Name = "testes";
            this.Text = "testes";
            this.item.ResumeLayout(false);
            this.lista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel item;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Panel lista;
        private System.Windows.Forms.Label date;
    }
}