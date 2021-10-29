using System.ComponentModel.DataAnnotations;

namespace LocalBusiness.Models
{
  public class Business
  {
    [Key]
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string BusinessType { get; set; }
    public string Phone { get; set; }
  }
}