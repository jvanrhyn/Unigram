// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthSentCode : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			PhoneRegistered = (1 << 0),
			NextType = (1 << 1),
			Timeout = (1 << 2),
		}

		public bool IsPhoneRegistered { get { return Flags.HasFlag(Flag.PhoneRegistered); } set { Flags = value ? (Flags | Flag.PhoneRegistered) : (Flags & ~Flag.PhoneRegistered); } }
		public bool HasNextType { get { return Flags.HasFlag(Flag.NextType); } set { Flags = value ? (Flags | Flag.NextType) : (Flags & ~Flag.NextType); } }
		public bool HasTimeout { get { return Flags.HasFlag(Flag.Timeout); } set { Flags = value ? (Flags | Flag.Timeout) : (Flags & ~Flag.Timeout); } }

		public Flag Flags { get; set; }
		public TLAuthSentCodeTypeBase Type { get; set; }
		public String PhoneCodeHash { get; set; }
		public TLAuthCodeTypeBase NextType { get; set; }
		public Int32? Timeout { get; set; }

		public TLAuthSentCode() { }
		public TLAuthSentCode(TLBinaryReader from, TLType type = TLType.AuthSentCode)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AuthSentCode; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AuthSentCode)
		{
			Flags = (Flag)from.ReadInt32();
			Type = TLFactory.Read<TLAuthSentCodeTypeBase>(from);
			PhoneCodeHash = from.ReadString();
			if (HasNextType) { NextType = TLFactory.Read<TLAuthCodeTypeBase>(from); }
			if (HasTimeout) { Timeout = from.ReadInt32(); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5E002502);
			to.Write((Int32)Flags);
			to.WriteObject(Type);
			to.Write(PhoneCodeHash);
			if (HasNextType) to.WriteObject(NextType);
			if (HasTimeout) to.Write(Timeout.Value);
		}
	}
}