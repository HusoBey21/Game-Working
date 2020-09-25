
using UnityEngine;

public class KullaniciDurumu : MonoBehaviour
{
    public GameObject secilenBirim;
    public DusmanDurumu dusmanDurumKodu;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DusmanSec();
        }
        if (Input.GetButtonDown("1"))
        {
            if (secilenBirim != null)
            {
                TemelSaldiri();
            }
        }
        void DusmanSec()
        {
            Ray isin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit vurus;
            if (Physics.Raycast(isin, out vurus, 10000))
            {
                if (vurus.transform.tag == "düşman")
                {
                    secilenBirim = vurus.transform.gameObject;
                    dusmanDurumKodu = secilenBirim.transform.gameObject.transform.GetComponent<DusmanDurumu>();
                }
            }
        }
        void TemelSaldiri()
        {
            dusmanDurumKodu.AlinanHasar(10);
        }
    }
}
