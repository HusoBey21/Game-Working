//30 Haziran 2020 Salı
using UnityEngine;

public class OyuncuHasari : MonoBehaviour
{
    public int oyuncuSagligi;
    int hasar;
    void Start()
    {
        oyuncuSagligi = 30;
        hasar = 10;

    }
    void OnCollisionEnter(Collision carpisma)
    {
        if(carpisma.gameObject.tag=="Alevsaldirisi")
        {
            oyuncuSagligi -= hasar; //Hasardan doğan kayıp
            if(oyuncuSagligi<=0)
            {
                Destroy(this.gameObject);
            }
        }

    }

}
