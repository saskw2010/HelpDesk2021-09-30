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

  [ODataRoutePrefix("odata/authenticationconn/TicketRequesterUsersLists")]
  [Route("mvc/odata/authenticationconn/TicketRequesterUsersLists")]
  public partial class TicketRequesterUsersListsController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public TicketRequesterUsersListsController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/TicketRequesterUsersLists
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.TicketRequesterUsersList> GetTicketRequesterUsersLists()
    {
      var items = this.context.TicketRequesterUsersLists.AsQueryable<Models.Authenticationconn.TicketRequesterUsersList>();
      this.OnTicketRequesterUsersListsRead(ref items);

      return items;
    }

    partial void OnTicketRequesterUsersListsRead(ref IQueryable<Models.Authenticationconn.TicketRequesterUsersList> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{TicketRequesterUser}")]
    public SingleResult<TicketRequesterUsersList> GetTicketRequesterUsersList(string key)
    {
        var items = this.context.TicketRequesterUsersLists.Where(i=>i.TicketRequesterUser == key);
        return SingleResult.Create(items);
    }
    partial void OnTicketRequesterUsersListDeleted(Models.Authenticationconn.TicketRequesterUsersList item);
    partial void OnAfterTicketRequesterUsersListDeleted(Models.Authenticationconn.TicketRequesterUsersList item);

    [HttpDelete("{TicketRequesterUser}")]
    public IActionResult DeleteTicketRequesterUsersList(string key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.TicketRequesterUsersLists
                .Where(i => i.TicketRequesterUser == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.TicketRequesterUsersList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnTicketRequesterUsersListDeleted(item);
            this.context.TicketRequesterUsersLists.Remove(item);
            this.context.SaveChanges();
            this.OnAfterTicketRequesterUsersListDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnTicketRequesterUsersListUpdated(Models.Authenticationconn.TicketRequesterUsersList item);
    partial void OnAfterTicketRequesterUsersListUpdated(Models.Authenticationconn.TicketRequesterUsersList item);

    [HttpPut("{TicketRequesterUser}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutTicketRequesterUsersList(string key, [FromBody]Models.Authenticationconn.TicketRequesterUsersList newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.TicketRequesterUsersLists
                .Where(i => i.TicketRequesterUser == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.TicketRequesterUsersList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnTicketRequesterUsersListUpdated(newItem);
            this.context.TicketRequesterUsersLists.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.TicketRequesterUsersLists.Where(i => i.TicketRequesterUser == key);
            this.OnAfterTicketRequesterUsersListUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{TicketRequesterUser}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchTicketRequesterUsersList(string key, [FromBody]Delta<Models.Authenticationconn.TicketRequesterUsersList> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.TicketRequesterUsersLists.Where(i => i.TicketRequesterUser == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.TicketRequesterUsersList>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnTicketRequesterUsersListUpdated(item);
            this.context.TicketRequesterUsersLists.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.TicketRequesterUsersLists.Where(i => i.TicketRequesterUser == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnTicketRequesterUsersListCreated(Models.Authenticationconn.TicketRequesterUsersList item);
    partial void OnAfterTicketRequesterUsersListCreated(Models.Authenticationconn.TicketRequesterUsersList item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.TicketRequesterUsersList item)
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

            this.OnTicketRequesterUsersListCreated(item);
            this.context.TicketRequesterUsersLists.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Authenticationconn/TicketRequesterUsersLists/{item.TicketRequesterUser}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
