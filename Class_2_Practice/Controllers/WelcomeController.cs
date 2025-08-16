using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class_2_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        /// <summary>
        /// GET :localhost:xxxx/api/Welcome/Message => Welcome to the API!
        /// </summary>
        /// <returns>
        /// String massge => Welcome to the API!
        /// </returns>
        [HttpGet(template: "Message")]
        public string Message()
        {
            return "Welcome to the API!";
        }


        /// <summary>
        /// Get: localhost:xxxx/api/Welcome/GetInteger
        /// </summary>
        /// <returns>
        /// gives you int number.
        /// </returns>
        [HttpGet(template: "GetInteger")]
        public int GetInteger()
        {
            int firstNum = 5;
            int SecondNum = 10;
            return firstNum + SecondNum;
        }


        /// <summary>
        /// Get: localhost:xxxx/api/Welcome/GetString
        /// </summary>
        /// <returns>
        /// gives you two string messages as a one combine one message.
        /// </returns>
        [HttpGet(template: "GetString")]
        public string GetString()
        {
            string message1 = "Hello!";
            string message2 = "I am Ripal!";
            return message1 + " " + message2;
        }



        /// <summary>
        /// Get: localhost:xxxx/api/Welcome/DecimalValue
        /// </summary>
        /// <returns>
        /// Give you total of firstDecimal & secondDecimal
        /// </returns>
        [HttpGet(template: "DecimalValue")]
        public decimal DecimalValue()
        {
            decimal firstDecimal = 10.6M;
            decimal secondDecimal = 3.2M;
            return firstDecimal + secondDecimal;
        }


        /// <summary>
        /// add two float value together return a signle float value.
        /// </summary>
        /// <returns>
        /// one float value
        /// </returns>
        /// <example>
        /// Get: localhost:xxxx/api/Welcome/Getfloat => 0.0473F + 0.456F => 0.5033
        /// </example>
        [HttpGet(template: "Getfloat")]
        public float Getfloat()
        {
            float firstFloat = 0.0473F;
            float secondFloat = 0.456F;
            return firstFloat + secondFloat;
        }

        /// <summary>
        /// Adding using Post request float value.
        /// </summary>
        /// <returns>
        /// sum of float value
        /// </returns>
        /// <example>
        /// Post: localhost:xxxx/api/Welcome/Getfloat => -0.34F + 0.45F => 0.109999985
        /// </example>
        [HttpPost(template: "addvalue")]
        public float addvalue()
        {
            float fvalue = -0.34F;
            float sValue = 0.45F;
            return fvalue + sValue;
        }

        /// <summary>
        /// Gets current date & Time.
        /// </summary>
        /// <returns>
        /// gives you current date & Time.
        /// </returns>
        /// <example>
        /// Get: localhost:xxxx/api/Welcome/GetDateTime
        /// </example>
        [HttpGet(template: "GetDateTime")]
        public DateTime GetDateTime()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate;
        }
    }
}
