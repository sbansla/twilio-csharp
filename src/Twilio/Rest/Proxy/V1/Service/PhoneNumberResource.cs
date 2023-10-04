/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Proxy
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
using Twilio.Types;


namespace Twilio.Rest.Proxy.V1.Service
{
    public class PhoneNumberResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreatePhoneNumberOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/PhoneNumbers";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Proxy,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Add a Phone Number to a Service's Proxy Number Pool. </summary>
        /// <param name="options"> Create PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Create(CreatePhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Add a Phone Number to a Service's Proxy Number Pool. </summary>
        /// <param name="options"> Create PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> CreateAsync(CreatePhoneNumberOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Add a Phone Number to a Service's Proxy Number Pool. </summary>
        /// <param name="pathServiceSid"> The SID parent [Service](https://www.twilio.com/docs/proxy/api/service) resource of the new PhoneNumber resource. </param>
        /// <param name="sid"> The SID of a Twilio [IncomingPhoneNumber](https://www.twilio.com/docs/phone-numbers/api/incomingphonenumber-resource) resource that represents the Twilio Number you would like to assign to your Proxy Service. </param>
        /// <param name="phoneNumber"> The phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format.  E.164 phone numbers consist of a + followed by the country code and subscriber number without punctuation characters. For example, +14155551234. </param>
        /// <param name="isReserved"> Whether the new phone number should be reserved and not be assigned to a participant using proxy pool logic. See [Reserved Phone Numbers](https://www.twilio.com/docs/proxy/reserved-phone-numbers) for more information. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Create(
                                          string pathServiceSid,
                                          string sid = null,
                                          Types.PhoneNumber phoneNumber = null,
                                          bool? isReserved = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreatePhoneNumberOptions(pathServiceSid){  Sid = sid, PhoneNumber = phoneNumber, IsReserved = isReserved };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Add a Phone Number to a Service's Proxy Number Pool. </summary>
        /// <param name="pathServiceSid"> The SID parent [Service](https://www.twilio.com/docs/proxy/api/service) resource of the new PhoneNumber resource. </param>
        /// <param name="sid"> The SID of a Twilio [IncomingPhoneNumber](https://www.twilio.com/docs/phone-numbers/api/incomingphonenumber-resource) resource that represents the Twilio Number you would like to assign to your Proxy Service. </param>
        /// <param name="phoneNumber"> The phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format.  E.164 phone numbers consist of a + followed by the country code and subscriber number without punctuation characters. For example, +14155551234. </param>
        /// <param name="isReserved"> Whether the new phone number should be reserved and not be assigned to a participant using proxy pool logic. See [Reserved Phone Numbers](https://www.twilio.com/docs/proxy/reserved-phone-numbers) for more information. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string sid = null,
                                                                                  Types.PhoneNumber phoneNumber = null,
                                                                                  bool? isReserved = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreatePhoneNumberOptions(pathServiceSid){  Sid = sid, PhoneNumber = phoneNumber, IsReserved = isReserved };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Phone Number from a Service. </summary>
        /// <param name="options"> Delete PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        private static Request BuildDeleteRequest(DeletePhoneNumberOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/PhoneNumbers/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Phone Number from a Service. </summary>
        /// <param name="options"> Delete PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static bool Delete(DeletePhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Phone Number from a Service. </summary>
        /// <param name="options"> Delete PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeletePhoneNumberOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Phone Number from a Service. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PhoneNumber resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeletePhoneNumberOptions(pathServiceSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Phone Number from a Service. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PhoneNumber resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeletePhoneNumberOptions(pathServiceSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchPhoneNumberOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/PhoneNumbers/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Phone Number. </summary>
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Fetch(FetchPhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Phone Number. </summary>
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(FetchPhoneNumberOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Phone Number. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PhoneNumber resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Fetch(
                                         string pathServiceSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(pathServiceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Phone Number. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PhoneNumber resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(pathServiceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadPhoneNumberOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/PhoneNumbers";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Phone Numbers in the Proxy Number Pool for a Service. A maximum of 100 records will be returned per page. </summary>
        /// <param name="options"> Read PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static ResourceSet<PhoneNumberResource> Read(ReadPhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<PhoneNumberResource>.FromJson("phone_numbers", response.Content);
            return new ResourceSet<PhoneNumberResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Phone Numbers in the Proxy Number Pool for a Service. A maximum of 100 records will be returned per page. </summary>
        /// <param name="options"> Read PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PhoneNumberResource>> ReadAsync(ReadPhoneNumberOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<PhoneNumberResource>.FromJson("phone_numbers", response.Content);
            return new ResourceSet<PhoneNumberResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Phone Numbers in the Proxy Number Pool for a Service. A maximum of 100 records will be returned per page. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static ResourceSet<PhoneNumberResource> Read(
                                                     string pathServiceSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadPhoneNumberOptions(pathServiceSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Phone Numbers in the Proxy Number Pool for a Service. A maximum of 100 records will be returned per page. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PhoneNumberResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadPhoneNumberOptions(pathServiceSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<PhoneNumberResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<PhoneNumberResource>.FromJson("phone_numbers", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<PhoneNumberResource> NextPage(Page<PhoneNumberResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PhoneNumberResource>.FromJson("phone_numbers", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<PhoneNumberResource> PreviousPage(Page<PhoneNumberResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PhoneNumberResource>.FromJson("phone_numbers", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdatePhoneNumberOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/PhoneNumbers/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Proxy,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a specific Proxy Number. </summary>
        /// <param name="options"> Update PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Update(UpdatePhoneNumberOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Proxy Number. </summary>
        /// <param name="options"> Update PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<PhoneNumberResource> UpdateAsync(UpdatePhoneNumberOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a specific Proxy Number. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resource to update. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PhoneNumber resource to update. </param>
        /// <param name="isReserved"> Whether the phone number should be reserved and not be assigned to a participant using proxy pool logic. See [Reserved Phone Numbers](https://www.twilio.com/docs/proxy/reserved-phone-numbers) for more information. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Update(
                                          string pathServiceSid,
                                          string pathSid,
                                          bool? isReserved = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdatePhoneNumberOptions(pathServiceSid, pathSid){ IsReserved = isReserved };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a specific Proxy Number. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the PhoneNumber resource to update. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the PhoneNumber resource to update. </param>
        /// <param name="isReserved"> Whether the phone number should be reserved and not be assigned to a participant using proxy pool logic. See [Reserved Phone Numbers](https://www.twilio.com/docs/proxy/reserved-phone-numbers) for more information. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathSid,
                                                                              bool? isReserved = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdatePhoneNumberOptions(pathServiceSid, pathSid){ IsReserved = isReserved };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PhoneNumberResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PhoneNumberResource object represented by the provided JSON </returns>
        public static PhoneNumberResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PhoneNumberResource>(json);
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

    
        ///<summary> The unique string that we created to identify the PhoneNumber resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the PhoneNumber resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the PhoneNumber resource's parent [Service](https://www.twilio.com/docs/proxy/api/service) resource. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date and time in GMT when the resource was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date and time in GMT when the resource was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, which consists of a + followed by the country code and subscriber number. </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The ISO Country Code for the phone number. </summary> 
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }

        ///<summary> The capabilities </summary> 
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }

        ///<summary> The absolute URL of the PhoneNumber resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Whether the phone number should be reserved and not be assigned to a participant using proxy pool logic. See [Reserved Phone Numbers](https://www.twilio.com/docs/proxy/reserved-phone-numbers) for more information. </summary> 
        [JsonProperty("is_reserved")]
        public bool? IsReserved { get; private set; }

        ///<summary> The number of open session assigned to the number. See the [How many Phone Numbers do I need?](https://www.twilio.com/docs/proxy/phone-numbers-needed) guide for more information. </summary> 
        [JsonProperty("in_use")]
        public int? InUse { get; private set; }



        private PhoneNumberResource() {

        }
    }
}

