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
    public partial class Form3 : Form
    {
        private Form1 parentForm;
        public Room roomObj;
        public DialogResult res;
        public Form3(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            type.Clear();
            window_n.Clear();
            space.Clear();
            side.SelectedIndex = -1;
           
           
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Room room = new Room(type.Text,space.Text,window_n.Text,side.Text
            // заплняем данными
            )
            {
                //room = "7.77"
            };

            roomObj = room;
            var results = new List<ValidationResult>();
            var context = new ValidationContext(room);
            if (!Validator.TryValidateObject(room, context, results, true))
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
        

    }

}
