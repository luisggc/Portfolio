
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
    class functions
    {

       
        public static string word_open()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string result = null;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Documentos do Word|*.docx;*.doc";
            //openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            result = Path.GetFullPath(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    MessageBox.Show("Erro: não foi possível ler o arquivo" + ex.Message);


                }
            }
            return result;

        }

       
        

    
        public static string valorExtenso(Decimal valor)
        {

            string[] struni = new string[] { "", "Um", "Dois", "Tres", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezessis", "Dezessete", "Dezoito", "Dezenove", "Vinte" };
            string[] strdez = new string[] { "", "", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
            List<string[]> strcen = new List<string[]>() { new string[] { "", "" }, new string[] { "Cem", "Cento" }, new string[] { "Duzentos", "Duzentos" }, new string[] { "Trezentos", "Trezentos" }, new string[] { "Quatrocentos", "Quatrocentos" }, new string[] { "Quinhentos", "Quinhentos" }, new string[] { "Seiscentos", "Seiscentos" }, new string[] { "Setecentos", "Setecentos" }, new string[] { "Oitocentos", "Oitocentos" }, new string[] { "Novecentos", "Novecentos" } };
            List<string[]> moeda = new List<string[]>() { new string[] { " Trilhao", " Trilhoes" }, new string[] { " Bilhao", " Bilhoes" }, new string[] { " Milhao", " Milhoes" }, new string[] { " Mil", " Mil" }, new string[] { " Real", " Reais" }, new string[] { " Centavo", " Centavos" }, };
            List<string[]> result = new List<string[]>();
            string[] arrValor = Decimal.Round(valor, 2).ToString("0|0|0,0|0|0,0|0|0,0|0|0,0|0|0.0|0").Replace(",", ",0|").Replace(",", ".").Split('.');
            for (int i = arrValor.Length - 1; i >= 0; i--)
            {
                string[] z = arrValor[i].Split('|');
                int a = Convert.ToInt32(z[0]);
                int b = Convert.ToInt32(z[1]);
                int c = Convert.ToInt32(z[2]);
                int d = Convert.ToInt32(b.ToString() + c.ToString());
                int k = Convert.ToInt32(a.ToString() + b.ToString() + c.ToString());
                string r = (d >= 1 && d <= 20) ? string.Format("{0}", k == 0 ? "" : struni[d]) : string.Format("{0}{1}{2}", strdez[b], c > 0 ? " e " : "", k == 0 ? "" : struni[c]);
                r = k < 100 ? r : string.Format("{0}{1}{2}", strcen[a][d == 0 ? 0 : 1], d == 0 ? "" : " e ", r);
                result.Add(new string[] { i.ToString(), k.ToString(), r, " e ", moeda[i][k == 1 ? 0 : 1] });
            }
            if (Convert.ToInt32(result[1][1]) == 0)
            {
                string xmoeda = result[1][4];
                for (int i = 2; i <= result.Count - 1; i++)
                {
                    if (Convert.ToInt32(result[i][1]) > 0)
                    {
                        result[i][4] += " " + (i == 3 || i == 4 || i == 5 ? " de " : "") + xmoeda;
                        result[i][3] = " e ";
                        break;
                    }
                }
            }
            for (int i = result.Count - 1; i >= 0; i--) { if (Convert.ToInt32(result[i][1]) == 0) result.Remove(result[i]); }
            result[0][3] = "";
            for (int i = 2; i <= result.Count - 1; i++) { result[i][3] = ", "; }
            string extenso = "";
            for (int i = 0; i <= result.Count - 1; i++) { extenso = result[i][2] + result[i][4] + result[i][3] + extenso; }
            return extenso.Replace("  ", " ").Replace("  ", " ").Replace("  ", " ").Replace("  ", " ").Replace("  ", " ");

        }
        ///////////

        public static string word_save()
        {

            string result = null;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "Documentos do Word|*.docx";

            saveFileDialog1.Title = "Salvar Documento";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                result = Path.GetFullPath(saveFileDialog1.FileName);
            }

            return result;
        }

    }
}
