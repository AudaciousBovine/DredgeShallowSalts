using UnityEngine;

namespace Shallow Salts
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(Shallow Salts));
			gameObject.AddComponent<Shallow Salts>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}