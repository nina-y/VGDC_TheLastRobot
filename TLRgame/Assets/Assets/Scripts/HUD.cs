using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
	public Sprite[] heartSprites;
	public Image healthUI;

	public Player player;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}

	void Update ()
	{
		healthUI.sprite = heartSprites [player.currHealth];
	}
}
