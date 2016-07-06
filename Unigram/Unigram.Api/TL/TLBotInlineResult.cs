// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLBotInlineResult : TLBotInlineResultBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Title = (1 << 1),
			Description = (1 << 2),
			Url = (1 << 3),
			ThumbUrl = (1 << 4),
			ContentUrl = (1 << 5),
			ContentType = (1 << 5),
			W = (1 << 6),
			H = (1 << 6),
			Duration = (1 << 7),
		}

		public bool HasTitle { get { return Flags.HasFlag(Flag.Title); } set { Flags = value ? (Flags | Flag.Title) : (Flags & ~Flag.Title); } }
		public bool HasDescription { get { return Flags.HasFlag(Flag.Description); } set { Flags = value ? (Flags | Flag.Description) : (Flags & ~Flag.Description); } }
		public bool HasUrl { get { return Flags.HasFlag(Flag.Url); } set { Flags = value ? (Flags | Flag.Url) : (Flags & ~Flag.Url); } }
		public bool HasThumbUrl { get { return Flags.HasFlag(Flag.ThumbUrl); } set { Flags = value ? (Flags | Flag.ThumbUrl) : (Flags & ~Flag.ThumbUrl); } }
		public bool HasContentUrl { get { return Flags.HasFlag(Flag.ContentUrl); } set { Flags = value ? (Flags | Flag.ContentUrl) : (Flags & ~Flag.ContentUrl); } }
		public bool HasContentType { get { return Flags.HasFlag(Flag.ContentType); } set { Flags = value ? (Flags | Flag.ContentType) : (Flags & ~Flag.ContentType); } }
		public bool HasW { get { return Flags.HasFlag(Flag.W); } set { Flags = value ? (Flags | Flag.W) : (Flags & ~Flag.W); } }
		public bool HasH { get { return Flags.HasFlag(Flag.H); } set { Flags = value ? (Flags | Flag.H) : (Flags & ~Flag.H); } }
		public bool HasDuration { get { return Flags.HasFlag(Flag.Duration); } set { Flags = value ? (Flags | Flag.Duration) : (Flags & ~Flag.Duration); } }

		public Flag Flags { get; set; }
		public String Url { get; set; }
		public String ThumbUrl { get; set; }
		public String ContentUrl { get; set; }
		public String ContentType { get; set; }
		public Int32? W { get; set; }
		public Int32? H { get; set; }
		public Int32? Duration { get; set; }

		public TLBotInlineResult() { }
		public TLBotInlineResult(TLBinaryReader from, TLType type = TLType.BotInlineResult)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.BotInlineResult; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.BotInlineResult)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadString();
			Type = from.ReadString();
			if (HasTitle) { Title = from.ReadString(); }
			if (HasDescription) { Description = from.ReadString(); }
			if (HasUrl) { Url = from.ReadString(); }
			if (HasThumbUrl) { ThumbUrl = from.ReadString(); }
			if (HasContentUrl) { ContentUrl = from.ReadString(); }
			if (HasContentType) { ContentType = from.ReadString(); }
			if (HasW) { W = from.ReadInt32(); }
			if (HasH) { H = from.ReadInt32(); }
			if (HasDuration) { Duration = from.ReadInt32(); }
			SendMessage = TLFactory.Read<TLBotInlineMessageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9BEBAEB9);
			to.Write((Int32)Flags);
			to.Write(Id);
			to.Write(Type);
			if (HasTitle) to.Write(Title);
			if (HasDescription) to.Write(Description);
			if (HasUrl) to.Write(Url);
			if (HasThumbUrl) to.Write(ThumbUrl);
			if (HasContentUrl) to.Write(ContentUrl);
			if (HasContentType) to.Write(ContentType);
			if (HasW) to.Write(W.Value);
			if (HasH) to.Write(H.Value);
			if (HasDuration) to.Write(Duration.Value);
			to.WriteObject(SendMessage);
		}
	}
}