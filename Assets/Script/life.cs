
using UnityEngine;
using UnityEngine.UI;
public class life : MonoBehaviour
{
    public float lives;
    public Slider slider;
    public Text text;
    public PlayerMovement movement;

    private bool dead;

     void Update()
    {
        slider.value = lives;
        text.text = "Life: " + lives;
        if(dead == true)
         {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
    public void TakeDamage(float damage)
    {
       lives -= damage;
    
            if (lives < 1)
            {
                dead = true;
            }
        
    }
}
