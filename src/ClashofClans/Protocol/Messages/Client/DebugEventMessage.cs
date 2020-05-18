using ClashofClans.Logic;
using ClashofClans.Utilities.Netty;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client
{
    public class DebugEventMessage : PiranhaMessage
    {
        public DebugEventMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }

        public string EventName { get; set; }
        public string Event { get; set; }

        public override void Decode()
        {
            EventName = Reader.ReadScString();
            Event = Reader.ReadScString();
        }

        public override void Process()
        {
            Logger.Log($"Name: {EventName}, Event: {Event}", GetType(), Logger.ErrorLevel.Debug);
        }
    }
}