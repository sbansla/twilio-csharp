/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Messaging.V1.Service;

namespace Twilio.Tests.Rest.Messaging.V1.Service
{

    [TestFixture]
    public class UsAppToPersonUsecaseTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/Services/MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Compliance/Usa2p/Usecases",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                UsAppToPersonUsecaseResource.Fetch("MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchWithBrandRegistrationSidResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"us_app_to_person_usecases\": [{\"code\": \"MARKETING\",\"name\": \"Marketing\",\"description\": \"Send marketing messages about sales and offers to opted in customers.\"},{\"code\": \"DELIVERY_NOTIFICATION\",\"name\": \"Delivery Notification\",\"description\": \"Information about the status of the delivery of a product or service.\"}]}"
                                     ));

            var response = UsAppToPersonUsecaseResource.Fetch("MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchWithoutBrandRegistrationSidResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"us_app_to_person_usecases\": [{\"code\": \"MARKETING\",\"name\": \"Marketing\",\"description\": \"Send marketing messages about sales and offers to opted in customers.\"},{\"code\": \"DELIVERY_NOTIFICATION\",\"name\": \"Delivery Notification\",\"description\": \"Information about the status of the delivery of a product or service.\"}]}"
                                     ));

            var response = UsAppToPersonUsecaseResource.Fetch("MGXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}