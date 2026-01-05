using UnityEngine;
using Winch.Core;

namespace ShallowSalts
{
	public class ShallowSalts : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(ShallowSalts)} has loaded!");
		}
	}
}
