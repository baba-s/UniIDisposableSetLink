using Kogane.Internal;
using System;
using UnityEngine;

namespace Kogane
{
	public static class IDisposableExt
	{
		public static void SetLink( this IDisposable self, GameObject gameObject )
		{
			var listener = gameObject.GetComponent<OnDestroyListener>();

			if ( listener == null )
			{
				listener = gameObject.AddComponent<OnDestroyListener>();
			}

			listener.OnDestroyed += () => self.Dispose();
		}

		public static void SetLink( this IDisposable self, Component component )
		{
			SetLink( self, component.gameObject );
		}
	}
}