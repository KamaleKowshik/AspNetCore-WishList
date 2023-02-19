using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WishList.Model
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
