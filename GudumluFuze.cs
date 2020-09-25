//3 Temmuz 2020 Cuma 
using UnityEngine;

public class GudumluFuze : MonoBehaviour
{
    public Transform hedef;//Hedef düşman olacak.Böylelikle düşman hasar almış olacak.
    private Rigidbody rb; //Fizik ekledik.Bu füzenin hareketini sağlayacak.
    public float surat = 5f;
    public float donusSurati = 200f; //200f lik bir açısal hız belirlendi.
    public GameObject patlamaEtkisi; //Bu oyun nesnesi isabet ettiğinde patlama etkisi verecek.
    public UnityEngine.AI.NavMeshAgent vur;
    void Start()
    {
        hedef = GameObject.FindWithTag("enemy").transform; //enemy etiketi olan herhangi bir nesneyi alacak.
        rb = GetComponent<Rigidbody>(); //Fizik ilklendirmesi yapıldı.
        vur = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }
    void FixedUpdate()
    {
        vur.SetDestination(hedef.position);
        ;
    }
    void OnTriggerEnter()
    {
        Instantiate(patlamaEtkisi, transform.position, transform.rotation); //Bu patlama etkisinin çoğalmasına neden olacak.
        Destroy(gameObject);//Hedef otyun nesnesinin yok edilmesini sağlayacaktır.
    }
    
}
