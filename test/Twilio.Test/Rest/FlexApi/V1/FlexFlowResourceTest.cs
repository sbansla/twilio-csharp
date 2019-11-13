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
using Twilio.Rest.FlexApi.V1;

namespace Twilio.Tests.Rest.FlexApi.V1
{

    [TestFixture]
    public class FlexFlowTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.FlexApi,
                "/v1/FlexFlows",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FlexFlowResource.Read(client: twilioRestClient);
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
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://flex-api.twilio.com/v1/FlexFlows?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://flex-api.twilio.com/v1/FlexFlows?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"flex_flows\"},\"flex_flows\": [{\"sid\": \"FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"friendly_name\": \"friendly_name\",\"chat_service_sid\": \"SIaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"channel_type\": \"sms\",\"contact_identity\": \"12345\",\"enabled\": true,\"integration_type\": \"studio\",\"integration\": {\"flow_sid\": \"FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"retry_count\": 1},\"long_lived\": true,\"janitor_enabled\": true,\"url\": \"https://flex-api.twilio.com/v1/FlexFlows/FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = FlexFlowResource.Read(client: twilioRestClient);
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
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://flex-api.twilio.com/v1/FlexFlows?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://flex-api.twilio.com/v1/FlexFlows?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"flex_flows\"},\"flex_flows\": []}"
                                     ));

            var response = FlexFlowResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.FlexApi,
                "/v1/FlexFlows/FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FlexFlowResource.Fetch("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"sid\": \"FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"friendly_name\": \"friendly_name\",\"chat_service_sid\": \"SIaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"channel_type\": \"sms\",\"contact_identity\": \"12345\",\"enabled\": true,\"integration_type\": \"studio\",\"integration\": {\"flow_sid\": \"FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"retry_count\": 1},\"long_lived\": true,\"janitor_enabled\": true,\"url\": \"https://flex-api.twilio.com/v1/FlexFlows/FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FlexFlowResource.Fetch("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.FlexApi,
                "/v1/FlexFlows",
                ""
            );
            request.AddPostParam("FriendlyName", Serialize("friendly_name"));
            request.AddPostParam("ChatServiceSid", Serialize("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            request.AddPostParam("ChannelType", Serialize(FlexFlowResource.ChannelTypeEnum.Web));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FlexFlowResource.Create("friendly_name", "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", FlexFlowResource.ChannelTypeEnum.Web, client: twilioRestClient);
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
                                         "{\"sid\": \"FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"friendly_name\": \"friendly_name\",\"chat_service_sid\": \"SIaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"channel_type\": \"sms\",\"contact_identity\": \"12345\",\"enabled\": true,\"integration_type\": \"studio\",\"integration\": {\"flow_sid\": \"FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"retry_count\": 1},\"long_lived\": true,\"janitor_enabled\": true,\"url\": \"https://flex-api.twilio.com/v1/FlexFlows/FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FlexFlowResource.Create("friendly_name", "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", FlexFlowResource.ChannelTypeEnum.Web, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.FlexApi,
                "/v1/FlexFlows/FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FlexFlowResource.Update("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"sid\": \"FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-08-01T22:10:40Z\",\"date_updated\": \"2016-08-01T22:10:40Z\",\"friendly_name\": \"friendly_name\",\"chat_service_sid\": \"SIaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"channel_type\": \"sms\",\"contact_identity\": \"12345\",\"enabled\": true,\"integration_type\": \"studio\",\"integration\": {\"flow_sid\": \"FWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"retry_count\": 1},\"long_lived\": true,\"janitor_enabled\": true,\"url\": \"https://flex-api.twilio.com/v1/FlexFlows/FOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FlexFlowResource.Update("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.FlexApi,
                "/v1/FlexFlows/FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FlexFlowResource.Delete("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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

            var response = FlexFlowResource.Delete("FOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}