using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("HelpDeskTickets", Schema = "dbo")]
  public partial class HelpDeskTicket
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
    public Int64 Id
    {
      get;
      set;
    }

    public IEnumerable<HelpDeskTicketDetail> HelpDeskTicketDetails { get; set; }
    [ConcurrencyCheck]
    public string TicketGUID
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string TicketStatus
    {
      get;
      set;
    }
    public HelpDeskStatus HelpDeskStatus { get; set; }
    [ConcurrencyCheck]
    public DateTime TicketDate
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string TicketDescription
    {
      get;
      set;
    }
    [ConcurrencyCheck]
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
    [ConcurrencyCheck]
    public Int64? locationID
    {
      get;
      set;
    }
    public LocationList LocationList { get; set; }
    [ConcurrencyCheck]
    public Int64? ServiceCatgID
    {
      get;
      set;
    }
    public ServiceCatglist ServiceCatglist { get; set; }
    [ConcurrencyCheck]
    public Int64? ServiceID
    {
      get;
      set;
    }
    public ServicesList ServicesList { get; set; }
    [ConcurrencyCheck]
    public string assignTo
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
  }
}
