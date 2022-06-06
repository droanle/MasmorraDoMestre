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
            this.itemSheet = new System.Windows.Forms.Panel();
            this.editPicture = new System.Windows.Forms.PictureBox();
            this.viewPicture = new System.Windows.Forms.PictureBox();
            this.deletePicture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.profilePhoto = new System.Windows.Forms.PictureBox();
            this.item.SuspendLayout();
            this.lista.SuspendLayout();
            this.itemSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).BeginInit();
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
            this.text.Paint += new System.Windows.Forms.PaintEventHandler(this.text_Paint);
            // 
            // lista
            // 
            this.lista.AutoScroll = true;
            this.lista.BackColor = System.Drawing.Color.Silver;
            this.lista.Controls.Add(this.itemSheet);
            this.lista.Controls.Add(this.item);
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(514, 424);
            this.lista.TabIndex = 2;
            // 
            // itemSheet
            // 
            this.itemSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.itemSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemSheet.Controls.Add(this.editPicture);
            this.itemSheet.Controls.Add(this.viewPicture);
            this.itemSheet.Controls.Add(this.deletePicture);
            this.itemSheet.Controls.Add(this.name);
            this.itemSheet.Controls.Add(this.profilePhoto);
            this.itemSheet.Location = new System.Drawing.Point(100, 126);
            this.itemSheet.Name = "itemSheet";
            this.itemSheet.Size = new System.Drawing.Size(190, 190);
            this.itemSheet.TabIndex = 3;
            // 
            // editPicture
            // 
            this.editPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPicture.Image = global::MasmorraDoMestre.Properties.Resources.edit;
            this.editPicture.Location = new System.Drawing.Point(150, 161);
            this.editPicture.Name = "editPicture";
            this.editPicture.Size = new System.Drawing.Size(35, 20);
            this.editPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editPicture.TabIndex = 7;
            this.editPicture.TabStop = false;
            // 
            // viewPicture
            // 
            this.viewPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPicture.Image = global::MasmorraDoMestre.Properties.Resources.view;
            this.viewPicture.Location = new System.Drawing.Point(74, 161);
            this.viewPicture.Name = "viewPicture";
            this.viewPicture.Size = new System.Drawing.Size(35, 20);
            this.viewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPicture.TabIndex = 6;
            this.viewPicture.TabStop = false;
            // 
            // deletePicture
            // 
            this.deletePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePicture.Image = global::MasmorraDoMestre.Properties.Resources.delete;
            this.deletePicture.Location = new System.Drawing.Point(3, 161);
            this.deletePicture.Name = "deletePicture";
            this.deletePicture.Size = new System.Drawing.Size(35, 20);
            this.deletePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePicture.TabIndex = 3;
            this.deletePicture.TabStop = false;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.name.Location = new System.Drawing.Point(7, 115);
            this.name.Margin = new System.Windows.Forms.Padding(0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(178, 34);
            this.name.TabIndex = 2;
            this.name.Text = "Juliano Caetano";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePhoto
            // 
            this.profilePhoto.Image = global::MasmorraDoMestre.Properties.Resources.image2;
            this.profilePhoto.Location = new System.Drawing.Point(3, 3);
            this.profilePhoto.Name = "profilePhoto";
            this.profilePhoto.Size = new System.Drawing.Size(182, 109);
            this.profilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilePhoto.TabIndex = 0;
            this.profilePhoto.TabStop = false;
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
            this.itemSheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel item;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Panel lista;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel itemSheet;
        private System.Windows.Forms.PictureBox editPicture;
        private System.Windows.Forms.PictureBox viewPicture;
        private System.Windows.Forms.PictureBox deletePicture;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox profilePhoto;
    }
}