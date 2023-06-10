using System.Text.Json.Serialization;

namespace Squad.ML.Application.Models
{
    public class AIMembersInput
    {
        [JsonPropertyName("Label")]
        public int TotalMembers { get; set; }

        [JsonPropertyName("membersActivity")]
        public int MembersActivity { get; set; }

        [JsonPropertyName("newMembers")]
        public int NewMembers { get; set; }

        [JsonPropertyName("voiceActivity")]
        public int VoiceActivity { get; set; }

        [JsonPropertyName("messagesActivity")]
        public int MessagesActivity { get; set; }
    }
}
