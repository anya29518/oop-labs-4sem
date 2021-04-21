using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        public Address addrObj;
        public DialogResult res;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
           
            Address addr = new Address(country.Text, city.Text, area.Text, street.Text,
                house.Text, corpus.Text, door.Text, floor.Text, flat.Text);
                        
            addrObj = addr;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(addr);
            if (!Validator.TryValidateObject(addr, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                    res = DialogResult.Cancel;
                    
                }
            }
            else
            {
                res = DialogResult.OK;
            }
            

        }

       

        private void button_clear_Click(object sender, EventArgs e)
        {
            country.Clear();
            city.Clear();
            area.Clear();
            street.Clear();
            house.Clear();
            corpus.Clear();
            door.Clear();
            floor.Clear();
            flat.Clear();
        }
    }
}
