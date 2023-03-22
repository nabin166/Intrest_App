using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Intrest
    {



        [Key]
        public int intrestId { get; set; }
        [Required]
        public string intrestName { get; set; }

        public int? intrestCategory_Id { get; set; }

        public virtual IntrestsCategory intrestsCategorie { get; set; }



    }
}
