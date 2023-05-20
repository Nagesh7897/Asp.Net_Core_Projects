using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TansactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 Characters only")]
        public string AccountNumber { get; set; }

        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required.")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 Characters only")]
        public string SWIFTCode { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Required(ErrorMessage = "This field is required.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        [DisplayName("Date")]
        public DateTime date { get; set; }
    }
}
