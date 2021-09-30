using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("HelpDeskStatus", Schema = "dbo")]
  public partial class HelpDeskStatus
  {
    [NotMapped]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("@odata.etag")]
    public string ETag
    {
        get;
        set;
    }

    [Key]
    public string TicketStatus
    {
      get;
      set;
    }

    public IEnumerable<HelpDeskTicket> HelpDeskTickets { get; set; }
    [ConcurrencyCheck]
    public string TicketStatusDesc
    {
      get;
      set;
    }
  }
}
