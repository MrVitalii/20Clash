using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Commands.Client
{
    public class LogicBuyDailyDealItemCommand : LogicCommand
    {
        public LogicBuyDailyDealItemCommand(Device device, IByteBuffer buffer) : base(device, buffer)
        {
        }

        public int ItemId { get; set; }

        public override void Decode()
        {
            base.Decode();

            ItemId = Reader.ReadInt();
        }

        public override async void Process()
        {
            await new LoginFailedMessage(Device)
            {
                Reason = "DailyDeals haven't been implemented yet."
            }.SendAsync();
        }
    }
}