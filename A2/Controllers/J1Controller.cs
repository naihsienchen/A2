using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2.Controllers
{
    public class J1Controller : ApiController
    {

        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public IEnumerable<string> Menu(int burger, int drink, int side, int dessert)
        {
            int burgercal = 0;
            int drinkcal = 0;
            int sidecal = 0;
            int descal = 0;

            switch (burger)
            {
                case 1:
                    burgercal = 461;
                    break;
                case 2:
                    burgercal = 431;
                    break;
                case 3:
                    burgercal = 420;
                    break;
                default:
                case 4:
                    burgercal = 0;
                    break;
            };

            switch (drink)
            {
                case 1:
                    drinkcal = 130;
                    break;
                case 2:
                    drinkcal = 160;
                    break;
                case 3:
                    drinkcal = 118;
                    break;
                default:
                case 4:
                    drinkcal = 0;
                    break;
            };

            switch (side)
            {
                case 1:
                    sidecal = 100;
                    break;
                case 2:
                    sidecal = 57;
                    break;
                case 3:
                    sidecal = 70;
                    break;
                default:
                case 4:
                    sidecal = 0;
                    break;
            };

            switch (dessert)
            {
                case 1:
                    descal = 167;
                    break;
                case 2:
                    descal = 266;
                    break;
                case 3:
                    descal = 75;
                    break;
                default:
                case 4:
                    descal = 0;
                    break;
            };
            int totalcal = burgercal + drinkcal + sidecal + descal;
            return new string[] { "Your total calorie count is " + totalcal };
        }
    }
}
