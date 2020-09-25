//11 Temmuz 2020 Cumartesi
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alev : MonoBehaviour
{
    float hareketSurati = 7f;
    Rigidbody rb; //Hareket için fizik bileşeni ekledik.
    Vector3 hareketYonu; //Nereye doğru yönelmesini sağlar.
    GameObject hedef;
    OyuncuBilgisi saglik;

    void Start()
    {
        saglik = GetComponent<OyuncuBilgisi>();
        rb = GetComponent<Rigidbody>();
        hedef = GameObject.FindGameObjectWithTag("Player");
        this.transform.position = Vector3.MoveTowards(this.transform.position, hedef.transform.position, hareketSurati * Time.deltaTime);
        Destroy(gameObject, 3f); //3 saniye içinde kendini yok edecek.
    }
    void OnTriggerEnter(Collider carpisan)
    {
        if(carpisan.gameObject.transform==hedef)
        {
            saglik.Incinme(10); //Her vuruşta 10 can kaybı olacak.
        }
    }
  
}
