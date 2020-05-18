using ClashofClans.Logic.Clan.StreamEntry;
using DotNetty.Buffers;
using Newtonsoft.Json;
using ClashofClans.Utilities.Netty;

namespace ClashofClans.Logic
{
    class ChatStreamEntry : AllianceStreamEntry
    {
        public ChatStreamEntry()
        {
            StreamEntryType = 2;
        }

        [JsonProperty("msg")] public string Message { get; set; }

        public override void Encode(IByteBuffer packet)
        {
            base.Encode(packet);

            packet.WriteScString(Message);
        }
    }
}
