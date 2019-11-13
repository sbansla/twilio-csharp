/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Verify.V2.Service
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Create a new Verification for a To number using a Service
    /// </summary>
    public class CreateVerificationOptions : IOptions<VerificationResource>
    {
        /// <summary>
        /// The SID of the verification Service to create the resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The phone number or email to verify
        /// </summary>
        public string To { get; }
        /// <summary>
        /// The verification method to use
        /// </summary>
        public string Channel { get; }
        /// <summary>
        /// The text of a custom message to use for the verification
        /// </summary>
        public string CustomMessage { get; set; }
        /// <summary>
        /// The digits to send after a phone call is answered
        /// </summary>
        public string SendDigits { get; set; }
        /// <summary>
        /// The locale to use for the verification SMS or call
        /// </summary>
        public string Locale { get; set; }
        /// <summary>
        /// A pre-generated code
        /// </summary>
        public string CustomCode { get; set; }
        /// <summary>
        /// The amount of the associated PSD2 compliant transaction.
        /// </summary>
        public string Amount { get; set; }
        /// <summary>
        /// The payee of the associated PSD2 compliant transaction
        /// </summary>
        public string Payee { get; set; }
        /// <summary>
        /// The custom key-value pairs of Programmable Rate Limits.
        /// </summary>
        public object RateLimits { get; set; }
        /// <summary>
        /// Channel specific configuration in json format.
        /// </summary>
        public object ChannelConfiguration { get; set; }

        /// <summary>
        /// Construct a new CreateVerificationOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to create the resource under </param>
        /// <param name="to"> The phone number or email to verify </param>
        /// <param name="channel"> The verification method to use </param>
        public CreateVerificationOptions(string pathServiceSid, string to, string channel)
        {
            PathServiceSid = pathServiceSid;
            To = to;
            Channel = channel;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }

            if (Channel != null)
            {
                p.Add(new KeyValuePair<string, string>("Channel", Channel));
            }

            if (CustomMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomMessage", CustomMessage));
            }

            if (SendDigits != null)
            {
                p.Add(new KeyValuePair<string, string>("SendDigits", SendDigits));
            }

            if (Locale != null)
            {
                p.Add(new KeyValuePair<string, string>("Locale", Locale));
            }

            if (CustomCode != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomCode", CustomCode));
            }

            if (Amount != null)
            {
                p.Add(new KeyValuePair<string, string>("Amount", Amount));
            }

            if (Payee != null)
            {
                p.Add(new KeyValuePair<string, string>("Payee", Payee));
            }

            if (RateLimits != null)
            {
                p.Add(new KeyValuePair<string, string>("RateLimits", Serializers.JsonObject(RateLimits)));
            }

            if (ChannelConfiguration != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelConfiguration", Serializers.JsonObject(ChannelConfiguration)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Update a Verification status
    /// </summary>
    public class UpdateVerificationOptions : IOptions<VerificationResource>
    {
        /// <summary>
        /// The SID of the verification Service to update the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The new status of the resource
        /// </summary>
        public VerificationResource.StatusEnum Status { get; }

        /// <summary>
        /// Construct a new UpdateVerificationOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to update the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="status"> The new status of the resource </param>
        public UpdateVerificationOptions(string pathServiceSid, string pathSid, VerificationResource.StatusEnum status)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
            Status = status;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Fetch a specific Verification
    /// </summary>
    public class FetchVerificationOptions : IOptions<VerificationResource>
    {
        /// <summary>
        /// The SID of the verification Service to fetch the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchVerificationOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the verification Service to fetch the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchVerificationOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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