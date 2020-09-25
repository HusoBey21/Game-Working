//12 Temmuz 2020 Pazar 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuzeTakibi : MonoBehaviour
{
    public Camera anaKamera;
    public FuzeYonetimi mermi;


   
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray isin = anaKamera.ScreenPointToRay(Input.mousePosition);  //Kamera ile fare konumu arasında ışın oluşturur.
            FuzeYonetimi yeniFuze = Instantiate(mermi.gameObject).GetComponent<FuzeYonetimi>(); //Yeni mermiler oluşturacak.
            yeniFuze.transform.position = anaKamera.transform.position;
            yeniFuze.YonAyarla(isin.direction);
        }
    }
}
