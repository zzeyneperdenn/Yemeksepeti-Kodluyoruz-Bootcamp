using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5.Core.Models;

namespace HW5.Services.Services
{
    public interface ITopicService
    {
        Task<IEnumerable<Topic>> GetAllTopics();
        Task<Topic> GetTopicById(int id);
        Task<Topic> CreateTopic(Topic newTopic);
        Task UpdateTopic(Topic topicToBeUpdated, Topic topic);
        Task DeleteTopic(Topic topic);
    }
}
