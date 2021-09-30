using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testauth.Data;

namespace Testauth
{
    public partial class ExportAuthenticationconnController : ExportController
    {
        private readonly AuthenticationconnContext context;

        public ExportAuthenticationconnController(AuthenticationconnContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/Authenticationconn/devicecodes/csv")]
        [HttpGet("/export/Authenticationconn/devicecodes/csv(fileName='{fileName}')")]
        public FileStreamResult ExportDeviceCodesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.DeviceCodes, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/devicecodes/excel")]
        [HttpGet("/export/Authenticationconn/devicecodes/excel(fileName='{fileName}')")]
        public FileStreamResult ExportDeviceCodesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.DeviceCodes, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/helpdeskstatuses/csv")]
        [HttpGet("/export/Authenticationconn/helpdeskstatuses/csv(fileName='{fileName}')")]
        public FileStreamResult ExportHelpDeskStatusesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.HelpDeskStatuses, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/helpdeskstatuses/excel")]
        [HttpGet("/export/Authenticationconn/helpdeskstatuses/excel(fileName='{fileName}')")]
        public FileStreamResult ExportHelpDeskStatusesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.HelpDeskStatuses, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/helpdesktickets/csv")]
        [HttpGet("/export/Authenticationconn/helpdesktickets/csv(fileName='{fileName}')")]
        public FileStreamResult ExportHelpDeskTicketsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.HelpDeskTickets, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/helpdesktickets/excel")]
        [HttpGet("/export/Authenticationconn/helpdesktickets/excel(fileName='{fileName}')")]
        public FileStreamResult ExportHelpDeskTicketsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.HelpDeskTickets, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/helpdeskticketdetails/csv")]
        [HttpGet("/export/Authenticationconn/helpdeskticketdetails/csv(fileName='{fileName}')")]
        public FileStreamResult ExportHelpDeskTicketDetailsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.HelpDeskTicketDetails, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/helpdeskticketdetails/excel")]
        [HttpGet("/export/Authenticationconn/helpdeskticketdetails/excel(fileName='{fileName}')")]
        public FileStreamResult ExportHelpDeskTicketDetailsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.HelpDeskTicketDetails, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/locationlists/csv")]
        [HttpGet("/export/Authenticationconn/locationlists/csv(fileName='{fileName}')")]
        public FileStreamResult ExportLocationListsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.LocationLists, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/locationlists/excel")]
        [HttpGet("/export/Authenticationconn/locationlists/excel(fileName='{fileName}')")]
        public FileStreamResult ExportLocationListsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.LocationLists, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/persistedgrants/csv")]
        [HttpGet("/export/Authenticationconn/persistedgrants/csv(fileName='{fileName}')")]
        public FileStreamResult ExportPersistedGrantsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.PersistedGrants, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/persistedgrants/excel")]
        [HttpGet("/export/Authenticationconn/persistedgrants/excel(fileName='{fileName}')")]
        public FileStreamResult ExportPersistedGrantsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.PersistedGrants, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/servicecatglists/csv")]
        [HttpGet("/export/Authenticationconn/servicecatglists/csv(fileName='{fileName}')")]
        public FileStreamResult ExportServiceCatglistsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.ServiceCatglists, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/servicecatglists/excel")]
        [HttpGet("/export/Authenticationconn/servicecatglists/excel(fileName='{fileName}')")]
        public FileStreamResult ExportServiceCatglistsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.ServiceCatglists, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/serviceslists/csv")]
        [HttpGet("/export/Authenticationconn/serviceslists/csv(fileName='{fileName}')")]
        public FileStreamResult ExportServicesListsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.ServicesLists, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/serviceslists/excel")]
        [HttpGet("/export/Authenticationconn/serviceslists/excel(fileName='{fileName}')")]
        public FileStreamResult ExportServicesListsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.ServicesLists, Request.Query), fileName);
        }
        [HttpGet("/export/Authenticationconn/ticketrequesteruserslists/csv")]
        [HttpGet("/export/Authenticationconn/ticketrequesteruserslists/csv(fileName='{fileName}')")]
        public FileStreamResult ExportTicketRequesterUsersListsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.TicketRequesterUsersLists, Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/ticketrequesteruserslists/excel")]
        [HttpGet("/export/Authenticationconn/ticketrequesteruserslists/excel(fileName='{fileName}')")]
        public FileStreamResult ExportTicketRequesterUsersListsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.TicketRequesterUsersLists, Request.Query), fileName);
        }
    }
}
