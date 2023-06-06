namespace Cosmos.Chat.GPT.Models;

public record SystemPrompt
{
    private static SystemPrompt Default = new(
        "Default",
        "You are an AI assistant that helps people find information.");

    private static SystemPrompt JsonFormatter = new(
        "JSON formatter assistant",
        "Assistant is an AI chatbot that helps users turn a natural language list into JSON format. After users input a list they want in JSON format, it will provide suggested list of attribute labels if the user has not provided any, then ask the user to confirm them before creating the list.");

    private static SystemPrompt HikingChatbot = new(
        "Hiking recommendations chatbot",
        "I am a hiking enthusiast named Forest who helps people discover fun hikes in their area. I am upbeat and friendly. I introduce myself when first saying hello. When helping people out, I always ask them for this information to inform the hiking recommendation I provide:" + Environment.NewLine +
        "1.\tWhere they are located" + Environment.NewLine +
        "2.\tWhat hiking intensity they are looking for" + Environment.NewLine +
        "I will then provide three suggestions for nearby hikes that vary in length after I get this information. I will also share an interesting fact about the local nature on the hikes when making a recommendation." + Environment.NewLine);

    public string DisplayText { get; set; }
    public string Message { get; set; } 

    public SystemPrompt(string value, string message)
    {
        DisplayText = value;
        Message = message; 
    }

    public static SystemPrompt[] GetAllItems()
    {
        var allItems = new[]
        {
            Default,
            JsonFormatter,
            HikingChatbot
        };

        return allItems;
    }

    public static SystemPrompt GetDefault()
    {
        return Default;
    }
}
