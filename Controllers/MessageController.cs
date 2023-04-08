using Microsoft.AspNetCore.Mvc;
using specchat.Data.Logics.Logic_Interfaces;
using specchat.Data.Repositories.Interfaces;
using specchat.Models;
using System;
using System.Collections.Generic;

namespace specchat.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private readonly IMessageLogic _messageLogic;

        public MessageController(IMessageLogic messageLogic)
        {
            _messageLogic = messageLogic;
        }

        [HttpPost]
        public IActionResult AddNewMessage([FromBody] Message message)
        {
            try
            {
                _messageLogic.AddNewMessage(message);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(string id)
        {
            try
            {
                _messageLogic.DeleteMessage(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var messages = _messageLogic.GetAll();
            return Ok(messages);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var message = _messageLogic.GetById(id);
            if (message == null)
            {
                return NotFound();
            }
            return Ok(message);
        }

        [HttpPut]
        public IActionResult UpdateMessage([FromBody] Message message)
        {
            try
            {
                _messageLogic.UpdateMessage(message);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
