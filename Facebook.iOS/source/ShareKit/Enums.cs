﻿using System;

using ObjCRuntime;

namespace Facebook.ShareKit
{
	[Native]
	public enum AppGroupPrivacy : ulong
	{
		Open = 0,
		Closed
	}

	[Native]
	public enum AppInviteDestination : ulong
	{
		Facebook = 0,
		Messenger,
	}

	[Native]
	public enum GameRequestActionType : ulong
	{
		None = 0,
		Send,
		AskFor,
		Turn
	}

	[Native]
	public enum GameRequestFilter : ulong
	{
		None = 0,
		AppUsers,
		AppNonUsers
	}

	[Native]
	public enum LikeObjectType : ulong
	{
		Unknown = 0,
		OpenGraph,
		Page
	}

	[Native]
	public enum ShareError : long {
		Reserved = 200,
		OpenGraph,
		DialogNotAvailable,
		Unknown
	}

	[Native]
	public enum ShareDialogMode : ulong
	{
		Automatic = 0,
		Native,
		ShareSheet,
		Browser,
		Web,
		FeedBrowser,
		FeedWeb
	}

	[Flags]
	[Native]
	public enum ShareBridgeOptions : ulong {
		Default = 0,
		PhotoAsset = 1 << 0,
		PhotoImageURL = 1 << 1,
		VideoAsset = 1 << 2,
		VideoData = 1 << 3,
		WebHashtag = 1 << 4
	}
}
