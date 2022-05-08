using Calculator.Api.Attributes;
using Calculator.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ApiKey]
    public class MathController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public MathController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet]
        [Route("/api/math/add")]
        public async Task<IActionResult> Add(int value1, int value2)
        {
            var response = await _calculatorService.Add(value1, value2);
            return Ok(response);             
        }

        [HttpGet]
        [Route("/api/math/subtract")]
        public async Task<IActionResult> Subtract(int value1, int value2)
        {
            var response = await _calculatorService.Subtract(value1, value2);
            return Ok(response);
        }

        [HttpGet]
        [Route("/api/math/multiply")]
        public async Task<IActionResult> Multiply(int value1, int value2)
        {
            var response = await _calculatorService.Multiply(value1, value2);
            return Ok(response);
        }

        [HttpGet]
        [Route("/api/math/divide")]
        public async Task<IActionResult> Divide(int value1, int value2)
        {
            var response = await _calculatorService.Divide(value1, value2);
            return Ok(response);
        }
    }
}
