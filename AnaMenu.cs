//2 Temmuz 2020 Perşembe
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void oyunOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Bir sonraki sahneyi yükler.Sahneler arası geçişi sağlar.Sahne yöneticisinin uzantısıyla olur.

    }
    public void oyundanCik()
    {
        Application.Quit(); //Ana menüden çıkışı sağlıyormuş Brackeys'e göre.
    }
}
