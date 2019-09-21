using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool HasEnded = false;
    public float restartDelay = 2f;
    public GameObject LevelCompletUI;
    public void CompletLevel()
    {
        LevelCompletUI.SetActive(true);
    }

    public void EndGame()
    {
       if(HasEnded == false)
        {
            HasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
