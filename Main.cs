using UnityEngine;

namespace ShallowSalts
{
	public class Main
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(ShallowSalts));
			gameObject.AddComponent<ShallowSalts>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}