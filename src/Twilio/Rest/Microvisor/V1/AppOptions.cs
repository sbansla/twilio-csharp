/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Microvisor.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all Apps for an Account.
    /// </summary>
    public class ReadAppOptions : ReadOptions<AppResource>
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Fetch a specific App.
    /// </summary>
    public class FetchAppOptions : IOptions<AppResource>
    {
        /// <summary>
        /// A string that uniquely identifies this App.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchAppOptions
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this App. </param>
        public FetchAppOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Delete a specific App.
    /// </summary>
    public class DeleteAppOptions : IOptions<AppResource>
    {
        /// <summary>
        /// A string that uniquely identifies this App.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteAppOptions
        /// </summary>
        /// <param name="pathSid"> A string that uniquely identifies this App. </param>
        public DeleteAppOptions(string pathSid)
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