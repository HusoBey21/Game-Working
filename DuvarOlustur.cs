using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarOlustur : MonoBehaviour
{
    Camera camera;
    bool olusturma;
    public GameObject başla;
    public GameObject sonlandır;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        girdiAl();
    }
    void girdiAl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Basla();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Son();
        }
        else
        {
            if (olusturma)
            {
                ayarla();
            }
        }
    }
    void Basla()
    {
        olusturma = true; //başlatmak için etkisiz olan oluşturmayı etkinleştirdik.
        başla.transform.position = DunyaNoktasiniAl();
    }
    void Son()
    {
        olusturma = false; //sonlandırmak için etkin olan oluşturmayı etkisizleştirdik.
        sonlandır.transform.position = DunyaNoktasiniAl();
    }
    void ayarla()
    {
        sonlandır.transform.position = DunyaNoktasiniAl();
    }

    Vector3 DunyaNoktasiniAl()
    {
        Ray ışın = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit vuruş;
        if (Physics.Raycast(ışın, out vuruş))
        {
            return vuruş.point;
        }
        return Vector3.zero;
    }
}

