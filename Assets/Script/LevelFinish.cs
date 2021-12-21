using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
