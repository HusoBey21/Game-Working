// 25 Haziran 2020 Perşembe 
using UnityEngine;

public class NesneFirlat : MonoBehaviour
{
    public Transform oyuncu;
    public Transform nesne;
    public float firlatmaKuvveti = 10.0f;
    bool oyuncudaMi = false;
    bool tasiniyorMu = false;
    public AudioSource ses;
    public int hasar;
    private bool dokunulmus = false;
    Rigidbody rb;

    void Start()
    {
        ses = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float uzaklik = Vector3.Distance(gameObject.transform.position, oyuncu.position);
        if(uzaklik<=3.0f)
        {
            oyuncudaMi = true;
        }
        else
        {
            oyuncudaMi = false;
        }
        if (oyuncudaMi && Input.GetButtonDown("Use")) //Tuş ataması yapıldı.
        {
            rb.isKinematic = false;
            transform.parent = null;
            tasiniyorMu = true;
        }
        if(tasiniyorMu)
        {
            if(dokunulmus)
            {
                rb.isKinematic = false;
                transform.parent = null;
                tasiniyorMu = false;
                dokunulmus = false;
            }
            if(Input.GetButtonDown("0"))
            {
                rb.isKinematic = false;
                transform.parent = null;
                tasiniyorMu = false;
                rb.AddForce(nesne.forward * firlatmaKuvveti);
                RastgeleSes();

            }
            else if(Input.GetButtonDown("1"))
            {
                rb.isKinematic = false;
                transform.parent = null;
                tasiniyorMu = false;
            }


        }
    }
    void RastgeleSes()
    {
        if(ses.isPlaying)
        {
            return;
        }
        ses.Play();

    }
    void OnTriggerEnter()
    {
        if(tasiniyorMu)
        {
            dokunulmus = true;
        }
    }

}
