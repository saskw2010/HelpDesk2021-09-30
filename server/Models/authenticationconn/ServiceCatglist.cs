using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("ServiceCatglist", Schema = "dbo")]
  public partial class ServiceCatglist
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
    public Int64 ServiceCatgID
    {
      get;
      set;
    }

    public IEnumerable<ServicesList> ServicesLists { get; set; }
    public IEnumerable<HelpDeskTicket> HelpDeskTickets { get; set; }
    [ConcurrencyCheck]
    public string ServiceCatgDesc
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string ServiceCatgDesc1
    {
      get;
      set;
    }
  }
}
