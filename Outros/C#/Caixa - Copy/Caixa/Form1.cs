using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace Caixa
{
  
    public partial class Form1 : Form
    {
        public string user;
        public string pass;
        public MySqlCommand command;
        public MySqlDataReader reader;
        MySqlConnection con = new MySqlConnection();
        

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        public Form1()
        {
            InitializeComponent();
        }


        public void logar()
        {
            
            //command.CommandText = "Select " + user + "from principal where sen="+pass;

            try
            {
                con.ConnectionString = "server=sossegai.com;user id=sossegai;persistsecurityinfo=True;database=sossegai_clientes;password=9903al@A";
                MySqlCommand command = con.CreateCommand();
                //command.CommandText = "Update principal SET pass='kkkk' WHERE user='"+user+"'";
                //command.CommandText = "Insert into principal (user,pass) values('"+user+"','"+pass+"')";
                command.CommandText = "Select * from principal where user='" + user + "' and pass='" + pass + "'";
                con.Open();
                int cont = 0;
                reader = command.ExecuteReader();
              
                while (reader.Read())
                {
                    cont++;
            
                 }

                // command.ExecuteNonQuery();
                con.Close();

                if (cont > 0) {
                    /*
                    Form Form2 = new word(); // Instantiate a Form3 object.
                    word.Show(); // Show Form3 and
                    this.Close(); // closes the Form2 instance.
                    */
                }
                else{
                    MessageBox.Show("Usuário ou senha incorreto");
                }

               

            }
            catch (Exception e1)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados porque: " + e1.ToString());
                Application.Exit();
            }

        }
        

        private void Ok_Click(object sender, EventArgs e)
        {
           user = user_text.Text;
           pass = pass_text.Text;
            enable_all(false);
            // logar();
            // // closes the Form2 instance.
            word Form2 = new word(); // Instantiate a Form3 object.
            Form2.Show(); // Show Form3 and
                          // this.Dispose();
            Visible = false;
           
        }

        public void enable_all(bool status)
        {
            Ok.Enabled = status;
            user_text.Enabled = status;
            pass_text.Enabled = status;
        }
        
       
    }
}
