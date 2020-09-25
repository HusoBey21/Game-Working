using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegiskenHava : MonoBehaviour
{
    public WeatherStates havaDurumu;
    private int havaDegistir;
    public enum WeatherStates
    {
        Acik,
        Gunes,
        Yildirim,
        Sis,       //Konu başlıklarını sıralar.
        Bulanik,
        Karli
    }
    IEnumerator HavaSDM()
    {
        while(true)
        {
            switch(havaDurumu)
            {
                case WeatherStates.Acik:
                    Acik();
                    break;
                case WeatherStates.Gunes:
                    Gunes();
                    break;
                case WeatherStates.Yildirim:
                    Yildirim();
                    break;
                case WeatherStates.Sis:     //Bildiğimiz switch case yapısı
                    Sis();
                    break;
                case WeatherStates.Bulanik:
                    Bulanik();
                    break;

            }

        }
        yield return null;
    }
    void Start()
    {

    }
    void Update()
    {

    }
    void Acik()
    {
        havaDegistir = Random.Range(0, 5); //Sıfır ile beş arasında rastgele sayı ürettik.
        switch(havaDegistir)
        {
            case 0:
                havaDurumu = DegiskenHava.WeatherStates.Gunes;
                break;
            case 1:
                havaDurumu = DegiskenHava.WeatherStates.Bulanik;
                break;
            case 2:
                havaDurumu = DegiskenHava.WeatherStates.Sis;
                break;
            case 3:
                havaDurumu = DegiskenHava.WeatherStates.Yildirim;
                break;
            case 4:
                havaDurumu = DegiskenHava.WeatherStates.Karli;
                break;
        }
    }
    void Gunes()
    {

    }
    void Yildirim()
    {

    }
    void Sis()
    {

    }
    void Bulanik()
    {

    }
    void Karli()
    {

    }
}

