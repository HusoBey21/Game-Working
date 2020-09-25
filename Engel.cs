
using UnityEngine;

public class Engel : MonoBehaviour
{
    public int saglik;
    void Update()
    {
        Debug.Log(saglik.ToString());
        if(saglik<=0)
        {
            Destroy(gameObject);
        }
    }
    
}
