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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Api.V2010.Account
{

    /// <summary> Create a new Signing Key for the account making the request. </summary>
    public class CreateNewSigningKeyOptions : IOptions<NewSigningKeyResource>
    {
        
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will be responsible for the new Key resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }



        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }

        

    }
}

