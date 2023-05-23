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
    public class ImageRepository : IImageRepository
    {
        private readonly ImageBoardDbContext _dbContext;

        public ImageRepository(ImageBoardDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Image> GetByIdAsync(int id)
        {
            return await _dbContext.Images.FindAsync(id);
        }

        public async Task<IEnumerable<Image>> GetByUserIdAsync(int userId)
        {
            return await _dbContext.Images.Where(i => i.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Image>> GetAllAsync()
        {
            return await _dbContext.Images.ToListAsync();
        }

        public async Task AddAsync(Image image)
        {
            await _dbContext.Images.AddAsync(image);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Image image)
        {
            _dbContext.Images.Update(image);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Image image)
        {
            _dbContext.Images.Remove(image);
            await _dbContext.SaveChangesAsync();
        }

        Task<Image> IImageRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Image>> IImageRepository.GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Image>> IImageRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

    }
}
