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

  [ODataRoutePrefix("odata/authenticationconn/ServiceCatglists")]
  [Route("mvc/odata/authenticationconn/ServiceCatglists")]
  public partial class ServiceCatglistsController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public ServiceCatglistsController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/ServiceCatglists
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.ServiceCatglist> GetServiceCatglists()
    {
      var items = this.context.ServiceCatglists.AsQueryable<Models.Authenticationconn.ServiceCatglist>();
      this.OnServiceCatglistsRead(ref items);

      return items;
    }

    partial void OnServiceCatglistsRead(ref IQueryable<Models.Authenticationconn.ServiceCatglist> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{ServiceCatgID}")]
    public SingleResult<ServiceCatglist> GetServiceCatglist(Int64 key)
    {
        var items = this.context.ServiceCatglists.Where(i=>i.ServiceCatgID == key);
        return SingleResult.Create(items);
    }
    partial void OnServiceCatglistDeleted(Models.Authenticationconn.ServiceCatglist item);
    partial void OnAfterServiceCatglistDeleted(Models.Authenticationconn.ServiceCatglist item);

    [HttpDelete("{ServiceCatgID}")]
    public IActionResult DeleteServiceCatglist(Int64 key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.ServiceCatglists
                .Where(i => i.ServiceCatgID == key)
                .Include(i => i.ServicesLists)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.ServiceCatglist>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnServiceCatglistDeleted(item);
            this.context.ServiceCatglists.Remove(item);
            this.context.SaveChanges();
            this.OnAfterServiceCatglistDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnServiceCatglistUpdated(Models.Authenticationconn.ServiceCatglist item);
    partial void OnAfterServiceCatglistUpdated(Models.Authenticationconn.ServiceCatglist item);

    [HttpPut("{ServiceCatgID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutServiceCatglist(Int64 key, [FromBody]Models.Authenticationconn.ServiceCatglist newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.ServiceCatglists
                .Where(i => i.ServiceCatgID == key)
                .Include(i => i.ServicesLists)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.ServiceCatglist>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnServiceCatglistUpdated(newItem);
            this.context.ServiceCatglists.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.ServiceCatglists.Where(i => i.ServiceCatgID == key);
            this.OnAfterServiceCatglistUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{ServiceCatgID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchServiceCatglist(Int64 key, [FromBody]Delta<Models.Authenticationconn.ServiceCatglist> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.ServiceCatglists.Where(i => i.ServiceCatgID == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.ServiceCatglist>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnServiceCatglistUpdated(item);
            this.context.ServiceCatglists.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.ServiceCatglists.Where(i => i.ServiceCatgID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnServiceCatglistCreated(Models.Authenticationconn.ServiceCatglist item);
    partial void OnAfterServiceCatglistCreated(Models.Authenticationconn.ServiceCatglist item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.ServiceCatglist item)
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

            this.OnServiceCatglistCreated(item);
            this.context.ServiceCatglists.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Authenticationconn/ServiceCatglists/{item.ServiceCatgID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
