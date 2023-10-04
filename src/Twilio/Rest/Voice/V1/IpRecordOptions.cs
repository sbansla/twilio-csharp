/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Voice
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




namespace Twilio.Rest.Voice.V1
{

    /// <summary> create </summary>
    public class CreateIpRecordOptions : IOptions<IpRecordResource>
    {
        
        ///<summary> An IP address in dotted decimal notation, IPv4 only. </summary> 
        public string IpAddress { get; }

        ///<summary> A descriptive string that you create to describe the resource. It is not unique and can be up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> An integer representing the length of the [CIDR](https://tools.ietf.org/html/rfc4632) prefix to use with this IP address. By default the entire IP address is used, which for IPv4 is value 32. </summary> 
        public int? CidrPrefixLength { get; set; }


        /// <summary> Construct a new CreateIpRecordOptions </summary>
        /// <param name="ipAddress"> An IP address in dotted decimal notation, IPv4 only. </param>
        public CreateIpRecordOptions(string ipAddress)
        {
            IpAddress = ipAddress;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (IpAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAddress", IpAddress));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (CidrPrefixLength != null)
            {
                p.Add(new KeyValuePair<string, string>("CidrPrefixLength", CidrPrefixLength.ToString()));
            }
            return p;
        }

        

    }
    /// <summary> delete </summary>
    public class DeleteIpRecordOptions : IOptions<IpRecordResource>
    {
        
        ///<summary> The Twilio-provided string that uniquely identifies the IP Record resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteIpRecordOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to delete. </param>
        public DeleteIpRecordOptions(string pathSid)
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


    /// <summary> fetch </summary>
    public class FetchIpRecordOptions : IOptions<IpRecordResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the IP Record resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchIpRecordOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to fetch. </param>
        public FetchIpRecordOptions(string pathSid)
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


    /// <summary> read </summary>
    public class ReadIpRecordOptions : ReadOptions<IpRecordResource>
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

    /// <summary> update </summary>
    public class UpdateIpRecordOptions : IOptions<IpRecordResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the IP Record resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the resource. It is not unique and can be up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }



        /// <summary> Construct a new UpdateIpRecordOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to update. </param>
        public UpdateIpRecordOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
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

