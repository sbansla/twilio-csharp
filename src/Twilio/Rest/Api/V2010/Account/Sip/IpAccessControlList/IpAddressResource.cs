/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Api.V2010.Account.Sip.IpAccessControlList
{
    public class IpAddressResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateIpAddressOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{IpAccessControlListSid}/IpAddresses.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathIpAccessControlListSid = options.PathIpAccessControlListSid;
            path = path.Replace("{"+"IpAccessControlListSid"+"}", PathIpAccessControlListSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new IpAddress resource. </summary>
        /// <param name="options"> Create IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static IpAddressResource Create(CreateIpAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new IpAddress resource. </summary>
        /// <param name="options"> Create IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<IpAddressResource> CreateAsync(CreateIpAddressOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid with which to associate the created IpAddress resource. </param>
        /// <param name="friendlyName"> A human readable descriptive text for this resource, up to 255 characters long. </param>
        /// <param name="ipAddress"> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="cidrPrefixLength"> An integer representing the length of the CIDR prefix to use with this IP address when accepting traffic. By default the entire IP address is used. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static IpAddressResource Create(
                                          string pathIpAccessControlListSid,
                                          string friendlyName,
                                          string ipAddress,
                                          string pathAccountSid = null,
                                          int? cidrPrefixLength = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateIpAddressOptions(pathIpAccessControlListSid, friendlyName, ipAddress){  PathAccountSid = pathAccountSid, CidrPrefixLength = cidrPrefixLength };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid with which to associate the created IpAddress resource. </param>
        /// <param name="friendlyName"> A human readable descriptive text for this resource, up to 255 characters long. </param>
        /// <param name="ipAddress"> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="cidrPrefixLength"> An integer representing the length of the CIDR prefix to use with this IP address when accepting traffic. By default the entire IP address is used. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<IpAddressResource> CreateAsync(
                                                                                  string pathIpAccessControlListSid,
                                                                                  string friendlyName,
                                                                                  string ipAddress,
                                                                                  string pathAccountSid = null,
                                                                                  int? cidrPrefixLength = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateIpAddressOptions(pathIpAccessControlListSid, friendlyName, ipAddress){  PathAccountSid = pathAccountSid, CidrPrefixLength = cidrPrefixLength };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete an IpAddress resource. </summary>
        /// <param name="options"> Delete IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        private static Request BuildDeleteRequest(DeleteIpAddressOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{IpAccessControlListSid}/IpAddresses/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathIpAccessControlListSid = options.PathIpAccessControlListSid;
            path = path.Replace("{"+"IpAccessControlListSid"+"}", PathIpAccessControlListSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete an IpAddress resource. </summary>
        /// <param name="options"> Delete IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static bool Delete(DeleteIpAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete an IpAddress resource. </summary>
        /// <param name="options"> Delete IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteIpAddressOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete an IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to delete. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to delete. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static bool Delete(string pathIpAccessControlListSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAddressOptions(pathIpAccessControlListSid, pathSid)         { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete an IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to delete. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to delete. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathIpAccessControlListSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteIpAddressOptions(pathIpAccessControlListSid, pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchIpAddressOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{IpAccessControlListSid}/IpAddresses/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathIpAccessControlListSid = options.PathIpAccessControlListSid;
            path = path.Replace("{"+"IpAccessControlListSid"+"}", PathIpAccessControlListSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Read one IpAddress resource. </summary>
        /// <param name="options"> Fetch IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static IpAddressResource Fetch(FetchIpAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Read one IpAddress resource. </summary>
        /// <param name="options"> Fetch IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<IpAddressResource> FetchAsync(FetchIpAddressOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Read one IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to fetch. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the IpAddress resource to fetch. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static IpAddressResource Fetch(
                                         string pathIpAccessControlListSid, 
                                         string pathSid, 
                                         string pathAccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchIpAddressOptions(pathIpAccessControlListSid, pathSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Read one IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to fetch. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the IpAddress resource to fetch. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<IpAddressResource> FetchAsync(string pathIpAccessControlListSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchIpAddressOptions(pathIpAccessControlListSid, pathSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadIpAddressOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{IpAccessControlListSid}/IpAddresses.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathIpAccessControlListSid = options.PathIpAccessControlListSid;
            path = path.Replace("{"+"IpAccessControlListSid"+"}", PathIpAccessControlListSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Read multiple IpAddress resources. </summary>
        /// <param name="options"> Read IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static ResourceSet<IpAddressResource> Read(ReadIpAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<IpAddressResource>.FromJson("ip_addresses", response.Content);
            return new ResourceSet<IpAddressResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Read multiple IpAddress resources. </summary>
        /// <param name="options"> Read IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<IpAddressResource>> ReadAsync(ReadIpAddressOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<IpAddressResource>.FromJson("ip_addresses", response.Content);
            return new ResourceSet<IpAddressResource>(page, options, client);
        }
        #endif
        /// <summary> Read multiple IpAddress resources. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to read. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static ResourceSet<IpAddressResource> Read(
                                                     string pathIpAccessControlListSid,
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadIpAddressOptions(pathIpAccessControlListSid){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Read multiple IpAddress resources. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to read. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<IpAddressResource>> ReadAsync(
                                                                                             string pathIpAccessControlListSid,
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadIpAddressOptions(pathIpAccessControlListSid){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<IpAddressResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<IpAddressResource>.FromJson("ip_addresses", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<IpAddressResource> NextPage(Page<IpAddressResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<IpAddressResource>.FromJson("ip_addresses", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<IpAddressResource> PreviousPage(Page<IpAddressResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<IpAddressResource>.FromJson("ip_addresses", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateIpAddressOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/IpAccessControlLists/{IpAccessControlListSid}/IpAddresses/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathIpAccessControlListSid = options.PathIpAccessControlListSid;
            path = path.Replace("{"+"IpAccessControlListSid"+"}", PathIpAccessControlListSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update an IpAddress resource. </summary>
        /// <param name="options"> Update IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static IpAddressResource Update(UpdateIpAddressOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an IpAddress resource. </summary>
        /// <param name="options"> Update IpAddress parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<IpAddressResource> UpdateAsync(UpdateIpAddressOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update an IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to update. </param>
        /// <param name="pathSid"> A 34 character string that identifies the IpAddress resource to update. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="ipAddress"> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </param>
        /// <param name="friendlyName"> A human readable descriptive text for this resource, up to 255 characters long. </param>
        /// <param name="cidrPrefixLength"> An integer representing the length of the CIDR prefix to use with this IP address when accepting traffic. By default the entire IP address is used. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of IpAddress </returns>
        public static IpAddressResource Update(
                                          string pathIpAccessControlListSid,
                                          string pathSid,
                                          string pathAccountSid = null,
                                          string ipAddress = null,
                                          string friendlyName = null,
                                          int? cidrPrefixLength = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateIpAddressOptions(pathIpAccessControlListSid, pathSid){ PathAccountSid = pathAccountSid, IpAddress = ipAddress, FriendlyName = friendlyName, CidrPrefixLength = cidrPrefixLength };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update an IpAddress resource. </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to update. </param>
        /// <param name="pathSid"> A 34 character string that identifies the IpAddress resource to update. </param>
        /// <param name="pathAccountSid"> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </param>
        /// <param name="ipAddress"> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </param>
        /// <param name="friendlyName"> A human readable descriptive text for this resource, up to 255 characters long. </param>
        /// <param name="cidrPrefixLength"> An integer representing the length of the CIDR prefix to use with this IP address when accepting traffic. By default the entire IP address is used. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of IpAddress </returns>
        public static async System.Threading.Tasks.Task<IpAddressResource> UpdateAsync(
                                                                              string pathIpAccessControlListSid,
                                                                              string pathSid,
                                                                              string pathAccountSid = null,
                                                                              string ipAddress = null,
                                                                              string friendlyName = null,
                                                                              int? cidrPrefixLength = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateIpAddressOptions(pathIpAccessControlListSid, pathSid){ PathAccountSid = pathAccountSid, IpAddress = ipAddress, FriendlyName = friendlyName, CidrPrefixLength = cidrPrefixLength };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a IpAddressResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> IpAddressResource object represented by the provided JSON </returns>
        public static IpAddressResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<IpAddressResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A human readable descriptive text for this resource, up to 255 characters long. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </summary> 
        [JsonProperty("ip_address")]
        public string IpAddress { get; private set; }

        ///<summary> An integer representing the length of the CIDR prefix to use with this IP address when accepting traffic. By default the entire IP address is used. </summary> 
        [JsonProperty("cidr_prefix_length")]
        public int? CidrPrefixLength { get; private set; }

        ///<summary> The unique id of the IpAccessControlList resource that includes this resource. </summary> 
        [JsonProperty("ip_access_control_list_sid")]
        public string IpAccessControlListSid { get; private set; }

        ///<summary> The date that this resource was created, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The URI for this resource, relative to `https://api.twilio.com` </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private IpAddressResource() {

        }
    }
}

