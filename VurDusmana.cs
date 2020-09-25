//26 Haziran 2020 Cuma
//29 Haziran 2020 Pazartesi
//30 Haziran 2020 Salı
// 3 Temmuz 2020 Cuma
//4 Temmuz 2020 Cumartesi
//13 Temmuz 2020 Pazartesi
using UnityEngine;

public class VurDusmana : MonoBehaviour
{
    DusmanDurumu hasarlar;
    float hasarver = 10f;
    
    private Transform hedef;
    [SerializeField]
    private float odaklanmaUzakligi = 5f;
    Rigidbody rb;
    void Start()
    {
        hasarlar = GetComponent<DusmanDurumu>();
        hedef = GameObject.FindGameObjectWithTag("enemy").transform;
        rb = GetComponent<Rigidbody>();
       
    }
    public void FixedUpdate()
    {
        Vector3 yon = (hedef.position - transform.position);//Hedef ile füze arasındaki vektörel fark.
        yon.Normalize();//Büyüklüğü 1 birim olan vektördür.
        float donusMiktari = Vector3.Cross(yon, transform.forward).z; //Biz ileriye doğru gitmesini istiyoruz.
        rb.angularVelocity = new Vector3(0f, 0f, -5.0f * donusMiktari);
        rb.velocity = new Vector3(0f, 0f, 5.0f * Time.deltaTime);

    }
    void OnCollisionEnter(Collision carpisma) //Çarpışma durumunda gerçekleşecek.
    {
        if(carpisma.gameObject.tag=="enemy")
        {
         
            
            hasarlar.AlinanHasar(hasarver);
            Destroy(gameObject); //Füzeyi yok eder.
            Destroy(carpisma.gameObject);// Nesneyi yok eder.
        }
    }
   
}
