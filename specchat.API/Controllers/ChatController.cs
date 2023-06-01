using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using specchat.API.Data.Logics;
using specchat.API.Data.Logics.Logic_Interfaces;
using specchat.API.Models;
using specchat.API.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace specchat.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
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
        [HttpGet("UploadFile/{id}")]
        public LinkEnding UploadFile(string id)
        {
            var chat = _chatLogic.GetById(id);
            var messages = chat.Messages;
            var mainMessages = messages.Where(x => x.MainMessage == null).OrderBy(x => x.Time);
            string json = "[";
            foreach (var message in mainMessages)
            {
                json += "{";
                json += "\"Time\":";
                json += "\"" + message.Time + "\",";
                json += "\"User\":";
                json += "\"" + message.User.UserName + "\",";
                json += "\"Content\":";
                json += "\"" + message.Content + "\",";
                json += "\"IsPinned\":";
                json += "\"" + message.IsPinned + "\",";
                json += "\"SubThread\":[";
                foreach (var submessage in messages.Where(x => x.MainMessageId == message.Id).OrderBy(x => x.Time))
                {
                    json += "{";
                    json += "\"Time\":";
                    json += "\"" + submessage.Time + "\",";
                    json += "\"User\":";
                    json += "\"" + submessage.User.UserName + "\",";
                    json += "\"Content\":";
                    json += "\"" + submessage.Content + "\",";
                    json += "\"IsPinned\":";
                    json += "\"" + submessage.IsPinned + "\",";
                    json += "},";
                }
                json += "]},";
            }
            json += "]";
            json = json.Replace(",]", "]").Replace(",}", "}");
            var fileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + chat.Name + ".json";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\savedChats", fileName);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(json);
            }
            return new LinkEnding() { Link = fileName.ToString()};
        }
    }
}
