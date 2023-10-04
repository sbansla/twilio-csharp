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



namespace Twilio.Rest.Studio.V2.Flow.Execution.ExecutionStep
{
    public class ExecutionStepContextResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchExecutionStepContextOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Flows/{FlowSid}/Executions/{ExecutionSid}/Steps/{StepSid}/Context";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
            string PathExecutionSid = options.PathExecutionSid;
            path = path.Replace("{"+"ExecutionSid"+"}", PathExecutionSid);
            string PathStepSid = options.PathStepSid;
            path = path.Replace("{"+"StepSid"+"}", PathStepSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve the context for an Execution Step. </summary>
        /// <param name="options"> Fetch ExecutionStepContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionStepContext </returns>
        public static ExecutionStepContextResource Fetch(FetchExecutionStepContextOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve the context for an Execution Step. </summary>
        /// <param name="options"> Fetch ExecutionStepContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionStepContext </returns>
        public static async System.Threading.Tasks.Task<ExecutionStepContextResource> FetchAsync(FetchExecutionStepContextOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve the context for an Execution Step. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution resource with the Step to fetch. </param>
        /// <param name="pathStepSid"> The SID of the Step to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionStepContext </returns>
        public static ExecutionStepContextResource Fetch(
                                         string pathFlowSid, 
                                         string pathExecutionSid, 
                                         string pathStepSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchExecutionStepContextOptions(pathFlowSid, pathExecutionSid, pathStepSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve the context for an Execution Step. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution resource with the Step to fetch. </param>
        /// <param name="pathStepSid"> The SID of the Step to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionStepContext </returns>
        public static async System.Threading.Tasks.Task<ExecutionStepContextResource> FetchAsync(string pathFlowSid, string pathExecutionSid, string pathStepSid, ITwilioRestClient client = null)
        {
            var options = new FetchExecutionStepContextOptions(pathFlowSid, pathExecutionSid, pathStepSid){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ExecutionStepContextResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ExecutionStepContextResource object represented by the provided JSON </returns>
        public static ExecutionStepContextResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ExecutionStepContextResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ExecutionStepContext resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The current state of the Flow's Execution. As a flow executes, we save its state in this context. We save data that your widgets can access as variables in configuration fields or in text areas as variable substitution. </summary> 
        [JsonProperty("context")]
        public object Context { get; private set; }

        ///<summary> The SID of the context's Execution resource. </summary> 
        [JsonProperty("execution_sid")]
        public string ExecutionSid { get; private set; }

        ///<summary> The SID of the Flow. </summary> 
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }

        ///<summary> The SID of the Step that the context is associated with. </summary> 
        [JsonProperty("step_sid")]
        public string StepSid { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private ExecutionStepContextResource() {

        }
    }
}

