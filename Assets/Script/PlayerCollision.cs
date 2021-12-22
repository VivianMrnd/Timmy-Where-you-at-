
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]private float damage;


   private void OnCollisionEnter( Collision collisionInf)
    {
        if (collisionInf.collider.tag== "PalmTree")
        {
            FindObjectOfType<life>().TakeDamage(damage);

        }
    }
}
