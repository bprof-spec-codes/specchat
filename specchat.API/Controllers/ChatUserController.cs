﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using specchat.API.Data.Logics;
using specchat.API.Data.Logics.Logic_Interfaces;
using specchat.API.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace specchat.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatUserController : ControllerBase
    {
        private readonly IChatLogic _chatLogic;

        public ChatUserController(IChatLogic chatLogic)
        {
            _chatLogic = chatLogic;
        }

        [HttpGet("Chat/{userid}")]
        public IEnumerable<Chat> GetByUser(string userid)
        {
            try
            {
                var chats = _chatLogic.GetByUserId(userid);
                return chats;
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
                throw;
            }
        }

        [HttpPost("{id}/addUser/{userid}")]
        public IActionResult AddUserToChat(string id, string userid)
        {
            var isit = _chatLogic.IsUserInChat(id, userid);

            if (!isit)
            {
                _chatLogic.AddUserToChat(id, userid);
                return Ok();
            }
            else
            {
                return BadRequest("User is already in chat");
            }
            
            
        }

        [HttpDelete]
        public IActionResult DeleteUserFromChat(string chatid, string userid)
        {
            var isit = _chatLogic.IsUserInChat(chatid, userid);

            if (isit)
            {
                _chatLogic.RemoveUserFromChat(chatid, userid);
                return Ok();
            }
            else
            {
                return BadRequest("User is not in chat");
            }

        }

        [HttpGet("User/{chatid}")]
        public IEnumerable<ApplicationUser> GetByChat(string chatid)
        {
            return _chatLogic.GetByChatId(chatid);
        }
    }
}

