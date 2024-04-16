using System.Text.Json.Serialization;
using Lagrange.Core.Message;
using Lagrange.OneBot.Message;

namespace Lagrange.OneBot.Core.Entity.Message;

[Serializable]
public class OneBotNode : SegmentBase
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("nickname")]
    public string NickName { get; set; }

    [JsonPropertyName("content")]
    public List<OneBotSegment> Content { get; set; }
    
    public IMessageEntity ToEntity() => throw new NotImplementedException();

    public override void Build(MessageBuilder builder, SegmentBase segment) => throw new NotImplementedException();

    public override SegmentBase FromEntity(MessageChain chain, IMessageEntity entity) => throw new NotImplementedException();
}
