using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2.Controllers
{
    public class J3Controller : ApiController
    {
        /// PSEUDOCODE STARTS
        /// N= number of drops, 2<=N<=100
        /// N sets of positive numbers, X>0 & <100, Y>0 & <100
        /// 1		X1, Y1
        /// 2		X2, Y2
        ///     .
        ///     .
        /// N       Xn, Yn
        /// OUTPUT
        /// (the min value of X-1, the min value of Y-1), (the max x+1, the max y+1)
        [Route("api/J3/PaintFrame/{array}")]///how do I get indefinite number of inputs?
        [HttpGet]
        public IEnumerable<string> PaintFrame(int m, int n)///how do I definite an uncertain number of input of value?
        ///[HttpGet("{container}/{*prefixPath}")]
        ///public async Task<ActionResult<string>> Get(string container, string prefixPath)
        ///{
        ///string[] prefixes = prefixPath?.Split('/');
        ///...
        ///}


    }
}
