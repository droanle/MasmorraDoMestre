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
            this.joinPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateSystem = new System.Windows.Forms.Label();
            this.descriptionSystem = new System.Windows.Forms.Label();
            this.nameSystem = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Label();
            this.configPanel = new System.Windows.Forms.Panel();
            this.config = new System.Windows.Forms.Label();
            this.systemInfo.SuspendLayout();
            this.joinPanel.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.configPanel.SuspendLayout();
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
            this.systemInfo.Size = new System.Drawing.Size(240, 406);
            this.systemInfo.TabIndex = 10;
            // 
            // joinPanel
            // 
            this.joinPanel.BackColor = System.Drawing.Color.Transparent;
            this.joinPanel.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.joinPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.joinPanel.Controls.Add(this.label4);
            this.joinPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinPanel.Location = new System.Drawing.Point(104, 355);
            this.joinPanel.Name = "joinPanel";
            this.joinPanel.Padding = new System.Windows.Forms.Padding(10);
            this.joinPanel.Size = new System.Drawing.Size(121, 39);
            this.joinPanel.TabIndex = 8;
            this.joinPanel.Click += new System.EventHandler(this.joinInSystem_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "ENTRAR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.joinInSystem_Click);
            // 
            // dateSystem
            // 
            this.dateSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSystem.Location = new System.Drawing.Point(11, 355);
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
            this.descriptionSystem.Size = new System.Drawing.Size(218, 287);
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
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.Transparent;
            this.deletePanel.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.deletePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletePanel.Controls.Add(this.delete);
            this.deletePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePanel.Location = new System.Drawing.Point(532, 490);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Padding = new System.Windows.Forms.Padding(20);
            this.deletePanel.Size = new System.Drawing.Size(240, 59);
            this.deletePanel.TabIndex = 9;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.delete.Location = new System.Drawing.Point(20, 20);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(200, 19);
            this.delete.TabIndex = 4;
            this.delete.Text = "DELETAR SISTEMA";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // configPanel
            // 
            this.configPanel.BackColor = System.Drawing.Color.Transparent;
            this.configPanel.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.configPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configPanel.Controls.Add(this.config);
            this.configPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configPanel.Location = new System.Drawing.Point(532, 425);
            this.configPanel.Name = "configPanel";
            this.configPanel.Padding = new System.Windows.Forms.Padding(20);
            this.configPanel.Size = new System.Drawing.Size(240, 59);
            this.configPanel.TabIndex = 7;
            // 
            // config
            // 
            this.config.BackColor = System.Drawing.Color.Transparent;
            this.config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.config.Location = new System.Drawing.Point(20, 20);
            this.config.Margin = new System.Windows.Forms.Padding(0);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(200, 19);
            this.config.TabIndex = 4;
            this.config.Text = "CRIAR NOVO SISTEMA";
            this.config.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.systemInfo);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.configPanel);
            this.Controls.Add(this.lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameList";
            this.Text = "Lista de jogos";
            this.Load += new System.EventHandler(this.GameList_Load);
            this.systemInfo.ResumeLayout(false);
            this.joinPanel.ResumeLayout(false);
            this.deletePanel.ResumeLayout(false);
            this.configPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lista;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Panel configPanel;
        private System.Windows.Forms.Label config;
        private System.Windows.Forms.Panel systemInfo;
        private System.Windows.Forms.Panel joinPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateSystem;
        private System.Windows.Forms.Label descriptionSystem;
        private System.Windows.Forms.Label nameSystem;
    }
}