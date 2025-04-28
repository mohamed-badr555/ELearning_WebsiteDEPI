using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Comment
{
    public interface ICommentRepo
    {
        Task<IEnumerable<ICommentRepo>> GetCommentsByVideoIdAsync(int videoId);
        Task AddCommentAsync(ICommentRepo comment);
        Task<IEnumerable<ICommentRepo>> GetAllCommentsAsync();
        Task<Comment> GetCommentByIdAsync(int id);
        Task AddCommentAsync(Comment comment);
        Task UpdateCommentAsync(Comment comment);
        Task DeleteCommentAsync(Comment comment);
    }
}
