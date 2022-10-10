using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace Ex_WinFormsApp2
{
    public partial class Form2 : Form
    {


        public string? surname;
        public string? patronymic;
        public string? country;
        public string? city;
        public string? telephone;

        public Form2()
        {
            InitializeComponent();
        }

        private void SurnametextBox_Enter(object sender, EventArgs e)
        {
            if (SurnametextBox.Text == "Surname")
            {
                SurnametextBox.Text = "";
                SurnametextBox.ForeColor = Color.Black;
            }
        }

        private void SurnametextBox_Leave(object sender, EventArgs e)
        {
            if (SurnametextBox.Text == "")
            {
                SurnametextBox.Text = "Surname";
                SurnametextBox.ForeColor = Color.Red;
            }
        }

        private void NametextBox_Enter(object sender, EventArgs e)
        {
            if (NametextBox.Text == "Name")
            {
                NametextBox.Text = "";
                NametextBox.ForeColor = Color.Black;
            }
        }

        private void NametextBox_Leave(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {
                NametextBox.Text = "Name";
                NametextBox.ForeColor = Color.Red;
            }
        }

        private void PatronymictextBox_Enter(object sender, EventArgs e)
        {
            if (PatronymictextBox.Text == "Patronymic")
            {
                PatronymictextBox.Text = "";
                PatronymictextBox.ForeColor = Color.Black;
            }
        }

        private void PatronymictextBox_Leave(object sender, EventArgs e)
        {
            if (PatronymictextBox.Text == "")
            {
                PatronymictextBox.Text = "Patronymic";
                PatronymictextBox.ForeColor = Color.Red;
            }
        }

        private void CountrytextBox_Enter(object sender, EventArgs e)
        {
            if (CountrytextBox.Text == "Patronymic")
            {
                CountrytextBox.Text = "";
                CountrytextBox.ForeColor = Color.Black;
            }
        }

        private void CountrytextBox_Leave(object sender, EventArgs e)
        {
            if (CountrytextBox.Text == "")
            {
                CountrytextBox.Text = "Patronymic";
                CountrytextBox.ForeColor = Color.Red;
            }
        }

        private void CitytextBox_Enter(object sender, EventArgs e)
        {
            if (CitytextBox.Text == "City")
            {
                CitytextBox.Text = "";
                CitytextBox.ForeColor = Color.Black;
            }
        }

        private void CitytextBox_Leave(object sender, EventArgs e)
        {
            if (CitytextBox.Text == "")
            {
                CitytextBox.Text = "City";
                CitytextBox.ForeColor = Color.Red;
            }
        }

        private void TelephonetextBox_Enter(object sender, EventArgs e)
        {
            if (TelephonetextBox.Text == "Telephone")
            {
                TelephonetextBox.Text = "";
                TelephonetextBox.ForeColor = Color.Black;
            }
        }

        private void TelephonetextBox_Leave(object sender, EventArgs e)
        {
            if (TelephonetextBox.Text == "")
            {
                TelephonetextBox.Text = "Enter telephone";
                TelephonetextBox.ForeColor = Color.Red;
            }
        }

        private void Savebutton_Click_1(object sender, EventArgs e)
        {
            var name = NametextBox.Text;
            var surname = SurnametextBox.Text;
            var patronymic = PatronymictextBox.Text;
            var gender = (MaleRdbtn.Checked) ? $"{MaleRdbtn.Text}" : $"{Femalerdbtn.Text}";
            var country = CountrytextBox.Text;
            var city = CitytextBox.Text;
            var telephone = TelephonetextBox.Text;
            var datebrithday = DateTimePicker.MaximumDateTime;

            User user = new User(name, surname, patronymic, datebrithday, gender, country, city, telephone);
            List<User> users = new List<User>();
            if (user != null)
                users.Add(user);
            else
                MessageBox.Show("bosdu");

            File.WriteAllText($"{name}.json", JsonConvert.SerializeObject(users));
            MessageBox.Show("Already saved");
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            var filename = LoadtextBox.Text;
            if (File.Exists($"{filename}.json"))
            {
                var load = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText($"{filename}.json"));
                for (int i = 0; i < load.Count; i++)
                {
                    NametextBox.Text = load[i].Name;
                    SurnametextBox.Text = load[i].Surname;
                    PatronymictextBox.Text = load[i].Patronymic;
                    CountrytextBox.Text = load[i].Country;
                    CitytextBox.Text = load[i].City;
                    TelephonetextBox.Text = load[i].Telephone;
                    if (load[i].Gender == "Male")
                    {
                        MaleRdbtn.Checked = true;
                    }
                    else
                        Femalerdbtn.Checked = true;
                }
            }

        }
    }
}