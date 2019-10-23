using System;
using UnityEngine;

namespace Cyborg.Platformer {

	public class PlatformerEvents
	{

		public static event Action OnJump;

		public static void Jump() {
			if (OnJump != null) {
				OnJump();
			}
		}
	}

}
