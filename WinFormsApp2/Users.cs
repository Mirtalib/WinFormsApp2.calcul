using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    [Serializable]
    internal class Users
    {
        public Users(string? name, string? surName, string? fatherName, string? country, string? city, string? phone, string? gender, DateTime? dateTime)
        {
            Name = name;
            SurName = surName;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            Gender = gender;
            DateTime = dateTime;
        }
        public Users()
        {
            Name = default;
            SurName = default;
            FatherName = default;
            Country = default;
            City = default;
            Phone = default;
            Gender = default;
            DateTime = default;
        }

        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? FatherName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateTime { get; set; }


    }
}
