
using UnityEngine;

public class SilahlaSaldir : MonoBehaviour
{
    public Transform[] silahlar;
    private Transform suankiSilah;
    private int secilenSilahIndisi = 0;
    private Animator anlikSilah;
    public GameObject dusman;
    bool saldiri = true;
    public int saglik = 100;
    public int hasar = 10;

    void Update()
    {
        if (saldiri)
        {
            if (suankiSilah == null)
            {
                Kusan(silahlar[secilenSilahIndisi]);
            }
            anlikSilah.Play("Base Layer.Fire",0,0.25f);

        }
        Genel();
    }
    void Kusan(Transform silahOrnegi)
    {
        // Silahın karakter konumunu örnekledik.
        Transform silah = (Transform)Instantiate(silahOrnegi, transform.position, transform.rotation);
        silah.parent = transform;

    }
    void Genel()
    {
        Vector3 dusmanDegisimi = (dusman.transform.position - transform.position);
        if (Vector3.Angle(transform.forward, dusmanDegisimi) < 45)
        {
            while(saglik >0)
            {
                saglik -= hasar;
            }
            
        }
    }
        




}