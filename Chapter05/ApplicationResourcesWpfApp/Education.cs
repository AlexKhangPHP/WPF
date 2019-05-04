using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationResourcesWpfApp
{
    public class Education
    {
        public string Qualification { get; }
        public string Major { get; }
        public string University { get; }
        public string Country { get; }
        public string YearAttended { get; }
        public string Grade { get; }
        public Education(
            string qualification, 
            string major,
            string university, 
            string country, 
            string yearAttended, 
            string grade
            )
        {
            Qualification = qualification;
            Major = major;
            University = university;
            Country = country;
            YearAttended = yearAttended;
            Grade = grade;
        }
    }
}
