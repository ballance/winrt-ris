﻿using System;
using System.Runtime.Serialization;

namespace Ris.Client.PhraseParser
{
	/// <summary>
	/// Desctiption of ParseException.
	/// </summary>
	public class ParseException : Exception
	{
		public ParseException()
		{
		}

	 	public ParseException(string message) : base(message)
		{
		}

		public ParseException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}