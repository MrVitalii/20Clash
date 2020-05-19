using ClashofClans.Logic;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicDailyDealsSeenCommand : LogicCommand
    {
        public LogicDailyDealsSeenCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }
    }
}