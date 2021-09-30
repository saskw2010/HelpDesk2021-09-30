using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace Testauth.Controllers.Authenticationconn
{
  using Models;
  using Data;
  using Models.Authenticationconn;

  [ODataRoutePrefix("odata/authenticationconn/PersistedGrants")]
  [Route("mvc/odata/authenticationconn/PersistedGrants")]
  public partial class PersistedGrantsController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public PersistedGrantsController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/PersistedGrants
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.PersistedGrant> GetPersistedGrants()
    {
      var items = this.context.PersistedGrants.AsQueryable<Models.Authenticationconn.PersistedGrant>();
      this.OnPersistedGrantsRead(ref items);

      return items;
    }

    partial void OnPersistedGrantsRead(ref IQueryable<Models.Authenticationconn.PersistedGrant> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Key}")]
    public SingleResult<PersistedGrant> GetPersistedGrant(string key)
    {
        var items = this.context.PersistedGrants.Where(i=>i.Key == key);
        return SingleResult.Create(items);
    }
    partial void OnPersistedGrantDeleted(Models.Authenticationconn.PersistedGrant item);
    partial void OnAfterPersistedGrantDeleted(Models.Authenticationconn.PersistedGrant item);

    [HttpDelete("{Key}")]
    public IActionResult DeletePersistedGrant(string key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.PersistedGrants
                .Where(i => i.Key == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.PersistedGrant>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnPersistedGrantDeleted(item);
            this.context.PersistedGrants.Remove(item);
            this.context.SaveChanges();
            this.OnAfterPersistedGrantDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnPersistedGrantUpdated(Models.Authenticationconn.PersistedGrant item);
    partial void OnAfterPersistedGrantUpdated(Models.Authenticationconn.PersistedGrant item);

    [HttpPut("{Key}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutPersistedGrant(string key, [FromBody]Models.Authenticationconn.PersistedGrant newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.PersistedGrants
                .Where(i => i.Key == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.PersistedGrant>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnPersistedGrantUpdated(newItem);
            this.context.PersistedGrants.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.PersistedGrants.Where(i => i.Key == key);
            this.OnAfterPersistedGrantUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{Key}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchPersistedGrant(string key, [FromBody]Delta<Models.Authenticationconn.PersistedGrant> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.PersistedGrants.Where(i => i.Key == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.PersistedGrant>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnPersistedGrantUpdated(item);
            this.context.PersistedGrants.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.PersistedGrants.Where(i => i.Key == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnPersistedGrantCreated(Models.Authenticationconn.PersistedGrant item);
    partial void OnAfterPersistedGrantCreated(Models.Authenticationconn.PersistedGrant item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.PersistedGrant item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnPersistedGrantCreated(item);
            this.context.PersistedGrants.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Authenticationconn/PersistedGrants/{item.Key}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
