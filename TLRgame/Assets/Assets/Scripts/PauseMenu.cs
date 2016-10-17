using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public GameObject PauseUI;

	private bool isPaused = false;

	void Start()
	{
		PauseUI.SetActive(false);
	}

	void Update()
	{
		if (Input.GetButtonDown("Pause")) {
			isPaused = !isPaused;
		}
		if (isPaused) {
			PauseUI.SetActive(true);
			Time.timeScale = 0;
		}
		if (!isPaused) {
			PauseUI.SetActive(false);
			Time.timeScale = 1;
		}
	}

	public void Resume()
	{
		isPaused = false;
	}

	public void Restart()
	{
		// Application.LoadLevel (Application.loadedLevel);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void MainMenu()
	{
		// Application.LoadLevel (0);
		SceneManager.LoadScene(0);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
