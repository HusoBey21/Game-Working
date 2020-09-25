
using UnityEngine;

public class SilahIlistir : MonoBehaviour
{ //Silah Oyun Nesnesi tutucu silahı atamak için kullanıldı.
    public GameObject AnaSilahIlistirmesi;
    public GameObject SilahYarigi1;
    Animator anim;
    void Start()
    { //Sonradan kullanabilmek için canlandırıcı bileşeni yerleştirildi.
        anim = GetComponent<Animator>();
        //Eğer silah varsa kontrol edilir ve başlangıç konumu yerleştirilir.
        if (AnaSilahIlistirmesi == null)
        {// Silahın bir örneği oluşturulur ve boş durumda yerleştirilir.
            SilahYarigi1 = Instantiate(AnaSilahIlistirmesi, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            //İstenen silah iliştirilir.
            SilahYarigi1.transform.parent = GameObject.Find("rifle").transform;
            //Konum belirlenir.
            SilahYarigi1.transform.localPosition = new Vector3(2.0f, 2.0f, 2.0f);
            //Dönme belirlenir.
            SilahYarigi1.transform.localEulerAngles = new Vector3(2.0f, 2.0f, 2.0f);
        }
        void Update()
        {
            SilahDurumunuGuncelle();
        }
        void SilahDurumunuGuncelle()
        {
            // Eğer anlık durum boş ise takip edilen kodu yürüt.
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                //İstenen silah iliştirilir.
                SilahYarigi1.transform.parent = GameObject.Find("knife").transform;
                //Konum belirlenir.
                SilahYarigi1.transform.localPosition = new Vector3(2.0f, 2.0f, 2.0f);
                //Dönme belirlenir.
                SilahYarigi1.transform.localEulerAngles = new Vector3(2.0f, 2.0f, 2.0f);
            }
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Running"))
            {
                SilahYarigi1.transform.parent = GameObject.Find("rifle").transform;
                //Konum belirlenir.
                SilahYarigi1.transform.localPosition = new Vector3(2.0f, 2.0f, 2.0f);
                //Dönme belirlenir.
                SilahYarigi1.transform.localEulerAngles = new Vector3(2.0f, 2.0f, 2.0f);
            }
        }



    }
}
