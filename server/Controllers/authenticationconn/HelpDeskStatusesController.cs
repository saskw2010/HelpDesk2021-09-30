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

  [ODataRoutePrefix("odata/authenticationconn/HelpDeskStatuses")]
  [Route("mvc/odata/authenticationconn/HelpDeskStatuses")]
  public partial class HelpDeskStatusesController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public HelpDeskStatusesController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/HelpDeskStatuses
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.HelpDeskStatus> GetHelpDeskStatuses()
    {
      var items = this.context.HelpDeskStatuses.AsQueryable<Models.Authenticationconn.HelpDeskStatus>();
      this.OnHelpDeskStatusesRead(ref items);

      return items;
    }

    partial void OnHelpDeskStatusesRead(ref IQueryable<Models.Authenticationconn.HelpDeskStatus> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{TicketStatus}")]
    public SingleResult<HelpDeskStatus> GetHelpDeskStatus(string key)
    {
        var items = this.context.HelpDeskStatuses.Where(i=>i.TicketStatus == key);
        return SingleResult.Create(items);
    }
    partial void OnHelpDeskStatusDeleted(Models.Authenticationconn.HelpDeskStatus item);
    partial void OnAfterHelpDeskStatusDeleted(Models.Authenticationconn.HelpDeskStatus item);

    [HttpDelete("{TicketStatus}")]
    public IActionResult DeleteHelpDeskStatus(string key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.HelpDeskStatuses
                .Where(i => i.TicketStatus == key)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskStatus>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnHelpDeskStatusDeleted(item);
            this.context.HelpDeskStatuses.Remove(item);
            this.context.SaveChanges();
            this.OnAfterHelpDeskStatusDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHelpDeskStatusUpdated(Models.Authenticationconn.HelpDeskStatus item);
    partial void OnAfterHelpDeskStatusUpdated(Models.Authenticationconn.HelpDeskStatus item);

    [HttpPut("{TicketStatus}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutHelpDeskStatus(string key, [FromBody]Models.Authenticationconn.HelpDeskStatus newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.HelpDeskStatuses
                .Where(i => i.TicketStatus == key)
                .Include(i => i.HelpDeskTickets)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskStatus>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnHelpDeskStatusUpdated(newItem);
            this.context.HelpDeskStatuses.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.HelpDeskStatuses.Where(i => i.TicketStatus == key);
            this.OnAfterHelpDeskStatusUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{TicketStatus}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchHelpDeskStatus(string key, [FromBody]Delta<Models.Authenticationconn.HelpDeskStatus> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.HelpDeskStatuses.Where(i => i.TicketStatus == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskStatus>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnHelpDeskStatusUpdated(item);
            this.context.HelpDeskStatuses.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.HelpDeskStatuses.Where(i => i.TicketStatus == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHelpDeskStatusCreated(Models.Authenticationconn.HelpDeskStatus item);
    partial void OnAfterHelpDeskStatusCreated(Models.Authenticationconn.HelpDeskStatus item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.HelpDeskStatus item)
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

            this.OnHelpDeskStatusCreated(item);
            this.context.HelpDeskStatuses.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Authenticationconn/HelpDeskStatuses/{item.TicketStatus}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
