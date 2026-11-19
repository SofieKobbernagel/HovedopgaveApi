using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBlaaBogLib
{
    public class School
    {
        public int ID { get; set; }
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PhoneNumber { get; set; }
        public int YearFounded { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int NumberOfClasses { get; set; }
        public int ClassStart { get; set; }
        public int ClassEnd { get; set; }
        public int ClassQuotient { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfStudentsInSFO { get; set; }
        public string TitleText { get; set; }
        public string DescriptionText { get; set; }
        public string ImageUrl { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public School(int id, string name, string address, string zip, string city, string region,
            string phoneNumber, int yearFounded, string website, string email, int numberOfClasses,
            int levelStart, int levelEnd, int classQuota, int numberOfStudents, int numberOfStudentsInSFO,
            string titleText, string descriptionText, string imageUrl, double latitude, double longitude)
        {
            ID = id;
            SchoolName = name;
            Address = address;
            ZipCode = zip;
            City = city;
            Region = region;
            PhoneNumber = phoneNumber;
            YearFounded = yearFounded;
            Website = website;
            Email = email;
            NumberOfClasses = numberOfClasses;
            ClassStart = levelStart;
            ClassEnd = levelEnd;
            ClassQuotient = classQuota;
            NumberOfStudents = numberOfStudents;
            NumberOfStudentsInSFO = numberOfStudentsInSFO;
            TitleText = titleText;
            DescriptionText = descriptionText;
            ImageUrl = imageUrl;
            Latitude = latitude;
            Longitude = longitude;
        }

        public School() { }
    }
}
