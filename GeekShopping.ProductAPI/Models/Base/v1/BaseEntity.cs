using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Models.Base.v1;

public class BaseEntity
{
    [Key]
    [Column("id")]
    public long Id { get; set; }
}
