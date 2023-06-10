using System.Text.Json.Serialization;

namespace Squad.ML.Application.Models
{
    public class AIMessagesActivityPred
    {
        [JsonPropertyName("PredictedLabel")]
        public int MessagesActivity { get; set; }

        [JsonPropertyName("Score")]
        public float Score { get; set; }
    }
}
