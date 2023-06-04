using SquadML.Application.Models;
using SquadML.Engine.Engine;

namespace SquadML.Application.Services
{
    public class AIService
    {
        private static readonly IConfiguration? _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

        private readonly MLModelEngine<AIMembersActivityInput, AIMembersActivityPred> membirsActivityEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:MLModelFilePath"]));
        private readonly MLModelEngine<AIMembersInput, AIMembersPred> membersEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:MLModelFilePath"]));
        private readonly MLModelEngine<AIVoiceActivityInput, AIVoiceActivityPred> voiceActivityEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:MLModelFilePath"]));
        private readonly MLModelEngine<AIMessagesActivityInput, AIMessagesActivityPred> messagesActivityEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:MLModelFilePath"]));

        public AIMembersPred MembersPred(AIMembersInput input)
        {
            return;
        }

        public AIMembersActivityPred ActivityPred(AIMembersActivityInput input)
        {
            return;
        }

        public AIVoiceActivityPred VoiceActivityPred(AIVoiceActivityInput input)
        {
            return;
        }

        public AIMessagesActivityPred MessagesActivityPred(AIMessagesActivityInput input)
        {
            return;
        }

        private static string GetAbsolutePath(string relativePath)
        {
            FileInfo? _dataRoot = new(typeof(Program).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }
    }
}
