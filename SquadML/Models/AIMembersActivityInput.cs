using System.Text.Json.Serialization;

namespace SquadML.Application.Models
{
    public class AIMembersActivityInput
    {
        [JsonPropertyName("Label")]
        public int MembersActivity { get; set; }

        [JsonPropertyName("totalMembers")]
        public int TotalMembers { get; set; }

        [JsonPropertyName("newMembers")]
        public int NewMembers { get; set; }

        [JsonPropertyName("voiceActivity")]
        public int VoiceActivity { get; set; }

        [JsonPropertyName("messagesActivity")]
        public int MessagesActivity { get; set; }
    }
}
