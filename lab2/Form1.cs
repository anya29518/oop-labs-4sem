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
using System.Collections;
using System.IO;
using System.Xml.Serialization;

namespace lab2
{
    public partial class Form1 : Form

    {
        public DialogResult r;
        public Form1()
        {
            InitializeComponent();
            DateOfBuild.MaxDate = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rooms_number_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_addres_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            DialogResult result = form2.ShowDialog();
            if(result == DialogResult.OK && form2.res== DialogResult.OK)
            {
                Address_comboBox.Items.Add(form2.addrObj);
                button_addres.BackColor = Color.Empty;
            }
            else 
            {
                button_addres.BackColor = Color.Red;
               
            }
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            Form3 roomForm = new Form3(this);
            DialogResult result = roomForm.ShowDialog();

            if (result == DialogResult.OK && roomForm.res == DialogResult.OK)
            {
                Rooms.Items.Add(roomForm.roomObj);
                button_room.BackColor = Color.Empty;
            }
            else
            {
                button_room.BackColor = Color.Red;

            }
        }
      


        private void button_save_Click(object sender, EventArgs e)
        {
            // Serialization

            XmlSerializeWrapper.Serialize(flats, @"D:\studies\4 сем\ооп\лабы\lab2\lab2\bin\Debug\flats.xml");

        }

        private List<Flats> flats = new List<Flats>();

        // add flat object to local list
        private void addFlat_Click(object sender, EventArgs e)
        {
            string m = meters.Text;

            DateTime buildDate = DateOfBuild.Value;

            List<string> opts = new List<string>();
            foreach (string item in options_CheckedListBox.CheckedItems)
            {
                opts.Add(item);
            }

            string fl = floor.Text;

            string numOfRooms = rooms_number.Text;
            string costOfFlat = cost.Text;

            Address addr = Address_comboBox.SelectedItem as Address;

            // создаем список комнат
            List<Room> rooms = new List<Room>();
            foreach (Room item in Rooms.Items)
            {
                rooms.Add(item);
            }


            try
            {
                double meter = Convert.ToDouble(m);
            }
            catch(FormatException)
            {
                MessageBox.Show("В поле 'Метраж' ведены неверные данные");
            }
            

            // создаем объект квартиры
            Flats f = new Flats(m, buildDate, fl, opts, costOfFlat, numOfRooms, addr, rooms);
            //проверяем количество комнат


           
            

            // добавляем квартиру в список нескольких квартир, используемый для сериализации
            flats.Add(f);
            var results = new List<ValidationResult>();
            var context = new ValidationContext(f);
            
            if (!Validator.TryValidateObject(f, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                    r = DialogResult.Cancel;

                }
            }
            else if (Convert.ToInt32(rooms_number.SelectedItem) != rooms.Count)
            {
                MessageBox.Show("Добавлено неверное количество комнат");
                r = DialogResult.Cancel;
                
            }
            else
            {
                r = DialogResult.OK;
            }

            // добавляем в listbox для визуала
            if (r==DialogResult.OK)
            {
                flatsListBox.Items.Add(f);
                AddFlat_button.BackColor = Color.Empty;
            }
            else
            {
                AddFlat_button.BackColor = Color.Red;
            }
            
        }

        private void output_button_Click(object sender, EventArgs e)
        {
            List<Flats> desF =  XmlSerializeWrapper.Deserialize<List<Flats>>("flats.xml");
            foreach (Flats flat in desF)
            {
                output_listBox.Items.Add(flat);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            meters.Clear();
            options_CheckedListBox.ClearSelected();
            //options_CheckedListBox.Items.Clear();
            floor.Clear();
            Rooms.Items.Clear();
            cost.Clear();
            rooms_number.SelectedIndex = -1;
            flatsListBox.Items.Clear();
            Address_comboBox.Items.Clear();
            output_listBox.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double flat_cost, n_opts=0;
            foreach(string item in options_CheckedListBox.SelectedItems)
            {
                n_opts++;
            }
            
            flat_cost=(Convert.ToDouble(meters.Text)+Convert.ToInt32(rooms_number.Text)*0.2+Convert.ToInt32(floor.Text)*0.1+n_opts*0.3)*1000;
            cost.Text = Convert.ToString(flat_cost);

        }

        private void output_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    public static class XmlSerializeWrapper
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(filename, FileMode.Create,FileAccess.Write))
            {
                formatter.Serialize(fs, obj);
            }
        }

        public static T Deserialize<T>(string filename)
        {
            T obj;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                obj = (T)formatter.Deserialize(fs);
            }

            return obj;
        }
    }
}

