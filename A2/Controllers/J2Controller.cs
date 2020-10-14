using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Processing the number of ways two dice can roll the value of 10.
        /// </summary>
        /// <param name="m">total sides of 1st die</param>
        /// <param name="n">total sides of 2nd die</param>
        /// <returns>A string explaining how many ways</returns>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public IEnumerable<string> DiceGame(int m, int n)
        {
            int count = 0;
            int i = 0;
            int j = 0;
            for (i = 0; i <= m; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    if (i + j == 10) count = count + 1;
                };
            };
            return new string[] { "There are a total of " + count + " ways to get the sum of 10." };
        }
    }
}
