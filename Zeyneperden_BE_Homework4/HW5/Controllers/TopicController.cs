using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW5_Core.Models;
using HW5_Core.Repositories;
using HW5_Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HW5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ILogger<TopicController> _logger;
        private readonly ITopicService _topicService;
        private readonly IRepositoryBase<Topic> _repository;

        public TopicController(ILogger<TopicController> logger, ITopicService topicService)
        {
            _logger = logger;
            _topicService = topicService;
        }


        [HttpGet]
        [ProducesResponseType(typeof(Topic), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var topics = await _topicService.GetAllTopics();
            return Ok(topics);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Topic), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Topic), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var topic = await _topicService.GetTopicById(id);
            if (topic == null)
            {
                return NotFound();
            }
            return Ok(topic);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Topic topic)
        {
            await _repository.AddAsync(topic);
            return Created(string.Empty, topic);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Topic topic)
        {
            _repository.Update(topic);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var topic = await _repository.GetByIdAsync(id);
            _repository.Remove(topic);
            return NoContent();
        }

    }
}
