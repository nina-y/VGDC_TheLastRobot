using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public GameObject MainUI;

	void Start ()
	{
		MainUI.SetActive (true);
	}

	public void Play ()
	{
		SceneManager.LoadScene (1);
	}

	public void Options ()
	{

	}

	public void Quit ()
	{
		Application.Quit ();
	}
}
