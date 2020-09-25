
using UnityEngine;

public class hasar : MonoBehaviour
{
    public float saglik=100.0f;
  
   
    // Update is called once per frame
    void Update()
    {
        print(saglik);
        
    }
  public  void Hasar(int hasarlar)
    {
        saglik -= hasarlar;
        Destroy(gameObject);
      
        
    }
}

