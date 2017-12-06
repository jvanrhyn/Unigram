// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Help
{
	public partial class TLHelpConfigSimple : TLObject 
	{
		public Int32 Date { get; set; }
		public Int32 Expires { get; set; }
		public Int32 DCId { get; set; }
		public TLVector<TLIpPort> IpPortList { get; set; }

		public TLHelpConfigSimple() { }
		public TLHelpConfigSimple(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpConfigSimple; } }

		public override void Read(TLBinaryReader from)
		{
			Date = from.ReadInt32();
			Expires = from.ReadInt32();
			DCId = from.ReadInt32();

            var crc = from.ReadUInt32();
            var count = from.ReadInt32();

            var list = new TLVector<TLIpPort>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new TLIpPort(from));
            }

            IpPortList = list;
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteUInt32(0xD997C3C5);
			to.WriteInt32(Date);
			to.WriteInt32(Expires);
			to.WriteInt32(DCId);
			to.WriteObject(IpPortList);
		}
	}
}