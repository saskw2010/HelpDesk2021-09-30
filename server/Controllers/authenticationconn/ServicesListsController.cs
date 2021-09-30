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

  [ODataRoutePrefix("odata/authenticationconn/ServicesLists")]
  [Route("mvc/odata/authenticationconn/ServicesLists")]
  public partial class ServicesListsController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public ServicesListsController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/ServicesLists
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.ServicesList> GetServicesLists()
    {
      var items = this.context.ServicesLists.AsQueryable<Models.Authenticationconn.ServicesList>();
      this.OnServicesListsRead(ref items);

      return items;
    }

    partial void OnServicesListsRead(ref IQueryable<Models.Authenticationconn.ServicesList> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{ServiceID}")]
    public SingleResult<ServicesList> GetServicesList(Int64 key)
    {
        var items = this.context.ServicesLists.Where(i=>i.ServiceID == key);
        return SingleResult.Create(items);
    }
    partial void OnServicesListDeleted(Models.Authenticationconn.ServicesList item);
    partial void OnAfterServicesListDeleted(Models.Authenticationconn.ServicesList item);

    [HttpDelete("{ServiceID}")]
    public IActionResult DeleteServicesList(Int64 key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.ServicesLists
                .Where(i => i.ServiceID == key)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.ServicesList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnServicesListDeleted(item);
            this.context.ServicesLists.Remove(item);
            this.context.SaveChanges();
            this.OnAfterServicesListDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnServicesListUpdated(Models.Authenticationconn.ServicesList item);
    partial void OnAfterServicesListUpdated(Models.Authenticationconn.ServicesList item);

    [HttpPut("{ServiceID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutServicesList(Int64 key, [FromBody]Models.Authenticationconn.ServicesList newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.ServicesLists
                .Where(i => i.ServiceID == key)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.ServicesList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnServicesListUpdated(newItem);
            this.context.ServicesLists.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.ServicesLists.Where(i => i.ServiceID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "ServiceCatglist");
            this.OnAfterServicesListUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{ServiceID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchServicesList(Int64 key, [FromBody]Delta<Models.Authenticationconn.ServicesList> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.ServicesLists.Where(i => i.ServiceID == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.ServicesList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnServicesListUpdated(item);
            this.context.ServicesLists.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.ServicesLists.Where(i => i.ServiceID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "ServiceCatglist");
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnServicesListCreated(Models.Authenticationconn.ServicesList item);
    partial void OnAfterServicesListCreated(Models.Authenticationconn.ServicesList item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.ServicesList item)
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

            this.OnServicesListCreated(item);
            this.context.ServicesLists.Add(item);
            this.context.SaveChanges();

            var key = item.ServiceID;

            var itemToReturn = this.context.ServicesLists.Where(i => i.ServiceID == key);

            Request.QueryString = Request.QueryString.Add("$expand", "ServiceCatglist");

            this.OnAfterServicesListCreated(item);

            return new ObjectResult(SingleResult.Create(itemToReturn))
            {
                StatusCode = 201
            };
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
