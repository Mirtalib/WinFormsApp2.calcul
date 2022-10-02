using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
namespace WinFormsApp2
{
    public partial class Questionnaire : Form
    {
        public Questionnaire()
        {
            InitializeComponent();




        }

        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Users users = new();

            
          
            
            if (!string.IsNullOrWhiteSpace(textBoxNeme.Text))
                users.Name = textBoxNeme.Text;
            else
                MessageBox.Show("Enter Name");
            
            if (!string.IsNullOrWhiteSpace(textBoxSurname.Text))
                users.SurName = textBoxSurname.Text;
            else
                MessageBox.Show("Enter SurName");
            
            if (!string.IsNullOrWhiteSpace(textBoxFatherName.Text))
                users.FatherName = textBoxFatherName.Text;
            else
                MessageBox.Show("Enter Father Name");
            
            if (!string.IsNullOrWhiteSpace(textBoxCountry.Text))
                users.Country = textBoxCountry.Text;
            else
                MessageBox.Show("Enter Country");
            
            if (!string.IsNullOrWhiteSpace(textBoxCity.Text))
                users.City = textBoxCity.Text;
            else
                MessageBox.Show("Enter City");
            
            if (!string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text))
                users.Phone = textBoxPhoneNumber.Text;
            else
                MessageBox.Show("Enter Phone");
            
            if (radioButtonMen.Checked)
                users.Gender = "Men" ;
            else if (radioButtonWomen.Checked)
                users.Gender = "Women";
            else
                MessageBox.Show("Enter Gender");

            users.DateTime = dateTimePicker1.Value;

            if(!string.IsNullOrWhiteSpace(textBoxNeme.Text )&&
                !string.IsNullOrWhiteSpace(textBoxSurname.Text)&&
                !string.IsNullOrWhiteSpace(textBoxFatherName.Text)&&
                !string.IsNullOrWhiteSpace(textBoxCountry.Text) &&
                !string.IsNullOrWhiteSpace(textBoxCity.Text) &&
                !string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) &&
                (radioButtonMen.Checked != false || radioButtonWomen.Checked != false))
            {

                var jsonString = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(users.Name + ".json", jsonString);
            }

        }

        private void buttonLoab_Click(object sender, EventArgs e)
        {
            
            Users users1 = new Users();
            try
            {
                var stringData = File.ReadAllText(textBoxSingIn.Text + ".json");
                users1 = JsonConvert.DeserializeObject<Users>(stringData)!;
                textBoxNeme.Text = users1.Name;
                textBoxSurname.Text = users1.SurName;
                textBoxFatherName.Text = users1.FatherName;
                textBoxCountry.Text = users1.Country;
                textBoxCity.Text = users1.City;
                textBoxPhoneNumber.Text = users1.Phone;
                dateTimePicker1.Value = users1.DateTime.Value;

                if (users1.Gender == "Men")
                    radioButtonMen.Checked = true;
                else if (users1.Gender == "Women")
                    radioButtonWomen.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}