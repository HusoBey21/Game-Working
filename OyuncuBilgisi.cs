
using UnityEngine;

public class OyuncuBilgisi : MonoBehaviour
{
    public int saglik;

    // Start is called before the first frame update
    void Start()
    {
        saglik = 100;
    }

    public void Incinme(int hasar)
    {
        saglik -= hasar;
        if(saglik <=0)
        {
            Destroy(gameObject);
        }
    }
    
}
