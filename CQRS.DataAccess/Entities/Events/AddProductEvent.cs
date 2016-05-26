using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCa.DataAccess.Events
{
  [Table(nameof(AddProductEvent), Schema="events")]
  public class AddProductEvent : EventBase
  { 
    [Required, StringLength(100)]
    public string ProductName { get; set; }
  }
}
