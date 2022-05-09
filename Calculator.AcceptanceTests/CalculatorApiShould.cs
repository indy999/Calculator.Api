using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net;

namespace Calculator.AcceptanceTests
{
    [TestFixture]
    public class CalculatorApiShould
    {
        private WebApplicationFactory<Program>? _factory;
        private HttpClient? _client;
        private readonly string apiKey = "OnSzhN8q8ebQZys";

        [OneTimeSetUp]
        public void Setup()
        {
            _factory = new WebApplicationFactory<Program>();
            _client = _factory.CreateClient();
        }

        [Test]
        public async Task AddValuesSuccessfully()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/math/add?value1=1&value2=1");
            request.Headers.Add("Authorization", apiKey);
            var response =  _client.SendAsync(request).Result;

            var calcResult = await response.Content.ReadAsStringAsync();

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            calcResult.Should().Be("2");
        }

        [Test]
        public async Task SubtractValuesSuccessfully()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/math/subtract?value1=10&value2=2");
            request.Headers.Add("Authorization", apiKey);
            var response = _client.SendAsync(request).Result;

            var calcResult = await response.Content.ReadAsStringAsync();

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            calcResult.Should().Be("8");
        }

        
        [Test]
        public async Task MultiplyValuesSuccessfully()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/math/multiply?value1=10&value2=2");
            request.Headers.Add("Authorization", apiKey);
            var response = _client.SendAsync(request).Result;

            var calcResult = await response.Content.ReadAsStringAsync();

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            calcResult.Should().Be("20");
        }

        [Test]
        public async Task DivideValuesSuccessfully()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/math/divide?value1=10&value2=2");
            request.Headers.Add("Authorization", apiKey);
            var response = _client.SendAsync(request).Result;

            var calcResult = await response.Content.ReadAsStringAsync();

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            calcResult.Should().Be("5");
        }

        [Test]
        public async Task ReturnUnauthorizedIfIncorrectApiKeyPassed()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/math/add?value1=1&value2=1");
            request.Headers.Add("Authorization", "1234");
            var response = _client.SendAsync(request).Result;

            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Test]
        public async Task ReturnUnauthorizedIfNoApiKeyPassed()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/math/add?value1=1&value2=1");
            var response = _client.SendAsync(request).Result;

            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _client.Dispose();
            _factory.Dispose();
        }
    }
}
