namespace MasmorraDoMestre.View
{
    partial class Sheet
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SecAttributes = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SecAttributesLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ifPlayerLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.typeTextBox = new System.Windows.Forms.RichTextBox();
            this.nameSave = new System.Windows.Forms.PictureBox();
            this.typeSave = new System.Windows.Forms.PictureBox();
            this.descriptionSave = new System.Windows.Forms.PictureBox();
            this.profilePhoto = new System.Windows.Forms.PictureBox();
            this.nameExit = new System.Windows.Forms.PictureBox();
            this.typeExit = new System.Windows.Forms.PictureBox();
            this.descriptionExit = new System.Windows.Forms.PictureBox();
            this.content.SuspendLayout();
            this.SecAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionExit)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(219, 12);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(215, 26);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "[Nome do personagem]";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.DoubleClick += new System.EventHandler(this.nameLabel_DoubleClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(439, 9);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(5);
            this.descriptionLabel.Size = new System.Drawing.Size(333, 138);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Descrição: [Descrição do personagem]";
            this.descriptionLabel.DoubleClick += new System.EventHandler(this.descriptionLabel_DoubleClick);
            // 
            // content
            // 
            this.content.AutoScroll = true;
            this.content.BackColor = System.Drawing.Color.Silver;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Controls.Add(this.panel3);
            this.content.Controls.Add(this.SecAttributes);
            this.content.Location = new System.Drawing.Point(12, 153);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(760, 396);
            this.content.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 4);
            this.panel3.TabIndex = 2;
            // 
            // SecAttributes
            // 
            this.SecAttributes.AutoScroll = true;
            this.SecAttributes.BackColor = System.Drawing.Color.Gray;
            this.SecAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecAttributes.Controls.Add(this.panel2);
            this.SecAttributes.Controls.Add(this.SecAttributesLabel);
            this.SecAttributes.Location = new System.Drawing.Point(3, 3);
            this.SecAttributes.Name = "SecAttributes";
            this.SecAttributes.Size = new System.Drawing.Size(735, 182);
            this.SecAttributes.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 5);
            this.panel2.TabIndex = 15;
            // 
            // SecAttributesLabel
            // 
            this.SecAttributesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecAttributesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecAttributesLabel.ForeColor = System.Drawing.Color.Black;
            this.SecAttributesLabel.Location = new System.Drawing.Point(0, 0);
            this.SecAttributesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SecAttributesLabel.Name = "SecAttributesLabel";
            this.SecAttributesLabel.Size = new System.Drawing.Size(733, 34);
            this.SecAttributesLabel.TabIndex = 14;
            this.SecAttributesLabel.Text = "Atributos Secundario";
            this.SecAttributesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.Color.Black;
            this.typeLabel.Location = new System.Drawing.Point(216, 68);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(218, 26);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "[Raça do personagem]";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.typeLabel.DoubleClick += new System.EventHandler(this.typeLabel_DoubleClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(152, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(152, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Raça:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ifPlayerLabel
            // 
            this.ifPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifPlayerLabel.ForeColor = System.Drawing.Color.Black;
            this.ifPlayerLabel.Location = new System.Drawing.Point(152, 114);
            this.ifPlayerLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ifPlayerLabel.Name = "ifPlayerLabel";
            this.ifPlayerLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ifPlayerLabel.Size = new System.Drawing.Size(282, 33);
            this.ifPlayerLabel.TabIndex = 10;
            this.ifPlayerLabel.Text = "[Identificação do aspecto da conta]";
            this.ifPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(439, 9);
            this.descriptionTextBox.MaxLength = 5000000;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(333, 138);
            this.descriptionTextBox.TabIndex = 11;
            this.descriptionTextBox.Text = "[Descrição do personagem]";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(216, 12);
            this.nameTextBox.MaxLength = 200;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 26);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Text = "[Nome do personagem]";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(216, 68);
            this.typeTextBox.MaxLength = 100;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(218, 26);
            this.typeTextBox.TabIndex = 13;
            this.typeTextBox.Text = "[Raça do personagem]";
            // 
            // nameSave
            // 
            this.nameSave.Image = global::MasmorraDoMestre.Properties.Resources.memoryCard;
            this.nameSave.Location = new System.Drawing.Point(413, 18);
            this.nameSave.Margin = new System.Windows.Forms.Padding(1);
            this.nameSave.Name = "nameSave";
            this.nameSave.Size = new System.Drawing.Size(15, 15);
            this.nameSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nameSave.TabIndex = 16;
            this.nameSave.TabStop = false;
            this.nameSave.Click += new System.EventHandler(this.nameSave_Click);
            // 
            // typeSave
            // 
            this.typeSave.Image = global::MasmorraDoMestre.Properties.Resources.memoryCard;
            this.typeSave.Location = new System.Drawing.Point(413, 73);
            this.typeSave.Margin = new System.Windows.Forms.Padding(1);
            this.typeSave.Name = "typeSave";
            this.typeSave.Size = new System.Drawing.Size(15, 15);
            this.typeSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typeSave.TabIndex = 15;
            this.typeSave.TabStop = false;
            this.typeSave.Click += new System.EventHandler(this.typeSave_Click);
            // 
            // descriptionSave
            // 
            this.descriptionSave.Image = global::MasmorraDoMestre.Properties.Resources.memoryCard;
            this.descriptionSave.Location = new System.Drawing.Point(750, 126);
            this.descriptionSave.Margin = new System.Windows.Forms.Padding(1);
            this.descriptionSave.Name = "descriptionSave";
            this.descriptionSave.Size = new System.Drawing.Size(15, 15);
            this.descriptionSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.descriptionSave.TabIndex = 14;
            this.descriptionSave.TabStop = false;
            this.descriptionSave.Click += new System.EventHandler(this.descriptionSave_Click);
            // 
            // profilePhoto
            // 
            this.profilePhoto.Image = global::MasmorraDoMestre.Properties.Resources.image2;
            this.profilePhoto.Location = new System.Drawing.Point(12, 12);
            this.profilePhoto.Name = "profilePhoto";
            this.profilePhoto.Size = new System.Drawing.Size(135, 135);
            this.profilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhoto.TabIndex = 1;
            this.profilePhoto.TabStop = false;
            // 
            // nameExit
            // 
            this.nameExit.Image = global::MasmorraDoMestre.Properties.Resources.x_icon;
            this.nameExit.Location = new System.Drawing.Point(394, 18);
            this.nameExit.Name = "nameExit";
            this.nameExit.Size = new System.Drawing.Size(15, 15);
            this.nameExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nameExit.TabIndex = 17;
            this.nameExit.TabStop = false;
            this.nameExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // typeExit
            // 
            this.typeExit.Image = global::MasmorraDoMestre.Properties.Resources.x_icon;
            this.typeExit.Location = new System.Drawing.Point(394, 73);
            this.typeExit.Name = "typeExit";
            this.typeExit.Size = new System.Drawing.Size(15, 15);
            this.typeExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typeExit.TabIndex = 18;
            this.typeExit.TabStop = false;
            this.typeExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // descriptionExit
            // 
            this.descriptionExit.Image = global::MasmorraDoMestre.Properties.Resources.x_icon;
            this.descriptionExit.Location = new System.Drawing.Point(731, 126);
            this.descriptionExit.Name = "descriptionExit";
            this.descriptionExit.Size = new System.Drawing.Size(15, 15);
            this.descriptionExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.descriptionExit.TabIndex = 19;
            this.descriptionExit.TabStop = false;
            this.descriptionExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.descriptionExit);
            this.Controls.Add(this.typeExit);
            this.Controls.Add(this.nameExit);
            this.Controls.Add(this.nameSave);
            this.Controls.Add(this.typeSave);
            this.Controls.Add(this.descriptionSave);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.profilePhoto);
            this.Controls.Add(this.ifPlayerLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.content);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sheet";
            this.Text = "Ficha";
            this.Load += new System.EventHandler(this.Sheet_Load);
            this.content.ResumeLayout(false);
            this.SecAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nameSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePhoto;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ifPlayerLabel;
        private System.Windows.Forms.Panel SecAttributes;
        private System.Windows.Forms.Label SecAttributesLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.RichTextBox typeTextBox;
        private System.Windows.Forms.PictureBox descriptionSave;
        private System.Windows.Forms.PictureBox typeSave;
        private System.Windows.Forms.PictureBox nameSave;
        private System.Windows.Forms.PictureBox nameExit;
        private System.Windows.Forms.PictureBox typeExit;
        private System.Windows.Forms.PictureBox descriptionExit;
    }
}