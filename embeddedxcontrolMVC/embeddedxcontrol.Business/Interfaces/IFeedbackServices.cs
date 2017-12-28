using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface IFeedbackServices
    {
        FeedbackEntity GetFeedbackById(int feedbackId);
        IEnumerable<FeedbackEntity> GetAllFeedback();
        int CreateFeedback(FeedbackEntity feedbackEntity);
        bool UpdateFeedback(int feedbackId, FeedbackEntity feedbackEntity);
        bool DeleteFeedback(int feedbackId);
    }
}
