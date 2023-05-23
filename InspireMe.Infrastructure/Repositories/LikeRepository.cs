using InspireMe.Core.Entities;
using InspireMe.Core.Interfaces;
using InspireMe.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireMe.Infrastructure.Repositories
{

    public class LikeRepository : ILikeRepository
    {
        private readonly ImageBoardDbContext _dbContext;

        public LikeRepository(ImageBoardDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Like> GetByIdAsync(int id)
        {
            return await _dbContext.Likes.FindAsync(id);
        }

        public async Task AddAsync(Like like)
        {
            await _dbContext.Likes.AddAsync(like);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Like like)
        {
            _dbContext.Likes.Update(like);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Like like)
        {
            _dbContext.Likes.Remove(like);
            await _dbContext.SaveChangesAsync();
        }
    }
}
