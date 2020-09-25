// 21 Haziran 2020 Pazar 
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))] //Gerekli bileşenler oluşturuldu.

public class Tirmanma : MonoBehaviour
{
    public float yuruyusSurati = 100.0f;
    public float tirmanmaSurati = 60.0f;
    public LayerMask duvarMaskesi;
    bool tirmanis;
    Vector3 duvarNoktasi;
    Vector3 Normalduvar;
    Rigidbody govde;
    CapsuleCollider carpis;
    void Start()
    {
        govde = GetComponent<Rigidbody>();
        carpis = GetComponent<CapsuleCollider>();  //Gerekli ilklendirmeler yapıldı.
        
    }
    void SabitlenmisGuncelleme()
    {
        if(DuvaraYakin())
        {
            if(DuvarYuzeyi())
            {
                if(Input.GetKeyUp(KeyCode.T))
                {
                    tirmanis = !tirmanis;
                }
            }
        }
        else
        {
            tirmanis = false;

        }
        if(tirmanis)
        {
            DuvaraTirman();
        }
        else
        {
            Yurume();

        }

    }
    void Yurume()
    {
        govde.useGravity = true; //Yer çekimi ayarı yapıldı.
        var d = Input.GetAxis("Vertical");
        var y = Input.GetAxis("Horizontal"); //Yatay ve düşey eksen değerleri aldık.
        var hareket = transform.forward * d + transform.right * y; // yatay ve düşey eksen üzerinde ilerleme sağlanıyor.
        HareketiSagla(hareket, yuruyusSurati);


    }
    bool DuvaraYakin()
    {
        return Physics.CheckSphere(transform.position, 3f, duvarMaskesi);

    }
    bool DuvarYuzeyi()
    {
        RaycastHit vurus; 
        var duvarYuzeyi = Physics.Raycast(transform.position, transform.forward, out vurus, carpis.radius + 1f,duvarMaskesi);
        duvarNoktasi = vurus.point;
        Normalduvar = vurus.normal;
        return duvarYuzeyi;

    }
    void DuvaraTirman()
    {
        govde.useGravity = false; 
        DuvaraTutun();
        var d = Input.GetAxis("Vertical");
        var y = Input.GetAxis("Horizontal");
        var hareket = transform.forward * d + transform.right * y; // Yatay ve düşey eksende yapılan hareket tanımlandı.
        HareketiSagla(hareket, tirmanmaSurati); 

    }
    void DuvaraTutun()
    {
        var yeniKonum = duvarNoktasi + Normalduvar * (carpis.radius - 0.1f);
        transform.position = Vector3.Lerp(transform.position, yeniKonum, 10 * Time.deltaTime); //Noktaların doğrusallığını hesaplar.
        if(Normalduvar==Vector3.zero)
        {
            return;
        }
        transform.rotation = Quaternion.LookRotation(-Normalduvar); // İleri ve yukarıya doğru dönüş sağlar.
    }
    void HareketiSagla(Vector3 hareket,float surat)
    {
        govde.MovePosition(transform.position + hareket * surat * Time.deltaTime);
    }
    
}
