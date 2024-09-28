namespace JournalProgram
{
    public class PromptGenerator
    {
        private List<string> prompts;

        public PromptGenerator()
        {
            prompts = new List<string>
            {
                "If you had to choose a color to describe your day, what color and why? ",
                "What are you grateful for today? ",
                "What was difficult today? ",
                "Who deserves a shoutout from your day today? ",
                "What was a highlight from your day? "
            };
        }

        public string GetPrompt()
        {
            return prompts[0];
        }
    }

}