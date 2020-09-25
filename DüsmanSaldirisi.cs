//30 Haziran 2020 Salı İSTANBUL-ATAŞEHİR
using UnityEngine;

public class DüsmanSaldirisi : MonoBehaviour
{
    public float saldiriArasiZaman = 0.5f;
    public float saldiriGecikmesi = 10.0f;
    float sonSaldiri = -999.0f;
    public float saldiriHasari = 20f;
    DusmanDurumu dusmanSagligi;
    IleriSaglik saglik;
    Animator anim;
    GameObject oyuncu;
    bool menzildekiOyuncu;
    
    void Awake()
    {
        oyuncu = GameObject.FindGameObjectWithTag("Player"); //Etiketi oyuncu olan oyun nesnesini bulduk.
        if (saglik != null)
        {
            saglik = GetComponent<IleriSaglik>();
        }
        else
        {
            Debug.Log("Boş referans beklentisi");
        }
        dusmanSagligi = GetComponent<DusmanDurumu>(); // Düşmanın sağlığını belirler.
        anim = GetComponent<Animator>();   // Animator bileşenini etkinleştirdik.
        

    }
    void OnTriggerEnter(Collider carpisan)
    {
        if(carpisan.gameObject==oyuncu)  //Tetikleyiciyi devreye soktuk.
        {
            Debug.Log("Başarılı");
            menzildekiOyuncu = true;
            saglik.SaglikKaybet(saldiriHasari);
        }

    }
    void OnTriggerExit(Collider carpisan)
    {
        if(carpisan.gameObject==oyuncu)
        {;
            Debug.Log("Başarılı ve sonuçlu");
            menzildekiOyuncu = false; //Tetikleyiciyi devreden çıkardık.
        }
    }
    void Update()
    {
        
        
    }
    
    }

