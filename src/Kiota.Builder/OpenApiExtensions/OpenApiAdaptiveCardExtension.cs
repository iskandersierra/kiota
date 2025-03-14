using System.Text.Json.Nodes;

namespace Kiota.Builder.OpenApiExtensions;

public class OpenApiAdaptiveCardExtension : OpenApiSimpleStringExtension
{
    public static string Name => "x-ai-adaptive-card";
    public string? AdaptiveCard
    {
        get; set;
    }
    protected override string? ValueSelector => AdaptiveCard;
    public static OpenApiAdaptiveCardExtension Parse(JsonNode source)
    {
        return new OpenApiAdaptiveCardExtension
        {
            AdaptiveCard = ParseString(source)
        };
    }
}
