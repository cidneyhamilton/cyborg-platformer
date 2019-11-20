using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cyborg.Platformer {
	
	public class GroundChecker : MonoBehaviour
	{
		
		// Transform that checks to see if this is grounded
		public Transform IsGroundedChecker;
		
		// References the Ground layer to keep track of Ground objects
		public LayerMask GroundLayer;
		
		// Radius to check against
		const float GROUND_CHECK_RADIUS = 0.07f;
		
		const float JUMP_MIDAIR_RADIUS = 0.6f;
		
		public bool IsGrounded {
			get {			
				if (IsGroundedChecker == null) {
					// Debug.LogError("Platformer needs a transform to check on whether it's grounded.");
					return false;
				}
				
				// Return true if it exists, false otherwise
				return GetGroundOverlapCircle() != null;
			}
		}
		
		
		// See if there's overlap between the player and the ground
		Collider2D GetGroundOverlapCircle() {
			return Physics2D.OverlapCircle(IsGroundedChecker.position, GROUND_CHECK_RADIUS, GroundLayer);
		}

		
		// See if there's overlap between the player and the ground
		public bool IsJumpingInMidair() {
			return Physics2D.OverlapCircle(IsGroundedChecker.position, JUMP_MIDAIR_RADIUS, GroundLayer);
		}
		
	}
}
