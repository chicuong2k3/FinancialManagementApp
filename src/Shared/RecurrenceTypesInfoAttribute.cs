using System.Reflection;

namespace Shared;

[AttributeUsage(AttributeTargets.Field)]
public class RecurrenceTypesInfoAttribute : Attribute
{
    public RecurrenceTypesInfoAttribute(string displayText)
    {
        DisplayText = displayText;
    }
    public string DisplayText { get; set; } = string.Empty;
}

public static class ReccurenceTypesExtensions
{
    public static string GetDisplayText(this RecurrenceTypeEnum recurrenceType)
    {
        var type = recurrenceType.GetType();
        var field = type.GetField(recurrenceType.ToString());
        var attribute = field?.GetCustomAttribute<RecurrenceTypesInfoAttribute>(false);
        var displayText = attribute?.DisplayText ?? string.Empty;
        return displayText;
    }
}
