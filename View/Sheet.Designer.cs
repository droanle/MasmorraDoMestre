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
            this.profilePhoto = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).BeginInit();
            this.content.SuspendLayout();
            this.SecAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePhoto
            // 
            this.profilePhoto.Image = global::MasmorraDoMestre.Properties.Resources.image2;
            this.profilePhoto.Location = new System.Drawing.Point(12, 12);
            this.profilePhoto.Name = "profilePhoto";
            this.profilePhoto.Size = new System.Drawing.Size(134, 135);
            this.profilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhoto.TabIndex = 1;
            this.profilePhoto.TabStop = false;
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
            // Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).EndInit();
            this.content.ResumeLayout(false);
            this.SecAttributes.ResumeLayout(false);
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
    }
}