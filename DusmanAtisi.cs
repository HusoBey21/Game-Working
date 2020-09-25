//20 Temmuz 2020 Pazartesi
//21 Temmuz 2020 Salı
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanAtisi : MonoBehaviour
{
    public float enYuksekHasar = 120f; //Atış başına en yüksek hasar.
    public float enDusukHasar = 45f; //Atış başına en düşük hasar.
    public AudioSource atisKlibi;
    public float isikYogunlugu = 3f; //Atış gerçekleştiğinde olan ışık yoğunluğu
    public float karartmaSurati = 10f; //Işık  atış sonrası nasıl bir hızla kararacak.
    
    public LineRenderer lazerAtisCizgisi; //Adı verilen değişkeni oluşturur.
    public Light lazerAtisIsigi;//Bu ışık ayarında kullanılacak.
    private IleriSaglik oyuncuSagligi; //Bu da hedefteki oyuncunun sağlığına yönelik bilgilendirme içerir.
    public bool atis; //Bu da tışın etkinliğini sorgular.
    public float olculenHasar; //Bu da oyuncuya düşman tarafından verilen hasarı belirtir.
    public SphereCollider carpis; //Küresel çarpışma değişkeni olarak tanımlanabilir.
    public Transform oyuncu;//Bu da oyuncunun kim olduğunu tutan bir değişkendir.
    public float katsayi; //Atış değerine rastgele sayılar ataması yapacağım.
    void Awake()
    {
        atisKlibi = GetComponent<AudioSource>(); //Ses kaynağını etkinleştirdik.
        lazerAtisCizgisi = GetComponentInChildren<LineRenderer>();
        lazerAtisIsigi = lazerAtisCizgisi.gameObject.GetComponentInChildren<Light>();
        carpis = GetComponent<SphereCollider>();
        oyuncu = GameObject.FindGameObjectWithTag("Player").transform; //Etiketi İngilizce oyuncu olan her oyun nesnesini temel alacaktır.
        oyuncuSagligi = oyuncu.gameObject.GetComponent<IleriSaglik>();//İleri sağlık sınıfından oyuncunun sağlığı ile ilgili bir nesne aldık.
       
        lazerAtisCizgisi.enabled = false; //Şu an atış çizgisi etkisiz.
        lazerAtisIsigi.intensity = 0; //Atış ışığının yoğunluğu da sıfır olarak ayarlandı.
        olculenHasar = enYuksekHasar - enDusukHasar; //Ölçülen hasar da en yüksek hasar ile en düşük hasarın farkıdır.

    }
    void Update()
    {
        katsayi = Random.Range(0f, 1f); //Katsayı değeri sıfır ile bir arasında ondalıklı sayı olarak gidip gelecek;
        if(katsayi>0.5f && !atis)
        {
            Atesle(); //Aşağıda bu methodun içini dolduracağız.
        }
        if(katsayi<0.5f)
        {
            atis = false;
            lazerAtisCizgisi.enabled = false; //Yani bu sayı degeri 0.5f olmadan atış gerçekleşmez.
        }
        lazerAtisIsigi.intensity = Mathf.Lerp(lazerAtisIsigi.intensity, 0f, karartmaSurati * Time.deltaTime);

    }
    void Atesle()
    {
        atis = true;
        float kirilmaUzakligi = (carpis.radius - Vector3.Distance(transform.position, oyuncu.position) / carpis.radius);//Yarıçap başına düşen uzaklık.
        float hasar = olculenHasar * kirilmaUzakligi * Time.deltaTime; //Zamana bağlı gelişen hasar miktarı
        oyuncuSagligi.SaglikKaybet(hasar); //Hasar miktarını tanımladık.
        
        AtisEtkisi();

    }
    void AtisEtkisi()
    {
        lazerAtisCizgisi.SetPosition(0, lazerAtisCizgisi.transform.position);
        //Bu başlangıç konumuydu.
        lazerAtisCizgisi.SetPosition(1, oyuncu.position + Vector3.up * 2f);
        //Bitiş konumunu da oyuncunun kütle merkezine yerleştirdik.
        lazerAtisCizgisi.enabled = true;
        lazerAtisIsigi.intensity = isikYogunlugu;
        while (!atisKlibi.isPlaying)
        {
            atisKlibi.Play();
        }
        
    }

    


}
