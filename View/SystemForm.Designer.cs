namespace MasmorraDoMestre.View
{
    partial class SystemForm
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
            this.nameSystem = new System.Windows.Forms.Label();
            this.descriptionSystem = new System.Windows.Forms.Label();
            this.systemInfos = new System.Windows.Forms.Panel();
            this.sheetsList = new System.Windows.Forms.Panel();
            this.addSheet = new System.Windows.Forms.Panel();
            this.addSheetLabel = new System.Windows.Forms.Label();
            this.addSheetPlus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.backLabel = new System.Windows.Forms.Label();
            this.systemInfos.SuspendLayout();
            this.sheetsList.SuspendLayout();
            this.addSheet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameSystem
            // 
            this.nameSystem.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSystem.Location = new System.Drawing.Point(16, 9);
            this.nameSystem.Margin = new System.Windows.Forms.Padding(0);
            this.nameSystem.Name = "nameSystem";
            this.nameSystem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.nameSystem.Size = new System.Drawing.Size(759, 26);
            this.nameSystem.TabIndex = 1;
            this.nameSystem.Text = "[Nome do Sistema]";
            this.nameSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionSystem
            // 
            this.descriptionSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionSystem.Location = new System.Drawing.Point(13, 40);
            this.descriptionSystem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.descriptionSystem.Name = "descriptionSystem";
            this.descriptionSystem.Padding = new System.Windows.Forms.Padding(1);
            this.descriptionSystem.Size = new System.Drawing.Size(762, 45);
            this.descriptionSystem.TabIndex = 2;
            this.descriptionSystem.Text = "[Descrição do Sistema]";
            // 
            // systemInfos
            // 
            this.systemInfos.Controls.Add(this.nameSystem);
            this.systemInfos.Controls.Add(this.descriptionSystem);
            this.systemInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.systemInfos.Location = new System.Drawing.Point(0, 0);
            this.systemInfos.Name = "systemInfos";
            this.systemInfos.Size = new System.Drawing.Size(784, 90);
            this.systemInfos.TabIndex = 3;
            // 
            // sheetsList
            // 
            this.sheetsList.AutoScroll = true;
            this.sheetsList.BackColor = System.Drawing.Color.Silver;
            this.sheetsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sheetsList.Controls.Add(this.addSheet);
            this.sheetsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetsList.Location = new System.Drawing.Point(0, 90);
            this.sheetsList.Name = "sheetsList";
            this.sheetsList.Size = new System.Drawing.Size(784, 471);
            this.sheetsList.TabIndex = 4;
            // 
            // addSheet
            // 
            this.addSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addSheet.Controls.Add(this.addSheetLabel);
            this.addSheet.Controls.Add(this.addSheetPlus);
            this.addSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSheet.Location = new System.Drawing.Point(2, 3);
            this.addSheet.Name = "addSheet";
            this.addSheet.Padding = new System.Windows.Forms.Padding(5);
            this.addSheet.Size = new System.Drawing.Size(190, 190);
            this.addSheet.TabIndex = 0;
            this.addSheet.Click += new System.EventHandler(this.addSheet_Click);
            // 
            // addSheetLabel
            // 
            this.addSheetLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSheetLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addSheetLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSheetLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addSheetLabel.Location = new System.Drawing.Point(5, 149);
            this.addSheetLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addSheetLabel.Name = "addSheetLabel";
            this.addSheetLabel.Size = new System.Drawing.Size(178, 34);
            this.addSheetLabel.TabIndex = 1;
            this.addSheetLabel.Text = "Adicionar nova ficha";
            this.addSheetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addSheetLabel.Click += new System.EventHandler(this.addSheet_Click);
            // 
            // addSheetPlus
            // 
            this.addSheetPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSheetPlus.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSheetPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSheetPlus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addSheetPlus.Location = new System.Drawing.Point(5, 5);
            this.addSheetPlus.Margin = new System.Windows.Forms.Padding(0);
            this.addSheetPlus.Name = "addSheetPlus";
            this.addSheetPlus.Size = new System.Drawing.Size(178, 144);
            this.addSheetPlus.TabIndex = 0;
            this.addSheetPlus.Text = " +";
            this.addSheetPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addSheetPlus.Click += new System.EventHandler(this.addSheet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.backPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 49);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(460, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(170, 39);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIAR CONBATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backPanel
            // 
            this.backPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backPanel.BackColor = System.Drawing.Color.Transparent;
            this.backPanel.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.backLabel);
            this.backPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPanel.Location = new System.Drawing.Point(165, 5);
            this.backPanel.Name = "backPanel";
            this.backPanel.Padding = new System.Windows.Forms.Padding(10);
            this.backPanel.Size = new System.Drawing.Size(121, 39);
            this.backPanel.TabIndex = 9;
            this.backPanel.Click += new System.EventHandler(this.backToGameList_Click);
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.backLabel.ForeColor = System.Drawing.Color.White;
            this.backLabel.Location = new System.Drawing.Point(10, 10);
            this.backLabel.Margin = new System.Windows.Forms.Padding(0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(101, 19);
            this.backLabel.TabIndex = 4;
            this.backLabel.Text = "VOLTAR";
            this.backLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backLabel.Click += new System.EventHandler(this.backToGameList_Click);
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sheetsList);
            this.Controls.Add(this.systemInfos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SystemForm";
            this.Text = "SystemForm";
            this.Load += new System.EventHandler(this.SystemForm_Load);
            this.systemInfos.ResumeLayout(false);
            this.sheetsList.ResumeLayout(false);
            this.addSheet.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameSystem;
        private System.Windows.Forms.Label descriptionSystem;
        private System.Windows.Forms.Panel systemInfos;
        private System.Windows.Forms.Panel sheetsList;
        private System.Windows.Forms.Panel addSheet;
        private System.Windows.Forms.Label addSheetPlus;
        private System.Windows.Forms.Label addSheetLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}