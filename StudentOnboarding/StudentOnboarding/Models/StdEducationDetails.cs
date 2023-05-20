using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentOnboarding.Models
{
    public class StdEducationDetails
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("Education")]
        [Required(ErrorMessage = "This field is required.")]
     //   [MaxLength(11, ErrorMessage = "Maximum 11 Characters only")]
        public string Education { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("SchoolorCollege")]
        public string SchoolorCollege { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("University")]
        public string  University { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [DisplayName("Degree")]
        public string Degree { get; set;}



        //It will work as a foreignKey if we declear GeneratedUID as a primary key in other table
        //and if we give the name other tablename+variablename
        [ForeignKey("StudentDetailsGenerateUID")]
        [DisplayName("UID")]
        public virtual string StudentDetailsGenerateUID { get; set; }

        // public StudentDetails StudentDetails { get; set; }

    }
}
