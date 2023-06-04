using System.Text.Json.Serialization;

namespace SquadML.Application.Models
{
    public class AIMemberActivityPred
    {
        [JsonPropertyName("PredictedLabel")]
        public int MembersActivity { get; set; }

        [JsonPropertyName("Score")]
        public float Score { get; set; }
    }
}
