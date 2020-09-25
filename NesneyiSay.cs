using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NesneyiSay : MonoBehaviour
{
    public string sonrakiasama;
    public GameObject yokedilenNesne;
     GameObject NesneKA;
    void Start()
    {

        NesneKA = GameObject.Find("NesneSayısı");

    }
    void Update()
    {
        NesneKA.GetComponent<Text>().text = NesneTopla.nesneler.ToString();
        if(NesneTopla.nesneler==0)
        {
            
            Destroy(yokedilenNesne);
            NesneKA.GetComponent<Text>().text = "Tüm nesneler toplandı.";
        }
    }

}
