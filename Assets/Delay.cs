using UnityEngine;

public class Delay : MonoBehaviour
{
    public float showTime = 7f; // Detik kapan harus muncul
    public float hideTime = 10f; // Detik kapan harus disembunyikan

    void Start()
    {
        gameObject.SetActive(false); // Nonaktifkan Canvas pada awalnya
        Invoke("ShowCanvas", showTime); // Panggil method ShowCanvas setelah showTime detik
        Invoke("HideCanvas", hideTime); // Panggil method HideCanvas setelah hideTime detik
    }

    void ShowCanvas()
    {
        gameObject.SetActive(true); // Aktifkan Canvas
    }

    void HideCanvas()
    {
        gameObject.SetActive(false); // Nonaktifkan Canvas setelah hideTime detik
    }
}
