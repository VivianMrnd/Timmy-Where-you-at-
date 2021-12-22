
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothFactor= 0.5f;
    public bool lookattarget = false;

    private void Start()
    {
        offset = transform.position - target.transform.position;
    }
    private void LateUpdate()
    {
        Vector3 newPosition = target.transform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPosition,smoothFactor);
        if (lookattarget)
        {
            transform.LookAt(target);
        }
    }
}
