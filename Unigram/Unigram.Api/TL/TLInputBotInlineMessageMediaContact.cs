// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineMessageMediaContact : TLInputBotInlineMessageBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			ReplyMarkup = (1 << 2),
		}

		public bool HasReplyMarkup { get { return Flags.HasFlag(Flag.ReplyMarkup); } set { Flags = value ? (Flags | Flag.ReplyMarkup) : (Flags & ~Flag.ReplyMarkup); } }

		public Flag Flags { get; set; }
		public String PhoneNumber { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }

		public TLInputBotInlineMessageMediaContact() { }
		public TLInputBotInlineMessageMediaContact(TLBinaryReader from, TLType type = TLType.InputBotInlineMessageMediaContact)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineMessageMediaContact; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputBotInlineMessageMediaContact)
		{
			Flags = (Flag)from.ReadInt32();
			PhoneNumber = from.ReadString();
			FirstName = from.ReadString();
			LastName = from.ReadString();
			if (HasReplyMarkup) { ReplyMarkup = TLFactory.Read<TLReplyMarkupBase>(from); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2DAF01A7);
			to.Write((Int32)Flags);
			to.Write(PhoneNumber);
			to.Write(FirstName);
			to.Write(LastName);
			if (HasReplyMarkup) to.WriteObject(ReplyMarkup);
		}
	}
}