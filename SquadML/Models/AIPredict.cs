using System.ComponentModel.DataAnnotations.Schema;

namespace SquadML.Application.Models
{
    [Table("AIPredict")]
    public class AIPredict
    {

        [Column("totalMembers")]
        public int TotalMembers { get; set; }

        [Column("membersActivity")]
        public int MembersActivity { get; set; }

        [Column("newMembers")]
        public int NewMembers { get; set; }

        [Column("voiceActivity")]
        public int VoiceActivity { get; set; }

        [Column("messagesActivity")]
        public int MessagesActivity { get; set; }
    }
}
