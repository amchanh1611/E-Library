﻿using E_Library.Models;
using E_Library.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace E_Library.Repository.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly E_LibraryDbContext _context;
        public QuestionRepository(E_LibraryDbContext context)
        {
            _context = context;
        }


        public IQueryable<Questions> GetAllQuestion()
        {
            return _context.Questions;
        }

        public Questions GetQuestionById(int id)
        {
            return  _context.Questions.Where(w=>w.QuestionId==id).FirstOrDefault();
        }

    }
}