
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level : MonoBehaviour
    
{
    Text levelText;
    int sceneIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        levelText = GetComponent<Text>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level " + sceneIndex;

    }
}
