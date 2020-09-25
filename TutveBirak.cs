
using UnityEngine;

public class TutveBirak : MonoBehaviour
{
    GameObject tutunanNesne;
    float tutunanNesneBoyutu;
    Renderer uf;

    void Start()
    {
        uf = GetComponent<Renderer>();

    }
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(tutunanNesne==null)
            {
                NesneyiTutmayiDene(tutbirak(5.0f));
            }
            else
            {

                NesneyiBırak();
            }
            if(tutunanNesne != null)
            {
                Vector3 yeniKonum = gameObject.transform.position;
                tutunanNesne.transform.position = yeniKonum;
            }

        }

    }
    GameObject tutbirak(float menzil)
    {
        Vector3 konum = gameObject.transform.position;
        RaycastHit isinDokumuVurusu;
        Vector3 hedef = konum + Camera.main.transform.forward;
        if(Physics.Linecast(konum,hedef,out isinDokumuVurusu))
        {
            return isinDokumuVurusu.collider.gameObject;
        }
        return null;
    }
    void NesneyiTutmayiDene(GameObject nesne)
    {
        if(nesne==null)
        {
            return;
        }
        tutunanNesne = nesne;
        tutunanNesneBoyutu = uf.bounds.size.magnitude;


    }
    void NesneyiBırak()
    {
        if (tutunanNesne == null)
            return;
        if (tutunanNesne.GetComponent<Rigidbody>() != null)
            tutunanNesne.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 5.0f, 0.0f);

        tutunanNesne = null;



    }

    bool Tutunabilirmi(GameObject aday )
    {
        return aday.GetComponent<Rigidbody>() != null;
    }

}
