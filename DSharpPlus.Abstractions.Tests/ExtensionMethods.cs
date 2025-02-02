﻿using System.Reflection;

namespace DSharpPlus.Abstractions.Tests
{
	public static class ExtensionMethods
	{
		public static T CreateInstance<T>(params object[] args)
		{
			var type = typeof (T);
			var instance = type.Assembly.CreateInstance(
				type.FullName!, false,
				BindingFlags.Instance | BindingFlags.NonPublic,
				null, args, null, null);
			return (T) instance;
		}
	}
}