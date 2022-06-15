namespace MasmorraDoMestre.View
{
    partial class CreateSheet
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
            this.borderChangePanel = new System.Windows.Forms.Panel();
            this.changePanel = new System.Windows.Forms.Panel();
            this.npcRadioButton = new System.Windows.Forms.RadioButton();
            this.playerRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.typePanel = new System.Windows.Forms.Panel();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.foto5 = new System.Windows.Forms.Label();
            this.foto4 = new System.Windows.Forms.Label();
            this.foto3 = new System.Windows.Forms.Label();
            this.foto2 = new System.Windows.Forms.Label();
            this.foto1 = new System.Windows.Forms.Label();
            this.openSelect = new System.Windows.Forms.PictureBox();
            this.selectOptionLabel = new System.Windows.Forms.Label();
            this.profilePhoto = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Panel();
            this.cancelLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Panel();
            this.addLabel = new System.Windows.Forms.Label();
            this.itemTitleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.borderChangePanel.SuspendLayout();
            this.changePanel.SuspendLayout();
            this.typePanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.selectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).BeginInit();
            this.cancelButton.SuspendLayout();
            this.addButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderChangePanel
            // 
            this.borderChangePanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.borderChangePanel.Controls.Add(this.changePanel);
            this.borderChangePanel.Location = new System.Drawing.Point(0, 0);
            this.borderChangePanel.Margin = new System.Windows.Forms.Padding(0);
            this.borderChangePanel.Name = "borderChangePanel";
            this.borderChangePanel.Padding = new System.Windows.Forms.Padding(1);
            this.borderChangePanel.Size = new System.Drawing.Size(540, 405);
            this.borderChangePanel.TabIndex = 6;
            this.borderChangePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.borderChangePanel_Paint);
            // 
            // changePanel
            // 
            this.changePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePanel.Controls.Add(this.npcRadioButton);
            this.changePanel.Controls.Add(this.playerRadioButton);
            this.changePanel.Controls.Add(this.label4);
            this.changePanel.Controls.Add(this.typePanel);
            this.changePanel.Controls.Add(this.label2);
            this.changePanel.Controls.Add(this.namePanel);
            this.changePanel.Controls.Add(this.label3);
            this.changePanel.Controls.Add(this.selectPanel);
            this.changePanel.Controls.Add(this.openSelect);
            this.changePanel.Controls.Add(this.selectOptionLabel);
            this.changePanel.Controls.Add(this.profilePhoto);
            this.changePanel.Controls.Add(this.cancelButton);
            this.changePanel.Controls.Add(this.addButton);
            this.changePanel.Controls.Add(this.itemTitleLabel);
            this.changePanel.Controls.Add(this.label5);
            this.changePanel.Controls.Add(this.descriptionTextBox);
            this.changePanel.Location = new System.Drawing.Point(4, 4);
            this.changePanel.Name = "changePanel";
            this.changePanel.Size = new System.Drawing.Size(532, 397);
            this.changePanel.TabIndex = 11;
            // 
            // npcRadioButton
            // 
            this.npcRadioButton.AutoSize = true;
            this.npcRadioButton.Location = new System.Drawing.Point(410, 198);
            this.npcRadioButton.Name = "npcRadioButton";
            this.npcRadioButton.Size = new System.Drawing.Size(47, 17);
            this.npcRadioButton.TabIndex = 21;
            this.npcRadioButton.TabStop = true;
            this.npcRadioButton.Text = "NPC";
            this.npcRadioButton.UseVisualStyleBackColor = true;
            this.npcRadioButton.Click += new System.EventHandler(this.npcRadioButton_CheckedChanged);
            // 
            // playerRadioButton
            // 
            this.playerRadioButton.AutoSize = true;
            this.playerRadioButton.Location = new System.Drawing.Point(410, 175);
            this.playerRadioButton.Name = "playerRadioButton";
            this.playerRadioButton.Size = new System.Drawing.Size(54, 17);
            this.playerRadioButton.TabIndex = 20;
            this.playerRadioButton.TabStop = true;
            this.playerRadioButton.Text = "Player";
            this.playerRadioButton.UseVisualStyleBackColor = true;
            this.playerRadioButton.Click += new System.EventHandler(this.playerRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 68);
            this.label4.TabIndex = 19;
            this.label4.Text = "Esta ficha é de um player ou de um NPC?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typePanel
            // 
            this.typePanel.BackColor = System.Drawing.Color.White;
            this.typePanel.Controls.Add(this.typeTextBox);
            this.typePanel.Location = new System.Drawing.Point(249, 112);
            this.typePanel.Name = "typePanel";
            this.typePanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.typePanel.Size = new System.Drawing.Size(268, 40);
            this.typePanel.TabIndex = 18;
            // 
            // typeTextBox
            // 
            this.typeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(0, 8);
            this.typeTextBox.MaxLength = 100;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(268, 23);
            this.typeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 40);
            this.label2.TabIndex = 17;
            this.label2.Text = "Raça:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.White;
            this.namePanel.Controls.Add(this.nameTextBox);
            this.namePanel.Location = new System.Drawing.Point(249, 66);
            this.namePanel.Name = "namePanel";
            this.namePanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.namePanel.Size = new System.Drawing.Size(268, 40);
            this.namePanel.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(0, 8);
            this.nameTextBox.MaxLength = 200;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectPanel
            // 
            this.selectPanel.AutoScroll = true;
            this.selectPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectPanel.Controls.Add(this.foto5);
            this.selectPanel.Controls.Add(this.foto4);
            this.selectPanel.Controls.Add(this.foto3);
            this.selectPanel.Controls.Add(this.foto2);
            this.selectPanel.Controls.Add(this.foto1);
            this.selectPanel.Location = new System.Drawing.Point(16, 226);
            this.selectPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(135, 39);
            this.selectPanel.TabIndex = 14;
            this.selectPanel.Visible = false;
            // 
            // foto5
            // 
            this.foto5.BackColor = System.Drawing.Color.DimGray;
            this.foto5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foto5.Location = new System.Drawing.Point(3, 101);
            this.foto5.Margin = new System.Windows.Forms.Padding(0);
            this.foto5.Name = "foto5";
            this.foto5.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.foto5.Size = new System.Drawing.Size(113, 25);
            this.foto5.TabIndex = 19;
            this.foto5.Text = "Diana";
            this.foto5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foto5.Click += new System.EventHandler(this.foto5_Click);
            // 
            // foto4
            // 
            this.foto4.BackColor = System.Drawing.Color.DimGray;
            this.foto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foto4.Location = new System.Drawing.Point(3, 76);
            this.foto4.Margin = new System.Windows.Forms.Padding(0);
            this.foto4.Name = "foto4";
            this.foto4.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.foto4.Size = new System.Drawing.Size(113, 25);
            this.foto4.TabIndex = 18;
            this.foto4.Text = "Dalibor";
            this.foto4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foto4.Click += new System.EventHandler(this.foto4_Click);
            // 
            // foto3
            // 
            this.foto3.BackColor = System.Drawing.Color.DimGray;
            this.foto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foto3.Location = new System.Drawing.Point(3, 51);
            this.foto3.Margin = new System.Windows.Forms.Padding(0);
            this.foto3.Name = "foto3";
            this.foto3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.foto3.Size = new System.Drawing.Size(113, 25);
            this.foto3.TabIndex = 17;
            this.foto3.Text = "Eva";
            this.foto3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foto3.Click += new System.EventHandler(this.foto3_Click);
            // 
            // foto2
            // 
            this.foto2.BackColor = System.Drawing.Color.DimGray;
            this.foto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foto2.Location = new System.Drawing.Point(3, 26);
            this.foto2.Margin = new System.Windows.Forms.Padding(0);
            this.foto2.Name = "foto2";
            this.foto2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.foto2.Size = new System.Drawing.Size(113, 25);
            this.foto2.TabIndex = 16;
            this.foto2.Text = "Max";
            this.foto2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foto2.Click += new System.EventHandler(this.foto2_Click);
            // 
            // foto1
            // 
            this.foto1.BackColor = System.Drawing.Color.DimGray;
            this.foto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foto1.Location = new System.Drawing.Point(3, 1);
            this.foto1.Margin = new System.Windows.Forms.Padding(0);
            this.foto1.Name = "foto1";
            this.foto1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.foto1.Size = new System.Drawing.Size(113, 25);
            this.foto1.TabIndex = 15;
            this.foto1.Text = "Thyri";
            this.foto1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foto1.Click += new System.EventHandler(this.foto1_Click);
            // 
            // openSelect
            // 
            this.openSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.openSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openSelect.Image = global::MasmorraDoMestre.Properties.Resources.setaBaixo;
            this.openSelect.Location = new System.Drawing.Point(125, 207);
            this.openSelect.Margin = new System.Windows.Forms.Padding(0);
            this.openSelect.Name = "openSelect";
            this.openSelect.Size = new System.Drawing.Size(19, 19);
            this.openSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openSelect.TabIndex = 13;
            this.openSelect.TabStop = false;
            this.openSelect.Click += new System.EventHandler(this.openSelect_Click);
            // 
            // selectOptionLabel
            // 
            this.selectOptionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectOptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectOptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOptionLabel.Location = new System.Drawing.Point(16, 204);
            this.selectOptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.selectOptionLabel.Name = "selectOptionLabel";
            this.selectOptionLabel.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.selectOptionLabel.Size = new System.Drawing.Size(135, 25);
            this.selectOptionLabel.TabIndex = 12;
            this.selectOptionLabel.Text = "Thyri";
            this.selectOptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profilePhoto
            // 
            this.profilePhoto.Image = global::MasmorraDoMestre.Properties.Resources.image1;
            this.profilePhoto.Location = new System.Drawing.Point(16, 66);
            this.profilePhoto.Name = "profilePhoto";
            this.profilePhoto.Size = new System.Drawing.Size(135, 135);
            this.profilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhoto.TabIndex = 11;
            this.profilePhoto.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Controls.Add(this.cancelLabel);
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(4, 357);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(10);
            this.cancelButton.Size = new System.Drawing.Size(90, 35);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Click += new System.EventHandler(this.backToSystemForm_Click);
            this.cancelButton.Paint += new System.Windows.Forms.PaintEventHandler(this.cancelLabel_Paint);
            // 
            // cancelLabel
            // 
            this.cancelLabel.BackColor = System.Drawing.Color.Transparent;
            this.cancelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.cancelLabel.ForeColor = System.Drawing.Color.White;
            this.cancelLabel.Location = new System.Drawing.Point(10, 10);
            this.cancelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cancelLabel.Name = "cancelLabel";
            this.cancelLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cancelLabel.Size = new System.Drawing.Size(70, 15);
            this.cancelLabel.TabIndex = 4;
            this.cancelLabel.Text = "CANCELAR";
            this.cancelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelLabel.Click += new System.EventHandler(this.backToSystemForm_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Controls.Add(this.addLabel);
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(437, 357);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(10);
            this.addButton.Size = new System.Drawing.Size(90, 35);
            this.addButton.TabIndex = 9;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.Paint += new System.Windows.Forms.PaintEventHandler(this.alterLabel_Paint);
            // 
            // addLabel
            // 
            this.addLabel.BackColor = System.Drawing.Color.Transparent;
            this.addLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.addLabel.ForeColor = System.Drawing.Color.White;
            this.addLabel.Location = new System.Drawing.Point(10, 10);
            this.addLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.addLabel.Size = new System.Drawing.Size(70, 15);
            this.addLabel.TabIndex = 4;
            this.addLabel.Text = "ADICIONAR";
            this.addLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addLabel.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemTitleLabel
            // 
            this.itemTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemTitleLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.itemTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.itemTitleLabel.Name = "itemTitleLabel";
            this.itemTitleLabel.Size = new System.Drawing.Size(530, 63);
            this.itemTitleLabel.TabIndex = 0;
            this.itemTitleLabel.Text = "ADICIONAR NOVA FICHA";
            this.itemTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 40);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descrição:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 268);
            this.descriptionTextBox.MaxLength = 5000000;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(521, 83);
            this.descriptionTextBox.TabIndex = 23;
            this.descriptionTextBox.Text = "";
            // 
            // CreateSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 405);
            this.Controls.Add(this.borderChangePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CreateSheet";
            this.Text = "CreateSheet";
            this.borderChangePanel.ResumeLayout(false);
            this.changePanel.ResumeLayout(false);
            this.changePanel.PerformLayout();
            this.typePanel.ResumeLayout(false);
            this.typePanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.selectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).EndInit();
            this.cancelButton.ResumeLayout(false);
            this.addButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel borderChangePanel;
        private System.Windows.Forms.Panel changePanel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.RadioButton npcRadioButton;
        private System.Windows.Forms.RadioButton playerRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.Label foto5;
        private System.Windows.Forms.Label foto4;
        private System.Windows.Forms.Label foto3;
        private System.Windows.Forms.Label foto2;
        private System.Windows.Forms.Label foto1;
        private System.Windows.Forms.PictureBox openSelect;
        private System.Windows.Forms.Label selectOptionLabel;
        private System.Windows.Forms.PictureBox profilePhoto;
        private System.Windows.Forms.Panel cancelButton;
        private System.Windows.Forms.Label cancelLabel;
        private System.Windows.Forms.Panel addButton;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label itemTitleLabel;
        private System.Windows.Forms.Label label5;
    }
}