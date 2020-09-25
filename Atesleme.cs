//16 Temmuz 2020 Perşembe
//17 Temmuz 2020 Cuma
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atesleme : MonoBehaviour
{
    public GameObject fuze;
    public float surat = 20f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fuze = new GameObject("füze",typeof(Rigidbody),typeof(BoxCollider),typeof(MeshRenderer));
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {



            GameObject ornek = Instantiate(fuze, transform.position, transform.rotation) as GameObject;
            ornek.GetComponent<Rigidbody>().AddForce(Vector3.forward * surat);
            Destroy(ornek, 5f);
            
        }
    }
}
