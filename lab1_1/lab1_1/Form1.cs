using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab1_1
{
    public partial class Form1 : Form
    {
        public string m_str;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void index_Click(object sender, EventArgs e)
        {
            try
            {
                int indx, a = 0;
                m_str = richTextBox1.Text;
                indx = Convert.ToInt32(richTextBox6.Text);
                for (int i = 0; i < m_str.Length; i++)
                {
                    if (i + 1 == indx)
                    {
                        richTextBox5.Text = Convert.ToString(m_str[i]);
                        a++;
                    }

                }
                if (a != 1)
                {
                    MessageBox.Show("Индекс указан неверно!");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Индекс указан неверно!");
            }
        }


       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_str = richTextBox1.Text;
            int n_words = 1 ,gl_count=0, sgl_count=0, str_len=0, n_sent=0;
            char[] gl = {'e','u','i','o','a','E','U','I','O','а','A','у','У', 'е', 'Е',
                'ы', 'Ы', 'а', 'А', 'о', 'О', 'э', 'Э', 'я', 'Я', 'и', 'И', 'ю', 'Ю'};
            char[] sgl = {'q', 'Q', 'w', 'W', 'r', 'R', 't', 'T', 'y', 'Y', 'p', 'P', 's', 'S', 'd', 'D', 'f', 'F', 'g', 'G'
                    , 'h', 'H', 'j', 'J', 'k', 'K', 'l', 'L','z','Z' ,'x','X','c','C','v','V','b','B','n','N','m','M',
            'й','Й','ц','Ц','к','К','н','Н','г','Г','ш','Ш','щ','з','З','х','Х','ъ','Ъ','ф','Ф','в','В','п','П',
                'р','Р','л','Л','д','Д','ж','Ж','ч','Ч','с','С','м','М','т','Т','ь','Ь','б','Б'};



            switch (comboBox1.Text)
            {
                case "количество гласных":
                    for (int i = 0; i < m_str.Length; i++)
                    {
                        for (int j = 0; j < gl.Length; j++)
                        {
                            if ( m_str[i]== gl[j])
                            {
                                gl_count++;
                            }
                        }
                    }
                    richTextBox5.Text = Convert.ToString(gl_count);
                    break;
                case "количество согласных":
                    for (int i = 0; i < m_str.Length; i++)
                    {
                        for (int j = 0; j < sgl.Length; j++)
                        {
                            if (m_str[i] == sgl[j])
                            {
                                sgl_count++;
                            }
                        }
                    }
                    richTextBox5.Text = Convert.ToString(sgl_count);
                    break;
                case "количество слов":
                   
                    string pattern = @"\b(\w+)\b";
                    int n = 0;
                    foreach (Match match in Regex.Matches(richTextBox1.Text, pattern))
                    {
                        n++;
                    }

                    //if (m_str[f - 1] == ' ')
                    //{
                    //    n_words -= 1;
                    //}

                    richTextBox5.Text = Convert.ToString(n);
                    break;
                case "количество предложений":
                    foreach (char c in m_str)
                    {

                        if (c == '.' || c == '!' || c == '?' || c == ';')
                        {
                            n_sent++;
                        }
                        
                    }
                    richTextBox5.Text = Convert.ToString(n_sent);
                    break;
                case "длину строки":
                    str_len = m_str.Length;
                    //foreach (char c in m_str)
                    //{
                    //    str_len++;                                            
                    //}
                    richTextBox5.Text = Convert.ToString(str_len);
                    break;

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string substr;
           
            m_str = richTextBox1.Text;
            substr = richTextBox2.Text;
            int k = m_str.IndexOf(substr);
            if (k == -1)
            {
                MessageBox.Show("Индекс указан неверно!");
            }
            else
            { 
                m_str = m_str.Remove(k, substr.Length);
            }
            richTextBox5.Text = Convert.ToString(m_str);
        }

        private void res_Click(object sender, EventArgs e)
        {
            string p_str1, p_str2;
            p_str1 = richTextBox3.Text;
            p_str2 = richTextBox4.Text;
            m_str = richTextBox1.Text;
            m_str = m_str.Replace(p_str1, p_str2);
            richTextBox5.Text = Convert.ToString(m_str);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
