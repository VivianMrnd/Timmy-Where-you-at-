using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    public void playAgainButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
