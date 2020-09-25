using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHasari1 : MonoBehaviour
{
    public int oyuncuSagligi;
    int hasar=10;
    void Start()
    {
        oyuncuSagligi = GetComponent<SaglikSistemi>().saglik;
    }
    void OnCollisionEnter(Collision carpisma)
    {
        if(carpisma.gameObject.tag=="Alevsaldirisi")
        {
            oyuncuSagligi -= hasar;
            Destroy(carpisma.gameObject);
            if(oyuncuSagligi <=0)
            {
                Destroy(gameObject);

            }
        }
    }
}
