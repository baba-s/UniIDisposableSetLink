using System;
using UnityEngine;

namespace Kogane.Internal
{
	[DisallowMultipleComponent]
	[AddComponentMenu( "" )]
	internal sealed class OnDestroyListener : MonoBehaviour
	{
		public event Action OnDestroyed;

		private void OnDestroy()
		{
			OnDestroyed?.Invoke();
			OnDestroyed = null;
		}
	}
}