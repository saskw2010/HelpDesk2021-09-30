using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("TicketRequesterUsersList", Schema = "dbo")]
  public partial class TicketRequesterUsersList
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
    public string TicketRequesterUser
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string TicketRequesterEmail
    {
      get;
      set;
    }
  }
}
