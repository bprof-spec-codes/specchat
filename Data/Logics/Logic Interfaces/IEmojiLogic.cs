﻿using Microsoft.AspNetCore.Mvc;
using specchat.Models;

namespace specchat.Data.Logics.Model_Logics
{
    public interface IEmojiLogic
    {
        void AddNewEmoji([FromBody] Emoji emoji);
        void DeleteEmoji(string id);
        IEnumerable<Emoji> GetAll();
        Emoji GetById(string id);
        void UpdateEmoji([FromBody] Emoji emoji);
    }
}