using DAL.Repositories.Comment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
    
        
            private readonly Comment _commentService;

            public CommentsController(Comment commentService)
            {
                _commentService = commentService;
            }

            [HttpPost]
            public async Task<ActionResult> CreateComment([FromBody] Comment comment)
            {
                await _commentService.AddCommentAsync(comment);
                return Ok(comment);
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Comment>> GetComment(int id)
            {
                var comment = await _commentService.GetCommentByIdAsync(id);
                if (comment == null)
                    return NotFound();

                return Ok(comment);
            }

            [HttpGet("Video/{videoId}")]
            public async Task<ActionResult<IEnumerable<Comment>>> GetCommentsByVideoId(int videoId)
            {
                var comments = await _commentService.GetCommentsByVideoIdAsync(videoId);
                return Ok(comments);
            }
        }
}
