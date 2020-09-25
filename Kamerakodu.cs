
using UnityEngine;

public class Kamerakodu : MonoBehaviour
{
    public float suratY = 2.0f;
    public float suratD = 2.0f;

    private float sapma = 0.0f;
    private float saha = 0.0f;
    void Update()
    {
        sapma = sapma + suratY * Input.GetAxis("Mouse X");
        saha = saha + suratD * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(sapma, saha, 0.0f);

    }
}
