//19 Temmuz 2020 Pazar
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, 30f * Time.deltaTime); //Sağa doğru bir dönüş olacak.
        transform.LookAt(Vector3.zero);
    }
}
