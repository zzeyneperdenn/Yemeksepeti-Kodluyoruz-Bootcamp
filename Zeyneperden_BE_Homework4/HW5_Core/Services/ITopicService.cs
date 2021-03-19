using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5_Core.Models;

namespace HW5_Core.Services
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
