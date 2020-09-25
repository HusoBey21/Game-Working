//11 Temmuz 2020 Cumartesi
using UnityEngine;

public class NesneTopla : MonoBehaviour
{
    public static int nesneler = 0;
    //İlklendirme için kullandık.
    void OnTriggerEnter(Collider oyuncu)
    { //Bir kez çağrılan değişkenleri güncelledik.
        if (oyuncu.gameObject.tag == "Player")
        {
            nesneler++;

            gameObject.SetActive(false);
        }
    }
}
