
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Radzen;
using Testauth.Models.Authenticationconn;

namespace Testauth
{
    public partial class AuthenticationconnService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public AuthenticationconnService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/authenticationconn/");
        }

        public async System.Threading.Tasks.Task ExportDeviceCodesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/devicecodes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/devicecodes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportDeviceCodesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/devicecodes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/devicecodes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetDeviceCodes(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<DeviceCode>> GetDeviceCodes(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"DeviceCodes");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetDeviceCodes(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<DeviceCode>>();
        }
        partial void OnCreateDeviceCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<DeviceCode> CreateDeviceCode(DeviceCode deviceCode = default(DeviceCode))
        {
            var uri = new Uri(baseUri, $"DeviceCodes");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(deviceCode), Encoding.UTF8, "application/json");

            OnCreateDeviceCode(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<DeviceCode>();
        }

        public async System.Threading.Tasks.Task ExportHelpDeskStatusesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/helpdeskstatuses/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/helpdeskstatuses/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportHelpDeskStatusesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/helpdeskstatuses/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/helpdeskstatuses/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetHelpDeskStatuses(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<HelpDeskStatus>> GetHelpDeskStatuses(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"HelpDeskStatuses");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetHelpDeskStatuses(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<HelpDeskStatus>>();
        }
        partial void OnCreateHelpDeskStatus(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HelpDeskStatus> CreateHelpDeskStatus(HelpDeskStatus helpDeskStatus = default(HelpDeskStatus))
        {
            var uri = new Uri(baseUri, $"HelpDeskStatuses");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(helpDeskStatus), Encoding.UTF8, "application/json");

            OnCreateHelpDeskStatus(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HelpDeskStatus>();
        }

        public async System.Threading.Tasks.Task ExportHelpDeskTicketsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/helpdesktickets/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/helpdesktickets/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportHelpDeskTicketsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/helpdesktickets/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/helpdesktickets/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetHelpDeskTickets(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<HelpDeskTicket>> GetHelpDeskTickets(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"HelpDeskTickets");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetHelpDeskTickets(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<HelpDeskTicket>>();
        }
        partial void OnCreateHelpDeskTicket(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HelpDeskTicket> CreateHelpDeskTicket(HelpDeskTicket helpDeskTicket = default(HelpDeskTicket))
        {
            var uri = new Uri(baseUri, $"HelpDeskTickets");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(helpDeskTicket), Encoding.UTF8, "application/json");

            OnCreateHelpDeskTicket(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HelpDeskTicket>();
        }

        public async System.Threading.Tasks.Task ExportHelpDeskTicketDetailsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/helpdeskticketdetails/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/helpdeskticketdetails/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportHelpDeskTicketDetailsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/helpdeskticketdetails/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/helpdeskticketdetails/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetHelpDeskTicketDetails(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<HelpDeskTicketDetail>> GetHelpDeskTicketDetails(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"HelpDeskTicketDetails");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetHelpDeskTicketDetails(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<HelpDeskTicketDetail>>();
        }
        partial void OnCreateHelpDeskTicketDetail(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HelpDeskTicketDetail> CreateHelpDeskTicketDetail(HelpDeskTicketDetail helpDeskTicketDetail = default(HelpDeskTicketDetail))
        {
            var uri = new Uri(baseUri, $"HelpDeskTicketDetails");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(helpDeskTicketDetail), Encoding.UTF8, "application/json");

            OnCreateHelpDeskTicketDetail(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HelpDeskTicketDetail>();
        }

        public async System.Threading.Tasks.Task ExportLocationListsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/locationlists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/locationlists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportLocationListsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/locationlists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/locationlists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetLocationLists(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<LocationList>> GetLocationLists(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"LocationLists");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetLocationLists(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<LocationList>>();
        }
        partial void OnCreateLocationList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<LocationList> CreateLocationList(LocationList locationList = default(LocationList))
        {
            var uri = new Uri(baseUri, $"LocationLists");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(locationList), Encoding.UTF8, "application/json");

            OnCreateLocationList(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<LocationList>();
        }

        public async System.Threading.Tasks.Task ExportPersistedGrantsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/persistedgrants/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/persistedgrants/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportPersistedGrantsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/persistedgrants/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/persistedgrants/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetPersistedGrants(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<PersistedGrant>> GetPersistedGrants(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"PersistedGrants");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetPersistedGrants(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<PersistedGrant>>();
        }
        partial void OnCreatePersistedGrant(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<PersistedGrant> CreatePersistedGrant(PersistedGrant persistedGrant = default(PersistedGrant))
        {
            var uri = new Uri(baseUri, $"PersistedGrants");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(persistedGrant), Encoding.UTF8, "application/json");

            OnCreatePersistedGrant(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<PersistedGrant>();
        }

        public async System.Threading.Tasks.Task ExportServiceCatglistsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/servicecatglists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/servicecatglists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportServiceCatglistsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/servicecatglists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/servicecatglists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetServiceCatglists(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<ServiceCatglist>> GetServiceCatglists(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"ServiceCatglists");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetServiceCatglists(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<ServiceCatglist>>();
        }
        partial void OnCreateServiceCatglist(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ServiceCatglist> CreateServiceCatglist(ServiceCatglist serviceCatglist = default(ServiceCatglist))
        {
            var uri = new Uri(baseUri, $"ServiceCatglists");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(serviceCatglist), Encoding.UTF8, "application/json");

            OnCreateServiceCatglist(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ServiceCatglist>();
        }

        public async System.Threading.Tasks.Task ExportServicesListsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/serviceslists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/serviceslists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportServicesListsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/serviceslists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/serviceslists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetServicesLists(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<ServicesList>> GetServicesLists(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"ServicesLists");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetServicesLists(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<ServicesList>>();
        }
        partial void OnCreateServicesList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ServicesList> CreateServicesList(ServicesList servicesList = default(ServicesList))
        {
            var uri = new Uri(baseUri, $"ServicesLists");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(servicesList), Encoding.UTF8, "application/json");

            OnCreateServicesList(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ServicesList>();
        }

        public async System.Threading.Tasks.Task ExportTicketRequesterUsersListsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/ticketrequesteruserslists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/ticketrequesteruserslists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportTicketRequesterUsersListsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/ticketrequesteruserslists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/ticketrequesteruserslists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetTicketRequesterUsersLists(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<TicketRequesterUsersList>> GetTicketRequesterUsersLists(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"TicketRequesterUsersLists");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetTicketRequesterUsersLists(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<TicketRequesterUsersList>>();
        }
        partial void OnCreateTicketRequesterUsersList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<TicketRequesterUsersList> CreateTicketRequesterUsersList(TicketRequesterUsersList ticketRequesterUsersList = default(TicketRequesterUsersList))
        {
            var uri = new Uri(baseUri, $"TicketRequesterUsersLists");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(ticketRequesterUsersList), Encoding.UTF8, "application/json");

            OnCreateTicketRequesterUsersList(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<TicketRequesterUsersList>();
        }
        partial void OnDeleteDeviceCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteDeviceCode(string userCode = default(string))
        {
            var uri = new Uri(baseUri, $"DeviceCodes('{HttpUtility.UrlEncode(userCode.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteDeviceCode(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetDeviceCodeByUserCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<DeviceCode> GetDeviceCodeByUserCode(string userCode = default(string))
        {
            var uri = new Uri(baseUri, $"DeviceCodes('{HttpUtility.UrlEncode(userCode.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetDeviceCodeByUserCode(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<DeviceCode>();
        }
        partial void OnUpdateDeviceCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateDeviceCode(string userCode = default(string), DeviceCode deviceCode = default(DeviceCode))
        {
            var uri = new Uri(baseUri, $"DeviceCodes('{HttpUtility.UrlEncode(userCode.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", deviceCode.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(deviceCode), Encoding.UTF8, "application/json");

            OnUpdateDeviceCode(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteHelpDeskStatus(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteHelpDeskStatus(string ticketStatus = default(string))
        {
            var uri = new Uri(baseUri, $"HelpDeskStatuses('{HttpUtility.UrlEncode(ticketStatus.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteHelpDeskStatus(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetHelpDeskStatusByTicketStatus(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HelpDeskStatus> GetHelpDeskStatusByTicketStatus(string ticketStatus = default(string))
        {
            var uri = new Uri(baseUri, $"HelpDeskStatuses('{HttpUtility.UrlEncode(ticketStatus.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetHelpDeskStatusByTicketStatus(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HelpDeskStatus>();
        }
        partial void OnUpdateHelpDeskStatus(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateHelpDeskStatus(string ticketStatus = default(string), HelpDeskStatus helpDeskStatus = default(HelpDeskStatus))
        {
            var uri = new Uri(baseUri, $"HelpDeskStatuses('{HttpUtility.UrlEncode(ticketStatus.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", helpDeskStatus.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(helpDeskStatus), Encoding.UTF8, "application/json");

            OnUpdateHelpDeskStatus(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteHelpDeskTicket(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteHelpDeskTicket(Int64? id = default(Int64?))
        {
            var uri = new Uri(baseUri, $"HelpDeskTickets({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteHelpDeskTicket(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetHelpDeskTicketById(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HelpDeskTicket> GetHelpDeskTicketById(Int64? id = default(Int64?))
        {
            var uri = new Uri(baseUri, $"HelpDeskTickets({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetHelpDeskTicketById(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HelpDeskTicket>();
        }
        partial void OnUpdateHelpDeskTicket(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateHelpDeskTicket(Int64? id = default(Int64?), HelpDeskTicket helpDeskTicket = default(HelpDeskTicket))
        {
            var uri = new Uri(baseUri, $"HelpDeskTickets({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", helpDeskTicket.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(helpDeskTicket), Encoding.UTF8, "application/json");

            OnUpdateHelpDeskTicket(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteHelpDeskTicketDetail(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteHelpDeskTicketDetail(Int64? id = default(Int64?))
        {
            var uri = new Uri(baseUri, $"HelpDeskTicketDetails({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteHelpDeskTicketDetail(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetHelpDeskTicketDetailById(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HelpDeskTicketDetail> GetHelpDeskTicketDetailById(Int64? id = default(Int64?))
        {
            var uri = new Uri(baseUri, $"HelpDeskTicketDetails({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetHelpDeskTicketDetailById(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HelpDeskTicketDetail>();
        }
        partial void OnUpdateHelpDeskTicketDetail(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateHelpDeskTicketDetail(Int64? id = default(Int64?), HelpDeskTicketDetail helpDeskTicketDetail = default(HelpDeskTicketDetail))
        {
            var uri = new Uri(baseUri, $"HelpDeskTicketDetails({id})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", helpDeskTicketDetail.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(helpDeskTicketDetail), Encoding.UTF8, "application/json");

            OnUpdateHelpDeskTicketDetail(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteLocationList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteLocationList(Int64? locationId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"LocationLists({locationId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteLocationList(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetLocationListBylocationId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<LocationList> GetLocationListBylocationId(Int64? locationId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"LocationLists({locationId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetLocationListBylocationId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<LocationList>();
        }
        partial void OnUpdateLocationList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateLocationList(Int64? locationId = default(Int64?), LocationList locationList = default(LocationList))
        {
            var uri = new Uri(baseUri, $"LocationLists({locationId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", locationList.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(locationList), Encoding.UTF8, "application/json");

            OnUpdateLocationList(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeletePersistedGrant(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeletePersistedGrant(string key = default(string))
        {
            var uri = new Uri(baseUri, $"PersistedGrants('{HttpUtility.UrlEncode(key.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeletePersistedGrant(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetPersistedGrantByKey(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<PersistedGrant> GetPersistedGrantByKey(string key = default(string))
        {
            var uri = new Uri(baseUri, $"PersistedGrants('{HttpUtility.UrlEncode(key.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetPersistedGrantByKey(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<PersistedGrant>();
        }
        partial void OnUpdatePersistedGrant(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdatePersistedGrant(string key = default(string), PersistedGrant persistedGrant = default(PersistedGrant))
        {
            var uri = new Uri(baseUri, $"PersistedGrants('{HttpUtility.UrlEncode(key.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", persistedGrant.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(persistedGrant), Encoding.UTF8, "application/json");

            OnUpdatePersistedGrant(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteServiceCatglist(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteServiceCatglist(Int64? serviceCatgId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"ServiceCatglists({serviceCatgId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteServiceCatglist(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetServiceCatglistByServiceCatgId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ServiceCatglist> GetServiceCatglistByServiceCatgId(Int64? serviceCatgId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"ServiceCatglists({serviceCatgId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetServiceCatglistByServiceCatgId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ServiceCatglist>();
        }
        partial void OnUpdateServiceCatglist(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateServiceCatglist(Int64? serviceCatgId = default(Int64?), ServiceCatglist serviceCatglist = default(ServiceCatglist))
        {
            var uri = new Uri(baseUri, $"ServiceCatglists({serviceCatgId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", serviceCatglist.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(serviceCatglist), Encoding.UTF8, "application/json");

            OnUpdateServiceCatglist(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteServicesList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteServicesList(Int64? serviceId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"ServicesLists({serviceId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteServicesList(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetServicesListByServiceId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ServicesList> GetServicesListByServiceId(Int64? serviceId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"ServicesLists({serviceId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetServicesListByServiceId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ServicesList>();
        }
        partial void OnUpdateServicesList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateServicesList(Int64? serviceId = default(Int64?), ServicesList servicesList = default(ServicesList))
        {
            var uri = new Uri(baseUri, $"ServicesLists({serviceId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", servicesList.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(servicesList), Encoding.UTF8, "application/json");

            OnUpdateServicesList(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
        partial void OnDeleteTicketRequesterUsersList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteTicketRequesterUsersList(string ticketRequesterUser = default(string))
        {
            var uri = new Uri(baseUri, $"TicketRequesterUsersLists('{HttpUtility.UrlEncode(ticketRequesterUser.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteTicketRequesterUsersList(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetTicketRequesterUsersListByTicketRequesterUser(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<TicketRequesterUsersList> GetTicketRequesterUsersListByTicketRequesterUser(string ticketRequesterUser = default(string))
        {
            var uri = new Uri(baseUri, $"TicketRequesterUsersLists('{HttpUtility.UrlEncode(ticketRequesterUser.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetTicketRequesterUsersListByTicketRequesterUser(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<TicketRequesterUsersList>();
        }
        partial void OnUpdateTicketRequesterUsersList(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateTicketRequesterUsersList(string ticketRequesterUser = default(string), TicketRequesterUsersList ticketRequesterUsersList = default(TicketRequesterUsersList))
        {
            var uri = new Uri(baseUri, $"TicketRequesterUsersLists('{HttpUtility.UrlEncode(ticketRequesterUser.Trim())}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Headers.Add("If-Match", ticketRequesterUsersList.ETag);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(ticketRequesterUsersList), Encoding.UTF8, "application/json");

            OnUpdateTicketRequesterUsersList(httpRequestMessage);
            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<HttpResponseMessage>();
        }
    }
}
