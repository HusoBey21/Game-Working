
using UnityEngine;

public class FuzeFirlat : MonoBehaviour
{
    public GameObject fuzeOrnegi;
    private Transform benimDonusumum;
    // Start is called before the first frame update
    void Start()
    {
        benimDonusumum = transform;
    }

    // Update is called once per frame
    void Update()
    {
      
        
            FuzeOlustur();
       
    }
    void FuzeOlustur()
    {
        Instantiate(fuzeOrnegi, benimDonusumum.transform.TransformPoint(0, 0, 2f), benimDonusumum.rotation);
    }
    
}
