/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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



namespace Twilio.Rest.Studio.V2.Flow
{
    public class FlowTestUserResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchFlowTestUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Flows/{Sid}/TestUsers";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch flow test users </summary>
        /// <param name="options"> Fetch FlowTestUser parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowTestUser </returns>
        public static FlowTestUserResource Fetch(FetchFlowTestUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch flow test users </summary>
        /// <param name="options"> Fetch FlowTestUser parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowTestUser </returns>
        public static async System.Threading.Tasks.Task<FlowTestUserResource> FetchAsync(FetchFlowTestUserOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch flow test users </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowTestUser </returns>
        public static FlowTestUserResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchFlowTestUserOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch flow test users </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowTestUser </returns>
        public static async System.Threading.Tasks.Task<FlowTestUserResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchFlowTestUserOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateFlowTestUserOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Flows/{Sid}/TestUsers";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Studio,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update flow test users </summary>
        /// <param name="options"> Update FlowTestUser parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowTestUser </returns>
        public static FlowTestUserResource Update(UpdateFlowTestUserOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update flow test users </summary>
        /// <param name="options"> Update FlowTestUser parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowTestUser </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<FlowTestUserResource> UpdateAsync(UpdateFlowTestUserOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update flow test users </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        /// <param name="testUsers"> List of test user identities that can test draft versions of the flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowTestUser </returns>
        public static FlowTestUserResource Update(
                                          string pathSid,
                                          List<string> testUsers,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateFlowTestUserOptions(pathSid, testUsers){  };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update flow test users </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        /// <param name="testUsers"> List of test user identities that can test draft versions of the flow. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowTestUser </returns>
        public static async System.Threading.Tasks.Task<FlowTestUserResource> UpdateAsync(
                                                                              string pathSid,
                                                                              List<string> testUsers,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateFlowTestUserOptions(pathSid, testUsers){  };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a FlowTestUserResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FlowTestUserResource object represented by the provided JSON </returns>
        public static FlowTestUserResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FlowTestUserResource>(json);
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

    
        ///<summary> Unique identifier of the flow. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> List of test user identities that can test draft versions of the flow. </summary> 
        [JsonProperty("test_users")]
        public List<string> TestUsers { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private FlowTestUserResource() {

        }
    }
}

