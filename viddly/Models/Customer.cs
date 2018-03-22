using System.ComponentModel.DataAnnotations;

namespace viddly.Models
{
    public class Customer
    {
        public int Id { get; set; }


        //Use data annotations im model class(domain classes) is not correcty because model class is independent .net framework feetures
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Display(Name = "Customer liked News?")]
        public bool IsSubscribedToNewsLetter { get; set; }

        #region relationships
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
        #endregion
    }
}