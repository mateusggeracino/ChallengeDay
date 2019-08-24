using FluentValidation.Results;
using Newtonsoft.Json;

namespace SC.Services.ViewModels.Response
{
    public class ClientResponseViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }
    }
}