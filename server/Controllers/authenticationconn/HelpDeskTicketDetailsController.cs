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

  [ODataRoutePrefix("odata/authenticationconn/HelpDeskTicketDetails")]
  [Route("mvc/odata/authenticationconn/HelpDeskTicketDetails")]
  public partial class HelpDeskTicketDetailsController : ODataController
  {
    private Data.AuthenticationconnContext context;

    public HelpDeskTicketDetailsController(Data.AuthenticationconnContext context)
    {
      this.context = context;
    }
    // GET /odata/Authenticationconn/HelpDeskTicketDetails
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Authenticationconn.HelpDeskTicketDetail> GetHelpDeskTicketDetails()
    {
      var items = this.context.HelpDeskTicketDetails.AsQueryable<Models.Authenticationconn.HelpDeskTicketDetail>();
      this.OnHelpDeskTicketDetailsRead(ref items);

      return items;
    }

    partial void OnHelpDeskTicketDetailsRead(ref IQueryable<Models.Authenticationconn.HelpDeskTicketDetail> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Id}")]
    public SingleResult<HelpDeskTicketDetail> GetHelpDeskTicketDetail(Int64 key)
    {
        var items = this.context.HelpDeskTicketDetails.Where(i=>i.Id == key);
        return SingleResult.Create(items);
    }
    partial void OnHelpDeskTicketDetailDeleted(Models.Authenticationconn.HelpDeskTicketDetail item);
    partial void OnAfterHelpDeskTicketDetailDeleted(Models.Authenticationconn.HelpDeskTicketDetail item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteHelpDeskTicketDetail(Int64 key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var items = this.context.HelpDeskTicketDetails
                .Where(i => i.Id == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskTicketDetail>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnHelpDeskTicketDetailDeleted(item);
            this.context.HelpDeskTicketDetails.Remove(item);
            this.context.SaveChanges();
            this.OnAfterHelpDeskTicketDetailDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHelpDeskTicketDetailUpdated(Models.Authenticationconn.HelpDeskTicketDetail item);
    partial void OnAfterHelpDeskTicketDetailUpdated(Models.Authenticationconn.HelpDeskTicketDetail item);

    [HttpPut("{Id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutHelpDeskTicketDetail(Int64 key, [FromBody]Models.Authenticationconn.HelpDeskTicketDetail newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.HelpDeskTicketDetails
                .Where(i => i.Id == key)
                .AsQueryable();

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskTicketDetail>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            this.OnHelpDeskTicketDetailUpdated(newItem);
            this.context.HelpDeskTicketDetails.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.HelpDeskTicketDetails.Where(i => i.Id == key);
            Request.QueryString = Request.QueryString.Add("$expand", "HelpDeskTicket");
            this.OnAfterHelpDeskTicketDetailUpdated(newItem);
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
    public IActionResult PatchHelpDeskTicketDetail(Int64 key, [FromBody]Delta<Models.Authenticationconn.HelpDeskTicketDetail> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = this.context.HelpDeskTicketDetails.Where(i => i.Id == key);

            items = EntityPatch.ApplyTo<Models.Authenticationconn.HelpDeskTicketDetail>(Request, items);

            var item = items.FirstOrDefault();

            if (item == null)
            {
                return StatusCode((int)HttpStatusCode.PreconditionFailed);
            }

            patch.Patch(item);

            this.OnHelpDeskTicketDetailUpdated(item);
            this.context.HelpDeskTicketDetails.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.HelpDeskTicketDetails.Where(i => i.Id == key);
            Request.QueryString = Request.QueryString.Add("$expand", "HelpDeskTicket");
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHelpDeskTicketDetailCreated(Models.Authenticationconn.HelpDeskTicketDetail item);
    partial void OnAfterHelpDeskTicketDetailCreated(Models.Authenticationconn.HelpDeskTicketDetail item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Authenticationconn.HelpDeskTicketDetail item)
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

            this.OnHelpDeskTicketDetailCreated(item);
            this.context.HelpDeskTicketDetails.Add(item);
            this.context.SaveChanges();

            var key = item.Id;

            var itemToReturn = this.context.HelpDeskTicketDetails.Where(i => i.Id == key);

            Request.QueryString = Request.QueryString.Add("$expand", "HelpDeskTicket");

            this.OnAfterHelpDeskTicketDetailCreated(item);

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
