/* GroundCheck
 * Script for setting value of isGrounded using box collider
 */

using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour
{
	private Player player;

	void Start()
	{
		player = gameObject.GetComponentInParent<Player>();
	}
	// true when player is on ground
	void OnTriggerEnter2D(Collider2D col)
	{
		player.isGrounded = true;
	}

	void OnTriggerStay2D(Collider2D col)
	{
		player.isGrounded = true;
	}
	// false when player is off ground
	void OnTriggerExit2D(Collider2D col)
	{
		player.isGrounded = false;
	}
}
