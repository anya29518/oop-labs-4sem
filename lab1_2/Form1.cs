using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace WindowsFormsApp1_2_
{
    public partial class Form1 : Form
    {
        List<Student> collection = new List<Student>();
        delegate void Comparator(bool flag);

        public void Sorter(bool flag)
        {
            total_list_box.Items.Clear();
            if(flag == true)
            {
                IEnumerable<Student> NewStudentList = collection.OrderBy(s => s.Age);
                foreach (Student s in NewStudentList)
                {
                    total_list_box.Items.Add($"Surname: {s.Surname} Name: {s.Name} Age:{s.Age} University:{s.University}");
                }
            }
            else
            {
                IEnumerable<Student> NewStudentList = collection.OrderByDescending(s => s.Age);
                foreach (Student s in NewStudentList)
                {
                    total_list_box.Items.Add($"Surname: {s.Surname} Name: {s.Name} Age:{s.Age} University:{s.University}");
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            string[] surname_array = { "Ivanov", "Petrov", "Shilov", "Kravchenko", "Malitikov","Smirnov" };
            string[] name_array = { "Denis", "Ivan", "Evgeny",  "Ilya",  "Danila" ,"Andrey"};
            int[] age_array = { 17, 18, 19, 20, 21,22 };
            string[] university_array = { "BGUIR", "MITSO", "BNTU", "BGTU", "BGU" };
            int number = 0;
            try
            {
                if (number_of_collection.Text == "" || number_of_collection.Text == " ")
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Заполните поле!"); 
            }
            try
            {
                number = Convert.ToInt32(number_of_collection.Text);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show( "Введите число!");
            }


            int[] random_array = new int[number*4];
            Random rndm = new Random();

            for(int i = 0; i < number*4; i++)
            {
                random_array[i] = rndm.Next(0, 5);
            }

            int j = 0;
            for(int i = 0; i < number; i++)
            {
                collection.Add(new Student(surname_array[random_array[j]], name_array[random_array[j + 1]], age_array[random_array[j + 2]], university_array[random_array[j + 3]]));
                j += 4;
            }
            //list_box.Items.Clear();
            foreach (Student s in collection)
                list_box.Items.Add($"Surname: {s.Surname} Name: {s.Name} Age:{s.Age} University:{s.University}");
            
        }

        private void sorted_up_button_Click(object sender, EventArgs e)
        {
            Comparator cmptr = Sorter;
            cmptr.Invoke(true);
        }

        private void sorted_down_button_Click(object sender, EventArgs e)
        {
            Comparator cmptr = Sorter;
            cmptr.Invoke(false);
        }

        private void questinon_btn_1_Click(object sender, EventArgs e)
        {
            total_list_box.Items.Clear();
            IEnumerable<Student> NewStudentsList = collection.OrderBy(s => s.Age).Take(1);
            foreach(Student s in NewStudentsList)
            {
                total_list_box.Items.Add($"Surname: {s.Surname} Name: {s.Name} Age:{s.Age} University:{s.University}");
            }
        }

        private void question_btn_2_Click(object sender, EventArgs e)
        {
            total_list_box.Items.Clear();
            IEnumerable<Student> NewStudentsList = collection.OrderByDescending(s => s.Age).Take(1);
            foreach (Student s in NewStudentsList)
            {
                total_list_box.Items.Add($"Surname: {s.Surname} Name: {s.Name} Age:{s.Age} University:{s.University}");
            }
        }

        private void question_btn_3_Click(object sender, EventArgs e)
        {
            total_list_box.Items.Clear();
            IEnumerable<Student> NewStudentsList = collection
                .Where(s => s.Name.Contains("I"))
                .Select(s => s);
            foreach (Student s in NewStudentsList)
            {
                total_list_box.Items.Add($"Surname: {s.Surname} Name: {s.Name} Age:{s.Age} University:{s.University}");
            }
        }

        private void list_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Очистить_Click(object sender, EventArgs e)
        {
            collection.Clear();
            list_box.Items.Clear();
            total_list_box.Items.Clear();
        }
    }
}
