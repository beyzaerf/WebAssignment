using InspireMe.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireMe.Core.Interfaces
{
    public interface ILikeRepository
    {
        Task<Like> GetByIdAsync(int id);
        Task AddAsync(Like like);
        Task UpdateAsync(Like like);
        Task DeleteAsync(Like like);
    }
}
