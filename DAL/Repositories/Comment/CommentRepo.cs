using DAL.DB_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Comment
{
    public class Comment 
    {
        private readonly ICommentRepo _commentRepository;

        public Comment(ICommentRepo commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<IEnumerable<ICommentRepo>> GetAllCommentsAsync()
        {
            return await _commentRepository.GetAllCommentsAsync();
        }

        public async Task<Comment> GetCommentByIdAsync(int id)
        {
            return await _commentRepository.GetCommentByIdAsync(id);
        }

        public async Task<IEnumerable<Comment>> GetCommentsByVideoIdAsync(int videoId)
        {
            return (IEnumerable<Comment>)await _commentRepository.GetCommentsByVideoIdAsync(videoId);
        }

        public async Task AddCommentAsync(Comment comment)
        {
            await _commentRepository.AddCommentAsync(comment);
        }

        public async Task UpdateCommentAsync(Comment comment)
        {
            await _commentRepository.UpdateCommentAsync(comment);
        }

        public async Task DeleteCommentAsync(Comment comment)
        {
            await _commentRepository.DeleteCommentAsync(comment);
        }
    }
}
