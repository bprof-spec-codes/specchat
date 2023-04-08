using Microsoft.AspNetCore.Mvc;
using specchat.Data.Logics;
using specchat.Data.Logics.Model_Logics;
using specchat.Models;
using System;
using System.Collections.Generic;

namespace specchat.Controllers
{
    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        private readonly IChatLogic _chatLogic;

        public ChatController(IChatLogic chatLogic)
        {
            _chatLogic = chatLogic;
        }

        [HttpPost]
        public IActionResult AddNewChat([FromBody] Chat chat)
        {
            try
            {
                _chatLogic.AddNewChat(chat);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteChat(string id)
        {
            try
            {
                _chatLogic.DeleteChat(id);
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
            var chats = _chatLogic.GetAll();
            return Ok(chats);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var chat = _chatLogic.GetById(id);
            if (chat == null)
            {
                return NotFound();
            }
            return Ok(chat);
        }

        [HttpPut]
        public IActionResult UpdateChat([FromBody] Chat chat)
        {
            try
            {
                _chatLogic.UpdateChat(chat);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
