
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float sidewaysForce = 500f;
    public Score score;

    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    
    void FixedUpdate() //use it to when using physics
    {
       rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d")) //move right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) //move left
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        anim.SetBool("walk", score.scoreText.text != score.player.position.z.ToString("0"));
    }
}
