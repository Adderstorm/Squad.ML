using System.Text.Json.Serialization;

namespace Squad.ML.Application.Models
{
    public class AIMembersPred
    {
        [JsonPropertyName("PredictedLabel")]
        public int TotalMembers { get; set; }

        [JsonPropertyName("Score")]
        public float Score { get; set; }
    }
}
