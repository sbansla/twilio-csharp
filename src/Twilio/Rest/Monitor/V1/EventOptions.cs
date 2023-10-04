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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Monitor.V1
{
    /// <summary> fetch </summary>
    public class FetchEventOptions : IOptions<EventResource>
    {
    
        ///<summary> The SID of the Event resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchEventOptions </summary>
        /// <param name="pathSid"> The SID of the Event resource to fetch. </param>
        public FetchEventOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }

        

    }


    /// <summary> Returns a list of events in the account, sorted by event-date. </summary>
    public class ReadEventOptions : ReadOptions<EventResource>
    {
    
        ///<summary> Only include events initiated by this Actor. Useful for auditing actions taken by specific users or API credentials. </summary> 
        public string ActorSid { get; set; }

        ///<summary> Only include events of this [Event Type](https://www.twilio.com/docs/usage/monitor-events#event-types). </summary> 
        public string EventType { get; set; }

        ///<summary> Only include events that refer to this resource. Useful for discovering the history of a specific resource. </summary> 
        public string ResourceSid { get; set; }

        ///<summary> Only include events that originated from this IP address. Useful for tracking suspicious activity originating from the API or the Twilio Console. </summary> 
        public string SourceIpAddress { get; set; }

        ///<summary> Only include events that occurred on or after this date. Specify the date in GMT and [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        public DateTime? StartDate { get; set; }

        ///<summary> Only include events that occurred on or before this date. Specify the date in GMT and [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        public DateTime? EndDate { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ActorSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ActorSid", ActorSid));
            }
            if (EventType != null)
            {
                p.Add(new KeyValuePair<string, string>("EventType", EventType));
            }
            if (ResourceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ResourceSid", ResourceSid));
            }
            if (SourceIpAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceIpAddress", SourceIpAddress));
            }
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

