using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class IntrestsCategory
    {
        public IntrestsCategory()
        {
            intrests = new HashSet<Intrest>();
        }

        [Key]
        public int intrestCategory_Id { get; set; }
        [Required]
        public string categoryName { get; set; }

        public int user_Id { get; set; }

        public virtual User user { get; set; }

        public virtual ICollection<Intrest> intrests { get; set; }

       

    }
}
