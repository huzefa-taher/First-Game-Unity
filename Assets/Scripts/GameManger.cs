using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject CompleteLeveUI;

    public void CompleteLevel()
    {
        CompleteLeveUI.SetActive(true);
    }

	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
