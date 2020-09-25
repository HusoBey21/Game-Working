//21 Mayıs 2020 Perşembe
//15 Temmuz 2020 Çarşamba
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuru : MonoBehaviour
{
    public float surat = 20000000f;
    

    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * surat * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * surat * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * surat * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey("down"))
        {
            transform.Translate(Vector3.back * surat * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.down* -surat * Time.deltaTime);
        }
      
    }

}
