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
        public void AddNewMessage([FromBody] Message message)
        {
            try
            {
                _messageLogic.AddNewMessage(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }

        [HttpDelete("{id}")]
        public void DeleteMessage(string id)
        {
            try
            {
                _messageLogic.DeleteMessage(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }

        [HttpGet]
        public IEnumerable<Message> GetAll()
        {
            return _messageLogic.GetAll();
        }

        [HttpGet("{id}")]
        public Message GetById(string id)
        {
            try
            {
                return _messageLogic.GetById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
                throw;
            }
        }

        [HttpPut]
        public void UpdateMessage([FromBody] Message message)
        {
            try
            {
                _messageLogic.UpdateMessage(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now.ToShortTimeString() + "Error: " + e.Message);
            }
        }
    }
}
