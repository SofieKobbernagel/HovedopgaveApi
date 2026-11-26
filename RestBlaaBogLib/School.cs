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
        [Required]
        public int ID { get; set; }

        [Column("address")]
        [Required]
        public string Address { get; set; }

        [Column("zipCode")]
        [Required]
        public int ZipCode { get; set; }

        [Column("region")]
        [Required]
        public string Region { get; set; }

        [Column("yearFounded")]
        [Required]
        public int YearFounded { get; set; }

        [Column("gradeStart")]
        [Required]
        public string GradeStart { get; set; }

        [Column("gradeEnd")]
        [Required]
        public string GradeEnd { get; set; } 

        [Column("numberOfClasses")]
        [Required]
        public int NumberOfClasses { get; set; }

        [Column("classQuotient")]
        [Required]
        public string ClassQuotient { get; set; } 

        [Column("numberOfStudents")]
        [Required]
        public int NumberOfStudents { get; set; }

        [Column("numberOfStudentsInSFO")]
        public int? NumberOfStudentsInSFO { get; set; }

        [Column("titleText")]
        public string? TitleText { get; set; }

        [Column("descriptionText")]
        public string? DescriptionText { get; set; }

        [Column("latitude")]
        [Required]
        public decimal Latitude { get; set; }

        [Column("longitude")]
        [Required]
        public decimal Longitude { get; set; }

        // Navigation properties
        public Name Navn { get; set; } = null!;
        public Email Email { get; set; } = null!;
        public Phone Telefon { get; set; } = null!;
        public Images Image { get; set; } = null!;
        public Website HjemmesideLink { get; set; } = null!;
        public City City { get; set; } = null!;


        public School() { }

        public School(int id, string address, int zip, string region,
            int yearFounded, int numberOfClasses, string gradestart, string gradeEnd,
            string classQuotient, int numberOfStudents, int numberOfStudentsInSFO, string titleText,
            string descriptionText, decimal latitude, decimal longitude)
        {
            ID = id;
            Address = address;
            ZipCode = zip;
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
