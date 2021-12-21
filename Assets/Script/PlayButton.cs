using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void playButton()
    {
        SceneManager.LoadScene("Level01");
    }
}
