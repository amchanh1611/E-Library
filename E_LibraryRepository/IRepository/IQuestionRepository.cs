﻿using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IQuestionRepository
    {
        public Questions GetQuestionById(int id);
    }
}