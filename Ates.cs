using System.Collections;

using UnityEngine;

public class Ates : MonoBehaviour
{
    public GameObject kemer;
    public Transform Canon;
    public float atesOranip;
    public float atesOranim;
    private float birsonrakiAtes = 3.0f;
    void Start()
    {
        birsonrakiAtes = Time.time + Random.Range(atesOranip, atesOranim);
    }
    void SabitlenmisGuncellenme()
    {
        if(Time.time>birsonrakiAtes)
        {
            birsonrakiAtes = Time.time + Random.Range(atesOranip, atesOranim);
            Instantiate(kemer, Canon.position, Canon.rotation);
        }
    }
}
