using System.Text.Json.Serialization;

namespace SquadML.Application.Models
{
    public class AIVoiceActivityInput
    {
        [JsonPropertyName("Label")]
        public int VoiceActivity { get; set; }

        [JsonPropertyName("totalMembers")]
        public int TotalMembers { get; set; }

        [JsonPropertyName("membersActivity")]
        public int MembersActivity { get; set; }

        [JsonPropertyName("newMembers")]
        public int NewMembers { get; set; }

        [JsonPropertyName("messagesActivity")]
        public int MessagesActivity { get; set; }
    }
}
