//3 Temmuz 2020 Cuma
//Nişan alma işlemini zaten 3 Temmuzda gerçekleştirmişiz.
//12 Temmuz 2020 Pazar yeniden düzenleme
using UnityEngine;

public class Nisan : MonoBehaviour
{
    
    public Vector3 yon;
    public Vector3 yonelim;
    
    void Update()
    {
        if(Input.GetMouseButtonDown(1)) //Farenin orta düğmesi hedefe yarayacak.
        {
            transform.position = Vector3.Slerp(transform.position,yon,10*Time.deltaTime); //Bu hedef alınan nesnenin konumunu verir.

        }
        if(Input.GetMouseButtonUp(1))
        {
            transform.position = yonelim;
        }
    }
}
