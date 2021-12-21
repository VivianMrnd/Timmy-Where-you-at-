
using UnityEngine;

public class BgScript : MonoBehaviour
{
    public static BgScript BgInstance;

    private void Awake()
    {
        if(BgInstance != null && BgInstance != this)
        {
            Destroy(gameObject);
            return;
        }
        BgInstance = this;
        DontDestroyOnLoad(this);
    }
}
