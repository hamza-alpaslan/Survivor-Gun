using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_control : MonoBehaviour
{
    private Light pointLight;
    private float timer = 0f;
    private bool isLightOn = false;

    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f) // 1 saniye dolunca
        {
            isLightOn = !isLightOn; // Durumu tersine çevir (açýksa kapat, kapalýysa aç)
            pointLight.enabled = isLightOn; // Iþýðý aç veya kapat
            timer = 0f; // Zamanlayýcýyý sýfýrla
        }
    }
}
