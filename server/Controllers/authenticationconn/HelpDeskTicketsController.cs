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

  [ODataRoutePrefix("odata/authenticationconn/HelpDeskTickets")]
  [Route("mvc/odata/authenticationconn/HelpDeskTickets")]
  public partial class HelpDeskTicketsController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public HelpDeskTicketsController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/HelpDeskTickets
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.HelpDeskTicket> GetHelpDeskTickets()
    {
      var items = this.context.HelpDeskTickets.AsQueryable<Models.Authenticationconn.HelpDeskTicket>();
      this.OnHelpDeskTicketsRead(ref items);

      return items;
    }

    partial void OnHelpDeskTicketsRead(ref IQueryable<Models.Authenticationconn.HelpDeskTicket> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<HelpDeskTicket> GetHelpDeskTicket(Int64 key)
    {
        var items = this.context.HelpDeskTickets.Where(i=>i.Id == key);
        return SingleResult.Create(items);
    }
    partial void OnHelpDeskTicketDeleted(Models.Authenticationconn.HelpDeskTicket item);
    partial void OnAfterHelpDeskTicketDeleted(Models.Authenticationconn.HelpDeskTicket item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteHelpDeskTicket(Int64 key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.HelpDeskTickets
                .Where(i => i.Id == key)
                .Include(i => i.HelpDeskTicketDetails)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskTicket>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnHelpDeskTicketDeleted(item);
            this.context.HelpDeskTickets.Remove(item);
            this.context.SaveChanges();
            this.OnAfterHelpDeskTicketDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHelpDeskTicketUpdated(Models.Authenticationconn.HelpDeskTicket item);
    partial void OnAfterHelpDeskTicketUpdated(Models.Authenticationconn.HelpDeskTicket item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutHelpDeskTicket(Int64 key, [FromBody]Models.Authenticationconn.HelpDeskTicket newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.HelpDeskTickets
                .Where(i => i.Id == key)
                .Include(i => i.HelpDeskTicketDetails)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskTicket>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnHelpDeskTicketUpdated(newItem);
            this.context.HelpDeskTickets.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.HelpDeskTickets.Where(i => i.Id == key);
            Request.QueryString = Request.QueryString.Add("$expand", "HelpDeskStatus,LocationList,ServiceCatglist,ServicesList");
            this.OnAfterHelpDeskTicketUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchHelpDeskTicket(Int64 key, [FromBody]Delta<Models.Authenticationconn.HelpDeskTicket> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.HelpDeskTickets.Where(i => i.Id == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskTicket>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnHelpDeskTicketUpdated(item);
            this.context.HelpDeskTickets.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.HelpDeskTickets.Where(i => i.Id == key);
            Request.QueryString = Request.QueryString.Add("$expand", "HelpDeskStatus,LocationList,ServiceCatglist,ServicesList");
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHelpDeskTicketCreated(Models.Authenticationconn.HelpDeskTicket item);
    partial void OnAfterHelpDeskTicketCreated(Models.Authenticationconn.HelpDeskTicket item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.HelpDeskTicket item)
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

            this.OnHelpDeskTicketCreated(item);
            this.context.HelpDeskTickets.Add(item);
            this.context.SaveChanges();

            var key = item.Id;

            var itemToReturn = this.context.HelpDeskTickets.Where(i => i.Id == key);

            Request.QueryString = Request.QueryString.Add("$expand", "HelpDeskStatus,LocationList,ServiceCatglist,ServicesList");

            this.OnAfterHelpDeskTicketCreated(item);

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
