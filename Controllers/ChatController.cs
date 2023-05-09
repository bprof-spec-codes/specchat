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
        public void AddNewChat([FromBody] Chat chat)
        {
            try
            {
                _chatLogic.AddNewChat(chat);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }

        [HttpDelete("{id}")]
        public void DeleteChat(string id)
        {
            try
            {
                _chatLogic.DeleteChat(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }

        [HttpGet]
        public IEnumerable<Chat> GetAll()
        {
            return _chatLogic.GetAll();
        }

        [HttpGet("{id}")]
        public Chat GetById(string id)
        {
            try
            {
                return _chatLogic.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
                throw;
            }
        }

        [HttpPut]
        public void UpdateChat([FromBody] Chat chat)
        {
            try
            {
                _chatLogic.UpdateChat(chat);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }
    }
}
