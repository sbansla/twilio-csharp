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
using Twilio.Rest.Voice.V1;

namespace Twilio.Tests.Rest.Voice.V1
{

    [TestFixture]
    public class ByocTrunkTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Voice,
                "/v1/ByocTrunks",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ByocTrunkResource.Create(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"friendly_name\",\"voice_url\": \"https://byoc.example.com/twilio/app\",\"voice_method\": \"POST\",\"voice_fallback_method\": \"POST\",\"voice_fallback_url\": \"https://byoc.example.com/twilio/fallback\",\"status_callback_method\": \"POST\",\"status_callback_url\": \"https://byoc.example.com/twilio/status_callback\",\"cnam_lookup_enabled\": false,\"connection_policy_sid\": \"NYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"from_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:36Z\",\"url\": \"https://voice.twilio.com/v1/ByocTrunks/BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ByocTrunkResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Voice,
                "/v1/ByocTrunks/BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ByocTrunkResource.Fetch("BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"friendly_name\",\"voice_url\": \"https://byoc.example.com/twilio/app\",\"voice_method\": \"POST\",\"voice_fallback_method\": \"POST\",\"voice_fallback_url\": \"https://byoc.example.com/twilio/fallback\",\"status_callback_method\": \"POST\",\"status_callback_url\": \"https://byoc.example.com/twilio/status_callback\",\"cnam_lookup_enabled\": false,\"connection_policy_sid\": \"NYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"from_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:37Z\",\"url\": \"https://voice.twilio.com/v1/ByocTrunks/BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ByocTrunkResource.Fetch("BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Voice,
                "/v1/ByocTrunks",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ByocTrunkResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://voice.twilio.com/v1/ByocTrunks?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://voice.twilio.com/v1/ByocTrunks?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"byoc_trunks\"},\"byoc_trunks\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"friendly_name\",\"voice_url\": \"https://byoc.example.com/twilio/app\",\"voice_method\": \"POST\",\"voice_fallback_method\": \"POST\",\"voice_fallback_url\": \"https://byoc.example.com/twilio/fallback\",\"status_callback_method\": \"POST\",\"status_callback_url\": \"https://byoc.example.com/twilio/status_callback\",\"cnam_lookup_enabled\": false,\"connection_policy_sid\": \"NYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"from_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:37Z\",\"url\": \"https://voice.twilio.com/v1/ByocTrunks/BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = ByocTrunkResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://voice.twilio.com/v1/ByocTrunks?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://voice.twilio.com/v1/ByocTrunks?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"byoc_trunks\"},\"byoc_trunks\": []}"
                                     ));

            var response = ByocTrunkResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Voice,
                "/v1/ByocTrunks/BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ByocTrunkResource.Update("BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"update_name\",\"voice_url\": \"https://byoc.example.com/twilio_updated/app\",\"voice_method\": \"GET\",\"voice_fallback_method\": \"GET\",\"voice_fallback_url\": \"https://byoc.example.com/twilio_updated/fallback\",\"status_callback_method\": \"GET\",\"status_callback_url\": \"https://byoc.example.com/twilio_updated/status_callback\",\"cnam_lookup_enabled\": true,\"connection_policy_sid\": \"NYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"from_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:37Z\",\"url\": \"https://voice.twilio.com/v1/ByocTrunks/BYaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ByocTrunkResource.Update("BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Voice,
                "/v1/ByocTrunks/BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ByocTrunkResource.Delete("BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = ByocTrunkResource.Delete("BYXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}