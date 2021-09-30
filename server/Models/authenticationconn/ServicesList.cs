using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("ServicesList", Schema = "dbo")]
  public partial class ServicesList
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
    public Int64 ServiceID
    {
      get;
      set;
    }

    public IEnumerable<HelpDeskTicket> HelpDeskTickets { get; set; }
    [ConcurrencyCheck]
    public string ServiceDesc
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string ServiceDesc1
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string AuditCC
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string assignTo
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public Int64 ServiceCatgID
    {
      get;
      set;
    }
    public ServiceCatglist ServiceCatglist { get; set; }
  }
}
