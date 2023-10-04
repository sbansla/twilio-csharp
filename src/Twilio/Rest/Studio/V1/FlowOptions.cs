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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Studio.V1
{
    /// <summary> Delete a specific Flow. </summary>
    public class DeleteFlowOptions : IOptions<FlowResource>
    {
        
        ///<summary> The SID of the Flow resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteFlowOptions </summary>
        /// <param name="pathSid"> The SID of the Flow resource to delete. </param>
        public DeleteFlowOptions(string pathSid)
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


    /// <summary> Retrieve a specific Flow. </summary>
    public class FetchFlowOptions : IOptions<FlowResource>
    {
    
        ///<summary> The SID of the Flow resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchFlowOptions </summary>
        /// <param name="pathSid"> The SID of the Flow resource to fetch. </param>
        public FetchFlowOptions(string pathSid)
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


    /// <summary> Retrieve a list of all Flows. </summary>
    public class ReadFlowOptions : ReadOptions<FlowResource>
    {
    



        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }

        

    }

}

