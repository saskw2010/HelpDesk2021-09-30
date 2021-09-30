using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("HelpDeskTicketDetails", Schema = "dbo")]
  public partial class HelpDeskTicketDetail
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
    [ConcurrencyCheck]
    public Int64 HelpDeskTicketId
    {
      get;
      set;
    }
    public HelpDeskTicket HelpDeskTicket { get; set; }
    [ConcurrencyCheck]
    public DateTime TicketDetailDate
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
  }
}
