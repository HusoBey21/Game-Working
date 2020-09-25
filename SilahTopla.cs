
using UnityEngine;

public class SilahTopla : MonoBehaviour
{
    public GameObject benimSilahim;
    public GameObject zemindekiSilah;
    void Start()
    {
        benimSilahim.SetActive(false);

    }

    void TetikleyiciGirisi(Collider carpisan)
    { 
        if(carpisan.gameObject.tag=="Player")
        {
            benimSilahim.SetActive(true);
            zemindekiSilah.SetActive(false);
        }
    }
}
