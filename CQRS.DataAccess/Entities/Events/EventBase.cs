using MemoSys.EF.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCa.DataAccess.Events
{
  [Table(nameof(EventBase), Schema = "events")]
  public class EventBase
  {
    [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

        public EventBase()
        {
            EventType = GetType().Name; // TODO: turn into MetaData and read in OnSaveChanges

            CreatedOn = DateTime.UtcNow; // TODO: use migration with default value;
        }

        [Required, StringLength(50)]
        public string EventType { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] // TODO: use migration with setting default value
        public DateTime CreatedOn { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        public override string ToString() => EventType;
    }
}
