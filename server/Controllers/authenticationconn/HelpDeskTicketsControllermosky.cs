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


    public partial class HelpDeskTicketsController
    {
        //[EnableQuery(MaxExpansionDepth = 10, MaxAnyAllExpressionDepth = 10, MaxNodeCount = 1000)]
        
        //[ODataRoute("user/{TicketRequesterUser}")]
        //[HttpGet]
        //public SingleResult<HelpDeskTicket> GetHelpDeskTicketbyuser(string TicketRequesterUser)
        //{
        //    var items = this.context.HelpDeskTickets.Where(i => i.TicketRequesterUser == TicketRequesterUser);
        //    return SingleResult.Create(items);
        //}

    }

}