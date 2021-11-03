/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Wireless.V1
{

    /// <summary>
    /// Fetch a Sim resource on your Account.
    /// </summary>
    public class FetchSimOptions : IOptions<SimResource>
    {
        /// <summary>
        /// The SID of the Sim resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSimOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the Sim resource to fetch </param>
        public FetchSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of Sim resources on your Account.
    /// </summary>
    public class ReadSimOptions : ReadOptions<SimResource>
    {
        /// <summary>
        /// Only return Sim resources with this status
        /// </summary>
        public SimResource.StatusEnum Status { get; set; }
        /// <summary>
        /// Only return Sim resources with this ICCID
        /// </summary>
        public string Iccid { get; set; }
        /// <summary>
        /// Only return Sim resources assigned to this RatePlan resource
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public string EId { get; set; }
        /// <summary>
        /// Only return Sim resources with this registration code
        /// </summary>
        public string SimRegistrationCode { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (Iccid != null)
            {
                p.Add(new KeyValuePair<string, string>("Iccid", Iccid));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan));
            }

            if (EId != null)
            {
                p.Add(new KeyValuePair<string, string>("EId", EId));
            }

            if (SimRegistrationCode != null)
            {
                p.Add(new KeyValuePair<string, string>("SimRegistrationCode", SimRegistrationCode));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Updates the given properties of a Sim resource on your Account.
    /// </summary>
    public class UpdateSimOptions : IOptions<SimResource>
    {
        /// <summary>
        /// The SID of the Sim resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The HTTP method we should use to call callback_url
        /// </summary>
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call when the Sim resource has finished updating
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// A string to describe the Sim resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The SID or unique name of the RatePlan resource to which the Sim resource should be assigned
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// The new status of the Sim resource
        /// </summary>
        public SimResource.StatusEnum Status { get; set; }
        /// <summary>
        /// The HTTP method we should use to call commands_callback_url
        /// </summary>
        public Twilio.Http.HttpMethod CommandsCallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call when the SIM sends a Command
        /// </summary>
        public Uri CommandsCallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call sms_fallback_url
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call when an error occurs while retrieving or executing the TwiML requested from sms_url
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call sms_url
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// The URL we should call when the SIM-connected device sends an SMS message that is not a Command
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// Deprecated
        /// </summary>
        public Uri VoiceUrl { get; set; }
        /// <summary>
        /// Initiate a connectivity reset on a SIM
        /// </summary>
        public SimResource.ResetStatusEnum ResetStatus { get; set; }
        /// <summary>
        /// The SID of the Account to which the Sim resource should belong
        /// </summary>
        public string AccountSid { get; set; }

        /// <summary>
        /// Construct a new UpdateSimOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the Sim resource to update </param>
        public UpdateSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (CommandsCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackMethod", CommandsCallbackMethod.ToString()));
            }

            if (CommandsCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackUrl", Serializers.Url(CommandsCallbackUrl)));
            }

            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }

            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", Serializers.Url(SmsFallbackUrl)));
            }

            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }

            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", Serializers.Url(SmsUrl)));
            }

            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }

            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }

            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }

            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }

            if (ResetStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ResetStatus", ResetStatus.ToString()));
            }

            if (AccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AccountSid", AccountSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a Sim resource on your Account.
    /// </summary>
    public class DeleteSimOptions : IOptions<SimResource>
    {
        /// <summary>
        /// The SID of the Sim Resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSimOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the Sim Resource to delete </param>
        public DeleteSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}