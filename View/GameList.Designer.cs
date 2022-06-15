namespace MasmorraDoMestre.View
{
    partial class GameList
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
            this.lista = new System.Windows.Forms.Panel();
            this.systemInfo = new System.Windows.Forms.Panel();
            this.dateSystem = new System.Windows.Forms.Label();
            this.descriptionSystem = new System.Windows.Forms.Label();
            this.nameSystem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.joinPanel = new System.Windows.Forms.Panel();
            this.joinLabel = new System.Windows.Forms.Label();
            this.systemInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.joinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.AutoScroll = true;
            this.lista.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.lista.BackColor = System.Drawing.Color.Silver;
            this.lista.Location = new System.Drawing.Point(12, 13);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(514, 536);
            this.lista.TabIndex = 1;
            // 
            // systemInfo
            // 
            this.systemInfo.BackColor = System.Drawing.Color.Transparent;
            this.systemInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.systemInfo.Controls.Add(this.joinPanel);
            this.systemInfo.Controls.Add(this.dateSystem);
            this.systemInfo.Controls.Add(this.descriptionSystem);
            this.systemInfo.Controls.Add(this.nameSystem);
            this.systemInfo.Location = new System.Drawing.Point(532, 13);
            this.systemInfo.Name = "systemInfo";
            this.systemInfo.Padding = new System.Windows.Forms.Padding(10);
            this.systemInfo.Size = new System.Drawing.Size(240, 471);
            this.systemInfo.TabIndex = 10;
            // 
            // dateSystem
            // 
            this.dateSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSystem.Location = new System.Drawing.Point(12, 417);
            this.dateSystem.Margin = new System.Windows.Forms.Padding(0);
            this.dateSystem.Name = "dateSystem";
            this.dateSystem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateSystem.Size = new System.Drawing.Size(94, 39);
            this.dateSystem.TabIndex = 2;
            this.dateSystem.Text = "[Data de criação do Sistema]";
            this.dateSystem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // descriptionSystem
            // 
            this.descriptionSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionSystem.Location = new System.Drawing.Point(10, 60);
            this.descriptionSystem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.descriptionSystem.Name = "descriptionSystem";
            this.descriptionSystem.Padding = new System.Windows.Forms.Padding(1);
            this.descriptionSystem.Size = new System.Drawing.Size(218, 349);
            this.descriptionSystem.TabIndex = 1;
            this.descriptionSystem.Text = "[Descrição do Sistema]";
            // 
            // nameSystem
            // 
            this.nameSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSystem.Location = new System.Drawing.Point(10, 10);
            this.nameSystem.Margin = new System.Windows.Forms.Padding(0);
            this.nameSystem.Name = "nameSystem";
            this.nameSystem.Size = new System.Drawing.Size(218, 45);
            this.nameSystem.TabIndex = 0;
            this.nameSystem.Text = "[Nome do Sistema]";
            this.nameSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(532, 490);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(240, 59);
            this.panel1.TabIndex = 10;
            this.panel1.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "VOLTAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // joinPanel
            // 
            this.joinPanel.BackColor = System.Drawing.Color.Transparent;
            this.joinPanel.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.joinPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.joinPanel.Controls.Add(this.joinLabel);
            this.joinPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinPanel.Location = new System.Drawing.Point(107, 417);
            this.joinPanel.Name = "joinPanel";
            this.joinPanel.Padding = new System.Windows.Forms.Padding(10);
            this.joinPanel.Size = new System.Drawing.Size(121, 39);
            this.joinPanel.TabIndex = 8;
            this.joinPanel.Click += new System.EventHandler(this.joinInSystem_Click);
            // 
            // joinLabel
            // 
            this.joinLabel.BackColor = System.Drawing.Color.Transparent;
            this.joinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.joinLabel.ForeColor = System.Drawing.Color.White;
            this.joinLabel.Location = new System.Drawing.Point(10, 10);
            this.joinLabel.Margin = new System.Windows.Forms.Padding(0);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(101, 19);
            this.joinLabel.TabIndex = 4;
            this.joinLabel.Text = "ENTRAR";
            this.joinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.joinLabel.Click += new System.EventHandler(this.joinInSystem_Click);
            // 
            // GameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.systemInfo);
            this.Controls.Add(this.lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameList";
            this.Text = "Lista de jogos";
            this.Load += new System.EventHandler(this.GameList_Load);
            this.systemInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.joinPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lista;
        private System.Windows.Forms.Panel systemInfo;
        private System.Windows.Forms.Panel joinPanel;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Label dateSystem;
        private System.Windows.Forms.Label descriptionSystem;
        private System.Windows.Forms.Label nameSystem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}