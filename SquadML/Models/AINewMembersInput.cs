using System.Text.Json.Serialization;

namespace SquadML.Application.Models
{
    public class AINewMembersInput
    {
        [JsonPropertyName("Label")]
        public int NewMembers { get; set; }

        [JsonPropertyName("totalMembers")]
        public int TotalMembers { get; set; }

        [JsonPropertyName("membersActivity")]
        public int MembersActivity { get; set; }

        [JsonPropertyName("voiceActivity")]
        public int VoiceActivity { get; set; }

        [JsonPropertyName("messagesActivity")]
        public int MessagesActivity { get; set; }
    }
}
