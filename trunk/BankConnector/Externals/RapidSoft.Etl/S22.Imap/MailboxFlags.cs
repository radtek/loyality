﻿using System;

namespace S22.Imap {
	/// <summary>
	/// An IMAP mailbox can have a number of flags (read: attributes) set on it,
	/// indicating its designated purpose (such as "Spam" or "Drafts").
	/// 
	/// This is especially convenient if dealing with international mailbox
	/// names, because by examining the associated flags, the mailbox purpose
	/// can be easily determined, even if the mailbox name provides no useful
	/// indication.
	/// </summary>
	/// <remarks>
	/// Unfortunately as with many things IMAP, reporting the flags described
	/// above is an optional extension (XLIST) to the IMAP protocol and as
	/// such may or may not be supported by an IMAP server.
	/// </remarks>
	public enum MailboxFlag {
		/// <summary>
		/// The mailbox presents a view on all messages in the user's message
		/// store.
		/// </summary>
		AllMail,
		/// <summary>
		/// The mailbox is used to archive messages. The meaning of an
		/// "archival" mailbox is server-dependent.
		/// </summary>
		Archive,
		/// <summary>
		/// The mailbox is used to hold draft messages, typically these are
		/// messages that are being composed but have not yet been sent.
		/// </summary>
		Drafts,
		/// <summary>
		/// The mailbox is used to hold copies of messages that have been
		/// sent.  
		/// </summary>
		Sent,
		/// <summary>
		/// The mailbox is where messages deemed to be junk mail (spam) are
		/// held.
		/// </summary>
		Spam,
		/// <summary>
		/// The mailbox is used to hold messages that have been deleted or
		/// marked for deletion.
		/// </summary>
		Trash
	}
}
