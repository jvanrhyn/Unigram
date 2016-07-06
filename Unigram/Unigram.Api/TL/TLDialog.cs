// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDialog : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			Pts = (1 << 0),
			Draft = (1 << 1),
		}

		public bool HasPts { get { return Flags.HasFlag(Flag.Pts); } set { Flags = value ? (Flags | Flag.Pts) : (Flags & ~Flag.Pts); } }
		public bool HasDraft { get { return Flags.HasFlag(Flag.Draft); } set { Flags = value ? (Flags | Flag.Draft) : (Flags & ~Flag.Draft); } }

		public Flag Flags { get; set; }
		public TLPeerBase Peer { get; set; }
		public Int32 TopMessage { get; set; }
		public Int32 ReadInboxMaxId { get; set; }
		public Int32 ReadOutboxMaxId { get; set; }
		public Int32 UnreadCount { get; set; }
		public TLPeerNotifySettingsBase NotifySettings { get; set; }
		public Int32? Pts { get; set; }
		public TLDraftMessageBase Draft { get; set; }

		public TLDialog() { }
		public TLDialog(TLBinaryReader from, TLType type = TLType.Dialog)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.Dialog; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.Dialog)
		{
			Flags = (Flag)from.ReadInt32();
			Peer = TLFactory.Read<TLPeerBase>(from);
			TopMessage = from.ReadInt32();
			ReadInboxMaxId = from.ReadInt32();
			ReadOutboxMaxId = from.ReadInt32();
			UnreadCount = from.ReadInt32();
			NotifySettings = TLFactory.Read<TLPeerNotifySettingsBase>(from);
			if (HasPts) { Pts = from.ReadInt32(); }
			if (HasDraft) { Draft = TLFactory.Read<TLDraftMessageBase>(from); }
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x66FFBA14);
			to.Write((Int32)Flags);
			to.WriteObject(Peer);
			to.Write(TopMessage);
			to.Write(ReadInboxMaxId);
			to.Write(ReadOutboxMaxId);
			to.Write(UnreadCount);
			to.WriteObject(NotifySettings);
			if (HasPts) to.Write(Pts.Value);
			if (HasDraft) to.WriteObject(Draft);
		}
	}
}