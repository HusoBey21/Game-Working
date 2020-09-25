//30 Haziran 2020 Salı
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    // Start is called before the first frame update
  
    public Transform hedef;
    public float yumusak = 0.175f;
    public Vector3 koordinatlar;

    // Update is called once per frame
    void Update()
    {
        transform.position = hedef.position + koordinatlar; //Kamera birinci kişi atıcı tarzında

    }
}
