using System.Collections.Generic;
using SC.Services.ViewModels.Response;

namespace SC.Services.Interfaces
{
    public interface IQuestionServices
    {
        IEnumerable<QuestionResponseViewModel> GetAll();
    }
}