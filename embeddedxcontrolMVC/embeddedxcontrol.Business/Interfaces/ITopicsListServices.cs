using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface ITopicsListServices
    {
        TopicsListEntity GetTopicById(int userId);
        IEnumerable<TopicsListEntity> GetAllTopics();
        int CreateTopic(TopicsListEntity topicEntity);
        bool UpdateTopic(int topicId, TopicsListEntity topicEntity);
        bool DeleteTopic(int topicId);
    }
}
