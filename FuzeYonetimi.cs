//12 Temmuz 2020 Pazar
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuzeYonetimi : MonoBehaviour
{
    Rigidbody rb;
    public float mermiKuvveti;
    bool ilkZaman = false;
    Vector3 yon;
    DusmanDurumu dusman;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Fizik etkinleştirildi.

    }
    public void YonAyarla(Vector3 yn)
    {
        yon = yn;
        ilkZaman = true;
    }
    void OnCollisionEnter(Collision carpisma)
    {
        if(carpisma.gameObject.tag=="enemy")
        {
            dusman.AlinanHasar(10); //Her çarpışmada 10 hasar alınacak.
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if(ilkZaman)
        {
            rb.AddForce(yon * mermiKuvveti);
            ilkZaman = false;
        }

    }
}
