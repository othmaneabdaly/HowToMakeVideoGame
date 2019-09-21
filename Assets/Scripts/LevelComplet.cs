using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplet : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
