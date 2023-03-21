using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Intrest
    {


        
        [Key]
        public int intrest_Id { get; set; }
        [Required]
        public string intrestName { get; set; }

        public int intrestCategory_Id { get; set; }

        public virtual IntrestsCategory intrestsCategorie { get; set; }



    }
}
