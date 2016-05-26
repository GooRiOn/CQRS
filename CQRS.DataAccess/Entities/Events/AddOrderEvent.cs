using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCa.DataAccess.Events
{
  [Table(nameof(AddOrderEvent), Schema="events")]
  public class AddOrderEvent : EventBase
  {
    public AddOrderEvent()
    {
      Quantity = 0;
    }

    [Required, StringLength(100)]
    public string ProductName { get; set; }

    [Required]
    public int Quantity { get; set; }
  }
}
