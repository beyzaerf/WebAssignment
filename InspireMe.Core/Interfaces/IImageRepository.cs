using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspireMe.Core.Entities;

namespace InspireMe.Core.Interfaces
{
    public interface IImageRepository
    {
        Task<Image> GetByIdAsync(int id);
        Task<IEnumerable<Image>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Image>> GetAllAsync();
        Task AddAsync(Image image);
        Task UpdateAsync(Image image);
        Task DeleteAsync(Image image);
    }
}
