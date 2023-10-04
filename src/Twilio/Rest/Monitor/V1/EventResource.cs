/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Monitor
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



namespace Twilio.Rest.Monitor.V1
{
    public class EventResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchEventOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Events/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Monitor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static EventResource Fetch(FetchEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(FetchEventOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Event resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static EventResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Event resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadEventOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Events";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Monitor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Returns a list of events in the account, sorted by event-date. </summary>
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static ResourceSet<EventResource> Read(ReadEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Returns a list of events in the account, sorted by event-date. </summary>
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(ReadEventOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }
        #endif
        /// <summary> Returns a list of events in the account, sorted by event-date. </summary>
        /// <param name="actorSid"> Only include events initiated by this Actor. Useful for auditing actions taken by specific users or API credentials. </param>
        /// <param name="eventType"> Only include events of this [Event Type](https://www.twilio.com/docs/usage/monitor-events#event-types). </param>
        /// <param name="resourceSid"> Only include events that refer to this resource. Useful for discovering the history of a specific resource. </param>
        /// <param name="sourceIpAddress"> Only include events that originated from this IP address. Useful for tracking suspicious activity originating from the API or the Twilio Console. </param>
        /// <param name="startDate"> Only include events that occurred on or after this date. Specify the date in GMT and [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="endDate"> Only include events that occurred on or before this date. Specify the date in GMT and [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static ResourceSet<EventResource> Read(
                                                     string actorSid = null,
                                                     string eventType = null,
                                                     string resourceSid = null,
                                                     string sourceIpAddress = null,
                                                     DateTime? startDate = null,
                                                     DateTime? endDate = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(){ ActorSid = actorSid, EventType = eventType, ResourceSid = resourceSid, SourceIpAddress = sourceIpAddress, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Returns a list of events in the account, sorted by event-date. </summary>
        /// <param name="actorSid"> Only include events initiated by this Actor. Useful for auditing actions taken by specific users or API credentials. </param>
        /// <param name="eventType"> Only include events of this [Event Type](https://www.twilio.com/docs/usage/monitor-events#event-types). </param>
        /// <param name="resourceSid"> Only include events that refer to this resource. Useful for discovering the history of a specific resource. </param>
        /// <param name="sourceIpAddress"> Only include events that originated from this IP address. Useful for tracking suspicious activity originating from the API or the Twilio Console. </param>
        /// <param name="startDate"> Only include events that occurred on or after this date. Specify the date in GMT and [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="endDate"> Only include events that occurred on or before this date. Specify the date in GMT and [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(
                                                                                             string actorSid = null,
                                                                                             string eventType = null,
                                                                                             string resourceSid = null,
                                                                                             string sourceIpAddress = null,
                                                                                             DateTime? startDate = null,
                                                                                             DateTime? endDate = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(){ ActorSid = actorSid, EventType = eventType, ResourceSid = resourceSid, SourceIpAddress = sourceIpAddress, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<EventResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<EventResource> NextPage(Page<EventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<EventResource> PreviousPage(Page<EventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a EventResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EventResource object represented by the provided JSON </returns>
        public static EventResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<EventResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Event resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the actor that caused the event, if available. Can be `null`. </summary> 
        [JsonProperty("actor_sid")]
        public string ActorSid { get; private set; }

        ///<summary> The type of actor that caused the event. Can be: `user` for a change made by a logged-in user in the Twilio Console, `account` for an event caused by an API request by an authenticating Account, `twilio-admin` for an event caused by a Twilio employee, and so on. </summary> 
        [JsonProperty("actor_type")]
        public string ActorType { get; private set; }

        ///<summary> A description of the event. Can be `null`. </summary> 
        [JsonProperty("description")]
        public string Description { get; private set; }

        ///<summary> An object with additional data about the event. The  contents depend on `event_type`. For example, event-types of the form `RESOURCE.updated`, this value contains a `resource_properties` dictionary that describes the previous and updated properties of the resource. </summary> 
        [JsonProperty("event_data")]
        public object EventData { get; private set; }

        ///<summary> The date and time in GMT when the event was recorded specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("event_date")]
        public DateTime? EventDate { get; private set; }

        ///<summary> The event's type. Event-types are typically in the form: `RESOURCE_TYPE.ACTION`, where `RESOURCE_TYPE` is the type of resource that was affected and `ACTION` is what happened to it. For example, `phone-number.created`. For a full list of all event-types, see the [Monitor Event Types](https://www.twilio.com/docs/usage/monitor-events#event-types). </summary> 
        [JsonProperty("event_type")]
        public string EventType { get; private set; }

        ///<summary> The SID of the resource that was affected. </summary> 
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }

        ///<summary> The type of resource that was affected. For a full list of all resource-types, see the [Monitor Event Types](https://www.twilio.com/docs/usage/monitor-events#event-types). </summary> 
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }

        ///<summary> The unique string that we created to identify the Event resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The originating system or interface that caused the event.  Can be: `web` for events caused by user action in the Twilio Console, `api` for events caused by a request to our API, or   `twilio` for events caused by an automated or internal Twilio system. </summary> 
        [JsonProperty("source")]
        public string Source { get; private set; }

        ///<summary> The IP address of the source, if the source is outside the Twilio cloud. This value is `null` for events with `source` of `twilio` </summary> 
        [JsonProperty("source_ip_address")]
        public string SourceIpAddress { get; private set; }

        ///<summary> The absolute URL of the resource that was affected. Can be `null`. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The absolute URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private EventResource() {

        }
    }
}

