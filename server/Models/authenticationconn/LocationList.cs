using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("locationList", Schema = "dbo")]
  public partial class LocationList
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
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 locationID
    {
      get;
      set;
    }

    public IEnumerable<HelpDeskTicket> HelpDeskTickets { get; set; }
    [ConcurrencyCheck]
    public string locationDesc
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string locationDesc1
    {
      get;
      set;
    }
  }
}
