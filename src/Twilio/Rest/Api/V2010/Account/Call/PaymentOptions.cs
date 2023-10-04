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




namespace Twilio.Rest.Api.V2010.Account.Call
{

    /// <summary> create an instance of payments. This will start a new payments session </summary>
    public class CreatePaymentOptions : IOptions<PaymentResource>
    {
        
        ///<summary> The SID of the call that will create the resource. Call leg associated with this sid is expected to provide payment information thru DTMF. </summary> 
        public string PathCallSid { get; }

        ///<summary> A unique token that will be used to ensure that multiple API calls with the same information do not result in multiple transactions. This should be a unique string value per API call and can be a randomly generated. </summary> 
        public string IdempotencyKey { get; }

        ///<summary> Provide an absolute or relative URL to receive status updates regarding your Pay session. Read more about the [expected StatusCallback values](https://www.twilio.com/docs/voice/api/payment-resource#statuscallback) </summary> 
        public Uri StatusCallback { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </summary> 
        public string PathAccountSid { get; set; }

        
        public PaymentResource.BankAccountTypeEnum BankAccountType { get; set; }

        ///<summary> A positive decimal value less than 1,000,000 to charge against the credit card or bank account. Default currency can be overwritten with `currency` field. Leave blank or set to 0 to tokenize. </summary> 
        public decimal? ChargeAmount { get; set; }

        ///<summary> The currency of the `charge_amount`, formatted as [ISO 4127](http://www.iso.org/iso/home/standards/currency_codes.htm) format. The default value is `USD` and all values allowed from the Pay Connector are accepted. </summary> 
        public string Currency { get; set; }

        ///<summary> The description can be used to provide more details regarding the transaction. This information is submitted along with the payment details to the Payment Connector which are then posted on the transactions. </summary> 
        public string Description { get; set; }

        ///<summary> A list of inputs that should be accepted. Currently only `dtmf` is supported. All digits captured during a pay session are redacted from the logs. </summary> 
        public string Input { get; set; }

        ///<summary> A positive integer that is used to validate the length of the `PostalCode` inputted by the user. User must enter this many digits. </summary> 
        public int? MinPostalCodeLength { get; set; }

        ///<summary> A single-level JSON object used to pass custom parameters to payment processors. (Required for ACH payments). The information that has to be included here depends on the <Pay> Connector. [Read more](https://www.twilio.com/console/voice/pay-connectors). </summary> 
        public object Parameter { get; set; }

        ///<summary> This is the unique name corresponding to the Pay Connector installed in the Twilio Add-ons. Learn more about [<Pay> Connectors](https://www.twilio.com/console/voice/pay-connectors). The default value is `Default`. </summary> 
        public string PaymentConnector { get; set; }

        
        public PaymentResource.PaymentMethodEnum PaymentMethod { get; set; }

        ///<summary> Indicates whether the credit card postal code (zip code) is a required piece of payment information that must be provided by the caller. The default is `true`. </summary> 
        public bool? PostalCode { get; set; }

        ///<summary> Indicates whether the credit card security code is a required piece of payment information that must be provided by the caller. The default is `true`. </summary> 
        public bool? SecurityCode { get; set; }

        ///<summary> The number of seconds that <Pay> should wait for the caller to press a digit between each subsequent digit, after the first one, before moving on to validate the digits captured. The default is `5`, maximum is `600`. </summary> 
        public int? Timeout { get; set; }

        
        public PaymentResource.TokenTypeEnum TokenType { get; set; }

        ///<summary> Credit card types separated by space that Pay should accept. The default value is `visa mastercard amex` </summary> 
        public string ValidCardTypes { get; set; }


        /// <summary> Construct a new CreatePaymentsOptions </summary>
        /// <param name="pathCallSid"> The SID of the call that will create the resource. Call leg associated with this sid is expected to provide payment information thru DTMF. </param>
        /// <param name="idempotencyKey"> A unique token that will be used to ensure that multiple API calls with the same information do not result in multiple transactions. This should be a unique string value per API call and can be a randomly generated. </param>
        /// <param name="statusCallback"> Provide an absolute or relative URL to receive status updates regarding your Pay session. Read more about the [expected StatusCallback values](https://www.twilio.com/docs/voice/api/payment-resource#statuscallback) </param>
        public CreatePaymentOptions(string pathCallSid, string idempotencyKey, Uri statusCallback)
        {
            PathCallSid = pathCallSid;
            IdempotencyKey = idempotencyKey;
            StatusCallback = statusCallback;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (IdempotencyKey != null)
            {
                p.Add(new KeyValuePair<string, string>("IdempotencyKey", IdempotencyKey));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (BankAccountType != null)
            {
                p.Add(new KeyValuePair<string, string>("BankAccountType", BankAccountType.ToString()));
            }
            if (ChargeAmount != null)
            {
                p.Add(new KeyValuePair<string, string>("ChargeAmount", ChargeAmount.Value.ToString()));
            }
            if (Currency != null)
            {
                p.Add(new KeyValuePair<string, string>("Currency", Currency));
            }
            if (Description != null)
            {
                p.Add(new KeyValuePair<string, string>("Description", Description));
            }
            if (Input != null)
            {
                p.Add(new KeyValuePair<string, string>("Input", Input));
            }
            if (MinPostalCodeLength != null)
            {
                p.Add(new KeyValuePair<string, string>("MinPostalCodeLength", MinPostalCodeLength.ToString()));
            }
            if (Parameter != null)
            {
                p.Add(new KeyValuePair<string, string>("Parameter", Serializers.JsonObject(Parameter)));
            }
            if (PaymentConnector != null)
            {
                p.Add(new KeyValuePair<string, string>("PaymentConnector", PaymentConnector));
            }
            if (PaymentMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("PaymentMethod", PaymentMethod.ToString()));
            }
            if (PostalCode != null)
            {
                p.Add(new KeyValuePair<string, string>("PostalCode", PostalCode.Value.ToString().ToLower()));
            }
            if (SecurityCode != null)
            {
                p.Add(new KeyValuePair<string, string>("SecurityCode", SecurityCode.Value.ToString().ToLower()));
            }
            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }
            if (TokenType != null)
            {
                p.Add(new KeyValuePair<string, string>("TokenType", TokenType.ToString()));
            }
            if (ValidCardTypes != null)
            {
                p.Add(new KeyValuePair<string, string>("ValidCardTypes", ValidCardTypes));
            }
            return p;
        }

        

    }
    /// <summary> update an instance of payments with different phases of payment flows. </summary>
    public class UpdatePaymentOptions : IOptions<PaymentResource>
    {
    
