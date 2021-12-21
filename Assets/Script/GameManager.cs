
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public GameObject completeLevelUI;
    public GameObject gameOver;
    public GameObject playAgain;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);

    }
    public void GameOver()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            gameOver.SetActive(true);
            playAgain.SetActive(true);
        }
    }
}
