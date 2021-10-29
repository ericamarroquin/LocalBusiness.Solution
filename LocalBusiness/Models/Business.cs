using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string BusinessType { get; set; }
    public string Phone { get; set; }
  }
}