        ///<summary> The SID of the call that will update the resource. This should be the same call sid that was used to create payments resource. </summary> 
        public string PathCallSid { get; }

        ///<summary> The SID of Payments session that needs to be updated. </summary> 
        public string PathSid { get; }

        ///<summary> A unique token that will be used to ensure that multiple API calls with the same information do not result in multiple transactions. This should be a unique string value per API call and can be a randomly generated. </summary> 
        public string IdempotencyKey { get; }

        ///<summary> Provide an absolute or relative URL to receive status updates regarding your Pay session. Read more about the [Update](https://www.twilio.com/docs/voice/api/payment-resource#statuscallback-update) and [Complete/Cancel](https://www.twilio.com/docs/voice/api/payment-resource#statuscallback-cancelcomplete) POST requests. </summary> 
        public Uri StatusCallback { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will update the resource. </summary> 
        public string PathAccountSid { get; set; }

        
        public PaymentResource.CaptureEnum Capture { get; set; }

        
        public PaymentResource.StatusEnum Status { get; set; }



        /// <summary> Construct a new UpdatePaymentsOptions </summary>
        /// <param name="pathCallSid"> The SID of the call that will update the resource. This should be the same call sid that was used to create payments resource. </param>
        /// <param name="pathSid"> The SID of Payments session that needs to be updated. </param>
        /// <param name="idempotencyKey"> A unique token that will be used to ensure that multiple API calls with the same information do not result in multiple transactions. This should be a unique string value per API call and can be a randomly generated. </param>
        /// <param name="statusCallback"> Provide an absolute or relative URL to receive status updates regarding your Pay session. Read more about the [Update](https://www.twilio.com/docs/voice/api/payment-resource#statuscallback-update) and [Complete/Cancel](https://www.twilio.com/docs/voice/api/payment-resource#statuscallback-cancelcomplete) POST requests. </param>
        public UpdatePaymentOptions(string pathCallSid, string pathSid, string idempotencyKey, Uri statusCallback)
        {
            PathCallSid = pathCallSid;
            PathSid = pathSid;
            IdempotencyKey = idempotencyKey;
            StatusCallback = statusCallback;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (IdempotencyKey != null)
            {
                p.Add(new KeyValuePair<string, string>("IdempotencyKey", IdempotencyKey));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (Capture != null)
            {
                p.Add(new KeyValuePair<string, string>("Capture", Capture.ToString()));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }

        

    }


}

