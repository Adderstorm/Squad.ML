using Squad.ML.Application.Models;
using Squad.ML.Engine.Engine;

namespace Squad.ML.Application.Services
{
    public class AIService
    {
        private static readonly IConfiguration? _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

        private static readonly MLModelEngine<AIMembersActivityInput, AIMembersActivityPred> membersActivityEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:MembersActivityMLModelFilePath"]));
        private static readonly MLModelEngine<AIMembersInput, AIMembersPred> membersEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:MembersMLModelFilePath"]));
        private static readonly MLModelEngine<AIVoiceActivityInput, AIVoiceActivityPred> voiceActivityEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:VoiceActivityMLModelFilePath"]));
        private static readonly MLModelEngine<AIMessagesActivityInput, AIMessagesActivityPred> messagesActivityEngine = new(modelFilePathName: GetAbsolutePath(_configuration["MLModel:MessagesActivityMLModelFilePath"]));

        public static AIMembersPred MembersPred(AIMembersInput input)
        {
            return membersEngine.Predict(input);
        }

        public static AIMembersActivityPred MembersActivityPred(AIMembersActivityInput input)
        {
            return membersActivityEngine.Predict(input); ;
        }

        public static AIVoiceActivityPred VoiceActivityPred(AIVoiceActivityInput input)
        {
            return voiceActivityEngine.Predict(input);
        }

        public static AIMessagesActivityPred MessagesActivityPred(AIMessagesActivityInput input)
        {
            return messagesActivityEngine.Predict(input);
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
