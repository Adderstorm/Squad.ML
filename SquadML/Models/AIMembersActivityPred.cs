using System.Text.Json.Serialization;

namespace Squad.ML.Application.Models
{
    public class AIMembersActivityPred
    {
        [JsonPropertyName("PredictedLabel")]
        public int MembersActivity { get; set; }

        [JsonPropertyName("Score")]
        public float Score { get; set; }
    }
}
