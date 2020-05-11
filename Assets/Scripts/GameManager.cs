using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 5f;
	public GameObject completeLevelUI;
	public GameObject GameOverUI;

	public PlayerController movement;//This refers to PlayerController script

	public void gameOver ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			GameOverUI.SetActive (true);
			Debug.Log ("Game Over");
			movement.enabled = false;//Stops the movement of the player
			Invoke("Restart",restartDelay);
		}
	}
	public void CompleteLevel ()
	{
		completeLevelUI.SetActive (true);
	}
	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name );
	}
}
