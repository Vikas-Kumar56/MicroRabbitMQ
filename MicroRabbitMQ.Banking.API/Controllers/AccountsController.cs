using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Application.Services;
using MicroRabbitMQ.Banking.Data.Context;
using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbitMQ.Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private IAccountService accountService;
        public BankController(IAccountService accountService)
        {
            this.accountService = accountService;
        }
        // GET api/account
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(accountService.GetAccounts());
        }

       
    }
}
