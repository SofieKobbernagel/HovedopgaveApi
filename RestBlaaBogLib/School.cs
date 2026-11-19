using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBlaaBogLib
{
    public class School
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("zipCode")]
        public int ZipCode { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("region")]
        public string Region { get; set; }

        [Column("yearFounded")]
        public int YearFounded { get; set; }

        [Column("gradeStart")]
        public string GradeStart { get; set; }

        [Column("gradeEnd")]
        public string GradeEnd { get; set; }

        [Column("numberOfClasses")]
        public int NumberOfClasses { get; set; }

        [Column("classQuotient")]
        public String ClassQuotient { get; set; }

        [Column("numberOfStudents")]
        public int NumberOfStudents { get; set; }

        [Column("numberOfStudentsInSFO")]
        public int? NumberOfStudentsInSFO { get; set; }

        [Column("titleText")]
        public string? TitleText { get; set; }

        [Column("descriptionText")]
        public string? DescriptionText { get; set; }

        [Column("latitude")]
        public decimal Latitude { get; set; }

        [Column("longitude")]
        public decimal Longitude { get; set; }

        // Navigation properties
        public ICollection<Navn> Navne { get; set; } = new List<Navn>();
        public ICollection<Email> Emails { get; set; } = new List<Email>();
        public ICollection<Telefon> Telefoner { get; set; } = new List<Telefon>();
        public ICollection<Images?> Images { get; set; } = new List<Images?>();
        public ICollection<HjemmesideLink> HjemmesideLinks { get; set; } = new List<HjemmesideLink>();

        public School() { }

        public School(int id, string address, int zip, string city, string region,
            int yearFounded, int numberOfClasses, string gradestart, string gradeEnd,
            string classQuotient, int numberOfStudents, int numberOfStudentsInSFO, string titleText,
            string descriptionText, decimal latitude, decimal longitude)
        {
            ID = id;
            Address = address;
            ZipCode = zip;
            City = city;
            Region = region;
            YearFounded = yearFounded;
            NumberOfClasses = numberOfClasses;
            GradeStart = gradestart;
            GradeEnd = gradeEnd;
            ClassQuotient = classQuotient;
            NumberOfStudents = numberOfStudents;
            NumberOfStudentsInSFO = numberOfStudentsInSFO;
            TitleText = titleText;
            DescriptionText = descriptionText;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
