using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpPost("UploadFile")]
        public string UploadFile([FromBody] SaveChatViewModel content)
        {
            var fileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + content.ChatName + ".json";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\savedChats", fileName);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(content.Content);
            }
            return fileName.ToString();
        }
    }
}
