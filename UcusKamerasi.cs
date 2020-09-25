using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UcusKamerasi : MonoBehaviour
{
    public float hareketSurati;
    public float yukseklik; //Açının yerden olan yüksekliği
    public bool arazziIzle; //Bu üzerinde bulunan arazinin izlenmesini sağlar.
    public bool otoUcus; //Bu da otomatik uçuş sağlamaktadır.
    private float XDuyarliligi = 0.5f; //X ekseni üzerindeki duyarlılık.
    private void Update()
    {
        float XDonusu = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * XDuyarliligi; //Bu bakış açısının dönüşünü sağlar.
        transform.localEulerAngles = new Vector3(0f, XDonusu,0f); //Fare y ekseni çevresinde yukarı ve aşağı yönde dönme hareketini yapacaktır.
        //Klavye hareketi
        Vector3 hareketVektoru = Input.GetAxis("Vertical") * transform.forward + Input.GetAxis("Horizontal") * transform.right; //Bu da oyuncunun hareketi doğrultusunda konumunu değiştirecek.
        //Oto Uçuş
        if(otoUcus)
        {
            if(hareketVektoru.magnitude>0)
            {
                otoUcus = false; //Hareket vektörünün büyüklüğü sıfırdan büyük olduğu durumda otomatik uçuş devre dışı sayılıyor.
            }
            hareketVektoru = transform.forward; //Hareket vektörüne ileri yönde bir hareket vektörü atadık.
        }
        transform.Translate(hareketVektoru * hareketSurati * Time.deltaTime, Space.World); //Bu kameranın da harekete maruz kalması demek.
        Vector3 konum = transform.position; //Şu anki konumu temsil eder.Yorum satırı candır.
        konum.y = yukseklik;
        if(arazziIzle)
        {
            RaycastHit VurusBilgisi;
            Physics.Raycast(new Vector3(transform.position.x, 100f, transform.position.z), -Vector3.up, out VurusBilgisi, 100f); //Bu belirtilen ışının doğruluğunu kanıtlamak için kullanılır.
            konum.y = VurusBilgisi.point.y + yukseklik;

        }
        transform.position = konum; //Konum noktasının y eksenindeki değerini güncelledikten sonra mevcut konuma atama yaptık.
    }

}
