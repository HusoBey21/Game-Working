//24 Haziran 2020 Çarşamba
//28 Haziran 2020 Pazar Güncellenme Tarihi
//30 Haziran 2020 Salı İkinci Güncellenme Tarihi
using UnityEngine;
using UnityEngine.UI;


public class Zip : MonoBehaviour
{
    public float ziplama = 3.0f;
    public bool zemindeMi = true;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Hareket fiziğini oluşturduk
    }
   void OnCollisionEnter(Collision carpisma)
    {
        if(carpisma.gameObject.tag == "Zemin")
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0f, ziplama, 0f); //Eğer zemin üzerinde ise zıpla.
            }
        }
    }


}