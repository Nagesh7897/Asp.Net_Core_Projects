﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentOnboarding.Models
{
    public class StudentDetails
    {

        //S- students F-Father M-Mother

        //Student Information
        [Key]
        public string? GenerateUID { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required.")]
        //   [MaxLength(11, ErrorMessage = "Maximum 11 Characters only")]
        public string SFirstName { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string SLastName { get; set; }


        public string SEmail { get; set;}
        public int SMobileNo { get; set;}
     
        public string ABCID { get; set; }

        //Personal Information
        public string SGender { get; set; }
        public string MaritalStatus { get; set; }
        public string BirthDate { get; set;}

        public string IdType { get; set;}
        public string IdNumber { get; set; }

        //Parent Contact Details
        public string FName { get; set; }
        public int FMobile { get; set; }
        public string FEmail { get; set; }

        public string MName { get; set; }
        public int MMobile { get; set; }
        public string MEmail { get; set; }

        //Address
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set;}
        public string Country { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }

        //Course Details
        public string Cluster { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }

        //Other
        public string Other1 { get; set; }
        public string Other2 { get; set; }
        public string Other3 { get; set; }
        public string Other4 { get; set; }
        public string Other5 { get; set; }
        public string Other6 { get; set; }

        // for connecting other table
        //One to Many Relationship
        
        //public StdEducationDetails StdEducation { get; set; }
       //public List<StdEducationDetails> StdEducation { get; set; }
       public virtual ICollection<StdEducationDetails> StdEducation { get; set; }

    }
}

