﻿using specchat.Models;

namespace specchat.Data.Repositories
{
    public interface IEmojiRepository
    {
        void Create(Emoji emoji);
        void Delete(string id);
        IEnumerable<Emoji> Read();
        Emoji Read(string id);
        void Update(Emoji emoji);
    }
}