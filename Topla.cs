//30 Haziran 2020 Salı
// 1 Temmuz 2020 Çarşamba
using UnityEngine;

public class Topla : MonoBehaviour
{
    float firlatmaGucu = 800f; //Fırlatma gücünü belirledik.
    Vector3 nesneKonumu; //Bu nesnenin konumunu belirleyecek.
    float uzaklik;
    public bool tasinabilirMi = true; //Taşınır mı taşınmaz mı onu belirledik.
    public GameObject madde; //Taşınacak madde burada belirlenecek.
    public GameObject gecici; //Üst seviyedeki nesne belirlenir.
    public bool tasiniyorMu = false; //Taşınırlığını belirledik.
    void Update() //Türkçesi güncelleme olan fonksiyondur.
    {
        uzaklik = Vector3.Distance(madde.transform.position, gecici.transform.position); //Aralarındaki uzaklığı hesaplamaktayız.
        if(uzaklik >= 1f)
        {
            tasiniyorMu = false; //Eğer aralarındaki uzaklık 1f'ten çoksa taşınma özelliği taşımayacak.
        }
        if(tasiniyorMu==true)
        {
            madde.GetComponent<Rigidbody>().velocity = Vector3.zero;  //Her eksende hız orijin konumuna getirildi.
            madde.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; //Açısal hız da (0,0,0) konumunda.
            madde.transform.SetParent(gecici.transform); //Üst seviyeye taşınır.
            if(Input.GetMouseButtonDown(1)) //Farenin sağ tıkına atama yapılıyor.
            {
                //Fırlatma
                madde.GetComponent<Rigidbody>().AddForce(gecici.transform.forward * firlatmaGucu); //Maddeye uygulanan kuvveti belirler.
                tasiniyorMu = false;
            }
        }
        else
        {
            nesneKonumu = madde.transform.position;  //Nesnenin konum bilgisini atamış olduk.Koordinatlar olarak atama yaptık.
            madde.transform.SetParent(null); //Üst nesne ataması yok edildi.
            madde.GetComponent<Rigidbody>().useGravity = true; //Yerçekimini yeniden devreye soktuk.Bu yorum satırları gerçekten anlamama yardımcı olacak.
            madde.transform.position = nesneKonumu;  //Nesnenin önceki konumunu korumak adına böyle bir işlem yapıldı.
        }
    }
    void OnMouseDown() //Fare ile hareketi sağlayacak ancak benim bilgisayara bağlı bir farem yok.Farenin tekerini aşağıya indirdiğimizde bunlar sağlanacak.
    {
        if (uzaklik <= 1f)
        {
            tasiniyorMu = true;
            madde.GetComponent<Rigidbody>().useGravity = false;       //Oyun fiziğinin yerçekimi eklentisini kapatmış bulunuyoruz.
            madde.GetComponent<Rigidbody>().detectCollisions = true; //Burada herhangi bir çarpışma yaşandığını saptıyoruz.
        }
    }
    void OnMouseUp()
    {
        tasiniyorMu = false;

    }
    
}
