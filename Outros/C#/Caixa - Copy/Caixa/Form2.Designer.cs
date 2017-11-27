namespace Caixa
{
    partial class word
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
            this.criar_bt = new System.Windows.Forms.Button();
            this.substituir_bt = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivosPadrõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // criar_bt
            // 
            this.criar_bt.Location = new System.Drawing.Point(101, 149);
            this.criar_bt.Name = "criar_bt";
            this.criar_bt.Size = new System.Drawing.Size(92, 45);
            this.criar_bt.TabIndex = 0;
            this.criar_bt.Text = "Criar";
            this.criar_bt.UseVisualStyleBackColor = true;
            this.criar_bt.Click += new System.EventHandler(this.criar_bt_Click);
            // 
            // substituir_bt
            // 
            this.substituir_bt.Location = new System.Drawing.Point(101, 102);
            this.substituir_bt.Name = "substituir_bt";
            this.substituir_bt.Size = new System.Drawing.Size(92, 45);
            this.substituir_bt.TabIndex = 1;
            this.substituir_bt.Text = "Substituir";
            this.substituir_bt.UseVisualStyleBackColor = true;
            this.substituir_bt.Click += new System.EventHandler(this.substituir_bt_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Location = new System.Drawing.Point(-3, 33);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(301, 245);
            this.Tab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.criar_bt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.substituir_bt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Substituir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosPadrõesToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // arquivosPadrõesToolStripMenuItem
            // 
            this.arquivosPadrõesToolStripMenuItem.Name = "arquivosPadrõesToolStripMenuItem";
            this.arquivosPadrõesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.arquivosPadrõesToolStripMenuItem.Text = "Arquivos e pastas padrões...";
            this.arquivosPadrõesToolStripMenuItem.Click += new System.EventHandler(this.arquivosPadrõesToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratoToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contratoToolStripMenuItem.Text = "Contrato";
            this.contratoToolStripMenuItem.Click += new System.EventHandler(this.contratoToolStripMenuItem_Click);
            // 
            // word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 681);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.menuStrip1);
            this.Name = "word";
            this.Text = "Tela principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.word_FormClosing);
            this.Load += new System.EventHandler(this.word_Load);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button criar_bt;
        private System.Windows.Forms.Button substituir_bt;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivosPadrõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem;
    }
}