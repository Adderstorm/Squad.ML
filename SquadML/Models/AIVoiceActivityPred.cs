using System.Text.Json.Serialization;

namespace Squad.ML.Application.Models
{
    public class AIVoiceActivityPred
    {
        [JsonPropertyName("PredictedLabel")]
        public int VoiceActivity { get; set; }

        [JsonPropertyName("Score")]
        public float Score { get; set; }
    }
}
