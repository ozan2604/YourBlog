using Application.Features.Meadiatr.Commands.BlogCommands.CreateBlog;
using Application.Features.Meadiatr.Commands.BlogCommands.RemoveBlog;
using Application.Features.Meadiatr.Commands.BlogCommands.UpdateBlog;
using Application.Features.Meadiatr.Queries.BlogQueries.GetAllBlog;
using Application.Features.Meadiatr.Queries.BlogQueries.GetByIdBlog;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogs([FromQuery] GetAllBlogQueryRequest blogrequest)
        {
            GetAllBlogQueryResponse response = await _mediator.Send(blogrequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBlogById([FromRoute] GetByIdBlogQueryRequest blogrequest)
        {
            GetByIdBlogQueryResponse response = await _mediator.Send(blogrequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommandRequest Blogrequest)
        {
            CreateBlogCommandResponse response = await _mediator.Send(Blogrequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteBlog([FromRoute] RemoveBlogCommandRequest blogrequest)
        {
            RemoveBlogCommandResponse response = await _mediator.Send(blogrequest);
            return Ok("Blog Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog([FromBody] UpdateBlogCommandRequest blogrequest)
        {
            UpdateBlogCommandResponse response = await _mediator.Send(blogrequest);
            return Ok("Blog Başarıyla Güncellendi");
        }

    }
}
