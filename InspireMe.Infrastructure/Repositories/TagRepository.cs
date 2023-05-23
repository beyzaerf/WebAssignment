using InspireMe.Core.Entities;
using InspireMe.Core.Interfaces;
using InspireMe.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireMe.Infrastructure.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ImageBoardDbContext _dbContext;

        public TagRepository(ImageBoardDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Tag> GetByIdAsync(int id)
        {
            return await _dbContext.Tags.FindAsync(id);
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            return await _dbContext.Tags.ToListAsync();
        }

        public async Task AddAsync(Tag tag)
        {
            await _dbContext.Tags.AddAsync(tag);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tag tag)
        {
            _dbContext.Tags.Update(tag);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tag tag)
        {
            _dbContext.Tags.Remove(tag);
            await _dbContext.SaveChangesAsync();
        }
    }
}
