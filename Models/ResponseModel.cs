using System.Text.Json.Serialization;

namespace CQRS.Models
{
    public class ResponseModel<T>
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}
