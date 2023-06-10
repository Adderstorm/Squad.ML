using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Squad.ML.Application.Models
{
    [Table("AIPrep")]
    public class AIPrep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public int Id { get; set; }

        [Column("serverId")]
        public long Server { get; set; }

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

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
