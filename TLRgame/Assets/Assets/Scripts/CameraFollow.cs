/* CameraFollow
 * Script for following the player with the camers
 */

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	private Vector2 velocity;

	public float smoothTimeX;
	public float smoothTimeY;

	public bool bounds;

	public Vector3 minValue;
	public Vector3 maxValue;

	public GameObject player;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void FixedUpdate ()
	{
		float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

		transform.position = new Vector3 (posX, posY, transform.position.z);
		// limit camera position to certain bounds
		if (bounds) {
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minValue.x, maxValue.x),
				Mathf.Clamp (transform.position.y, minValue.y, maxValue.y),
				transform.position.z);
		}
	}

	public void SetMinCamPos ()
	{
		minValue = gameObject.transform.position;
	}

	public void SetMaxCamPos ()
	{
		maxValue = gameObject.transform.position;
	}
}
