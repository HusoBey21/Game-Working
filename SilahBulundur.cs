using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilahBulundur : MonoBehaviour
{
    public GameObject madde1;
    public GameObject madde2;
    public bool gosterMadde1 = false;
    public bool gosterMadde2 = false;
    void Update()
    {
        if(gosterMadde1==false)
        {
            madde1.SetActive(false); //Bu maddelerin etkinliğini yansıtır.
        }
        if(gosterMadde1==true)
        {
            madde1.SetActive(true);
        }
        if(gosterMadde2==false)
        {
            madde2.SetActive(false);
        }
        if(gosterMadde2==true)
        {
            madde2.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha1) && gosterMadde1==false)
        {
            gosterMadde1 = true;
            gosterMadde2 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && gosterMadde2 == false)
        {
            gosterMadde1 = false;
            gosterMadde2 = true;
        }
        if(Input.GetKey(KeyCode.R))
        {
            gosterMadde1 = false;
            gosterMadde2 = false;    //Her ikisi de devre dışı olacak.
        }
    }

}
