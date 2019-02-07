using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Novacode;

namespace Caixa
{
    public partial class word : Form
    {
        // functions functions = new functions();
        
        string[,] subst = new string[2, 2] { { "Declaração", "Eu te amo" }, { "a", "a+" } };
        List<TextBox> box_principal = new List<TextBox>();
        List<Label> label_principal = new List<Label>();

        public word()
        {
            InitializeComponent();
        }

       
        private void substituir_bt_Click(object sender, EventArgs e)
        {
            substituidor(subst);
        }
        
        private void criar_bt_Click(object sender, EventArgs e)
        {
           


            for (int i = 0; i < 50; i++)
            {
                int position = i * 30;

                box_principal.Add(new TextBox());
                box_principal[i].Name = "textBox_"+i;
                box_principal[i].Text = "oi "+i;
                box_principal[i].Location = new Point(120, 10+ position);
                box_principal[i].TabIndex = 0;
                tabPage1.Controls.Add(box_principal[i]);

                label_principal.Add(new Label());
                label_principal[i].Name = "label_"+i;
                label_principal[i].Text = "oidfg "+i;
                label_principal[i].Location = new Point(20, 12+ position);
                label_principal[i].TabIndex = 0;
                tabPage1.Controls.Add(label_principal[i]);
                

                /*
            TextBox txt = new TextBox();
            txt.Name = "textBox145";
            txt.Text = "helloo";
            txt.Location = new Point(120, 10);
            txt.TabIndex = 0;
            tabPage1.Controls.Add(txt);

            Label lbl = new Label();
            lbl.Name = "label65465";
            lbl.BringToFront();
            lbl.Text = "I am a label";
            lbl.Location = new Point(20, 12);
            lbl.TabIndex = 0;
            tabPage1.Controls.Add(lbl);
            */
            }



        }

        public void substituidor (string[,] subst)
        {
            // We will need a file name for our output file (change to suit your machine):
            string origem = functions.word_open();
            if (origem != null)
            {
                // Let's save the file with a meaningful name, including the 
                // applicant name and the letter date:
                string destino = functions.word_save();
                if (destino != null)
                {
                    DocX letter = DocX.Load(origem);

                    // Perform the replace:
                    for (int i = 0; i < subst.GetLength(0); i++)
                    {
                        letter.ReplaceText(subst[i, 0], subst[i, 1]);

                    }

                    // Save as New filename:
                    letter.SaveAs(destino);
                }
            }
        }
        
        private void word_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void arquivosPadrõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void word_Load(object sender, EventArgs e)
        {

        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Form_nomes form3 = new Form_nomes(); // Instantiate a Form3 object.
            form3.Show(); // Show Form3 and
            */
        }
    }
}







