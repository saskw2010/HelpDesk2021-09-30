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

  [ODataRoutePrefix("odata/authenticationconn/LocationLists")]
  [Route("mvc/odata/authenticationconn/LocationLists")]
  public partial class LocationListsController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public LocationListsController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/LocationLists
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.LocationList> GetLocationLists()
    {
      var items = this.context.LocationLists.AsQueryable<Models.Authenticationconn.LocationList>();
      this.OnLocationListsRead(ref items);

      return items;
    }

    partial void OnLocationListsRead(ref IQueryable<Models.Authenticationconn.LocationList> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{locationID}")]
    public SingleResult<LocationList> GetLocationList(Int64 key)
    {
        var items = this.context.LocationLists.Where(i=>i.locationID == key);
        return SingleResult.Create(items);
    }
    partial void OnLocationListDeleted(Models.Authenticationconn.LocationList item);
    partial void OnAfterLocationListDeleted(Models.Authenticationconn.LocationList item);

    [HttpDelete("{locationID}")]
    public IActionResult DeleteLocationList(Int64 key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.LocationLists
                .Where(i => i.locationID == key)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.LocationList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnLocationListDeleted(item);
            this.context.LocationLists.Remove(item);
            this.context.SaveChanges();
            this.OnAfterLocationListDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnLocationListUpdated(Models.Authenticationconn.LocationList item);
    partial void OnAfterLocationListUpdated(Models.Authenticationconn.LocationList item);

    [HttpPut("{locationID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutLocationList(Int64 key, [FromBody]Models.Authenticationconn.LocationList newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.LocationLists
                .Where(i => i.locationID == key)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.LocationList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnLocationListUpdated(newItem);
            this.context.LocationLists.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.LocationLists.Where(i => i.locationID == key);
            this.OnAfterLocationListUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{locationID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchLocationList(Int64 key, [FromBody]Delta<Models.Authenticationconn.LocationList> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.LocationLists.Where(i => i.locationID == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.LocationList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnLocationListUpdated(item);
            this.context.LocationLists.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.LocationLists.Where(i => i.locationID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnLocationListCreated(Models.Authenticationconn.LocationList item);
    partial void OnAfterLocationListCreated(Models.Authenticationconn.LocationList item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.LocationList item)
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

            this.OnLocationListCreated(item);
            this.context.LocationLists.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Authenticationconn/LocationLists/{item.locationID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
