using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cyborg.Platformer {

	// Camera controller designed for platformers
	
	[RequireComponent(typeof(Camera))]
	public class CameraController : MonoBehaviour
	{
		
		// Set to clamp the camera
		public float xMin;
		public float xMax;
		public float yMin;
		public float yMax;
		
		// Reference to the player character
		private GameObject player;
		
		Vector3 StartingPosition = new Vector3(0f, 0f, -10f);
		
		void LateUpdate() {
			TrackPlayer();
		}

		void TrackPlayer() {
			
			SetPlayer();
			
			if (player == null) {
				ResetCamera();
			} else {
				SetPlayerPosition();
			}
		}
		
		// Initializes the player
		void SetPlayer() {
			if (player == null) {
				player = GameObject.FindWithTag("Player");
			}
		}
		
		void SetPlayerPosition() {
			float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
			float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
			
			transform.position = new Vector3(x, y, transform.position.z);		
		}
		
		// Reset the camera to the starting position
		void ResetCamera() {
			transform.position = StartingPosition;
		}
		
	}	
	
}
	
