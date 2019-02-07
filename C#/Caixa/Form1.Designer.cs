namespace Caixa
{
    partial class Form1
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ok = new System.Windows.Forms.Button();
            this.user_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sdfdsf = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // Ok
            // 
            resources.ApplyResources(this.Ok, "Ok");
            this.Ok.Name = "Ok";
            this.Ok.UseMnemonic = false;
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // user_text
            // 
            this.user_text.AcceptsTab = true;
            resources.ApplyResources(this.user_text, "user_text");
            this.user_text.Name = "user_text";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // sdfdsf
            // 
            resources.ApplyResources(this.sdfdsf, "sdfdsf");
            this.sdfdsf.Name = "sdfdsf";
            // 
            // pass_text
            // 
            this.pass_text.AcceptsTab = true;
            resources.ApplyResources(this.pass_text, "pass_text");
            this.pass_text.Name = "pass_text";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.sdfdsf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.Ok);
            this.Controls.Add(pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sdfdsf;
        private System.Windows.Forms.TextBox pass_text;
    }
}

