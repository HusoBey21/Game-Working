using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atis : MonoBehaviour
{
    public GameObject mermi;
    public float surat = 20f;
    public GameObject hedef;
    void Start()
    {
        mermi = new GameObject("mermi", typeof(Rigidbody), typeof(BoxCollider), typeof(MeshRenderer));
        hedef = GameObject.FindGameObjectWithTag("Player"); //Etiketi player olan her şey hedefimiz.
    }
    void Atesle()
    {
        StartCoroutine(Aralik());
    }
    IEnumerator Aralik()
    {
        yield return new WaitForSeconds(3f);
        Vector3 yon = (hedef.transform.position - transform.position); //Bu hedef ile bulunan konum arasındaki uzaklığın vektörel ifadesi
        Quaternion yonelim = Quaternion.LookRotation(yon, Vector3.forward);  //Bu da mermi yönelimi
        if (mermi)
        {
            GameObject mermiler = Instantiate(mermi, transform.position, Quaternion.identity) as GameObject; //Merminin üretilmesi.

            mermiler.transform.rotation = yonelim;
            Destroy(mermiler, 3f);
        }
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            Atesle();
        }
    }

}
