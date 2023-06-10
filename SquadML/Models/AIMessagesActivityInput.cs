﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Squad.ML.Application.Models
{
    public class AIMessagesActivityInput
    {
        [JsonPropertyName("Label")]
        public int MessagesActivity { get; set; }

        [JsonPropertyName("totalMembers")]
        public int TotalMembers { get; set; }

        [JsonPropertyName("membersActivity")]
        public int MembersActivity { get; set; }

        [JsonPropertyName("newMembers")]
        public int NewMembers { get; set; }

        [JsonPropertyName("voiceActivity")]
        public int VoiceActivity { get; set; }

    }
}
