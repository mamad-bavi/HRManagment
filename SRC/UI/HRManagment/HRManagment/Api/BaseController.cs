using HRManagment.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagment.Api
{
    [ApiController]
    [ApiResultFilter]
    //[AllowAnonymous] // موقت
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class BaseController : ControllerBase
    {

    }
}
