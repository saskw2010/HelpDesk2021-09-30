using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testauth.Models.Authenticationconn
{
  [Table("PersistedGrants", Schema = "dbo")]
  public partial class PersistedGrant
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
    public string Key
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string Type
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string SubjectId
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string ClientId
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public DateTime CreationTime
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public DateTime? Expiration
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string Data
    {
      get;
      set;
    }
  }
}
