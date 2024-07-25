using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dalga : MonoBehaviour
{
    public GameObject winnMenu;
    public static float gecenSure = 0f;
    public static float sayac = 0f;
    private static float sure = 6f;
    public static float a = 20f;
    private static float sure2 = 90f;
    public static float a2 = 20f;
    private static float sure3 = 150f;
    public static float a3 = 1f;
    private static float sure4 = 300f;
    public static float a4 = 20;
    private static float sure5 = 350f;
    public static float a5 = 20;
    private static float sure6 = 465f;
    public static float a6 = 40;
    private static float sure7 = 520f;
    public static float a7 = 20;
    private static float sure8 = 520f;
    public static float a8 = 10;
    public  static bool boss=false;
    public static bool son_boss = false;
    public Text sure_text;
    public int saniye=0;
    public int dakika=0;
    public string sn;
    public string dk;

    public static void set_bos(bool b)
    {
        boss = b;
    }
    public static bool get_bos() {  return boss; }
    public static void set_son_bos(bool bo)
    {
        son_boss = bo;
    }
    public static bool get_son_bos() { return son_boss; }
    void Start()
    {
        winnMenu.SetActive(false);
        saniye = 0;
        dakika= 0;
        gecenSure = 0f;
        Time.timeScale = 1f;
    }
    void Update()
    {
        // Her frame'de geçen süreyi güncelle
        gecenSure += Time.deltaTime;
        saniye = (int)sayac % 60;
        dakika = (int)(sayac / 60);
        if (saniye < 10) sn = "0" + saniye;
        else sn = "" + saniye;
        if (dakika < 10) dk = "0" + dakika;
        else dk = "" + dakika;
        
        sure_text.text = dk+":"+sn;
        // Her saniye olduðunda console'a yazdýr ve sayaçý sýfýrla
        if (gecenSure >= 1f)
        {
            sayac++;
            Debug.Log("Geçen Süre (saniye): " + sayac);
            Debug.Log("düþman doðum sýklýðý 1 " + a);
            Debug.Log("düþman doðum sýklýðý 2 " + a2);
            gecenSure = 0f;
            if (sayac >sure)
            {
                
                sure = sure + 15;
                if (sayac < 60)
                {
                    a = a - (a / 5);
                }
                if(sayac > 60)
                {
                    a=a+ (a / 2);
                }
                
                if (a < 1f) a = 1f;
                if(a>40f) a = 40f;
                dusman_dogum.set_spawn_time(a);
            }
            if (sayac > sure2)
            {
                sure2 = sure2 + 15;
                if (sayac < 150)
                {
                    a2 = a2 - (a2 / 5);
                }
                if (sayac > 150)
                {
                    a2 = a2 + (a2 / 2);
                }

                if (a2 < 1f) a2 = 1f;
                if (a2 > 40f) a2 = 50f;
                dusman_dogum.set_spawn_time2(a2);
            }
            if (sayac == 190)
            {
                sure = 10000f;
                sure2 = 10000f;
                dusman_dogum.set_spawn_time(10000f);
                dusman_dogum.set_spawn_time2(10000f);

            }
            if (sayac > sure3 && sayac<220)
            {
                dusman_dogum.set_spawn_time3(1f);
            }
            if( sayac == 240)
            {
                dusman_dogum.set_spawn_time3(10000f);
                dusman_dogum.set_spawn_time(1f);
            }
            else if(sayac == 265)
            {
                sure = 10000f;
                sure2 = 10000f;
                dusman_dogum.set_spawn_time(10000f);
                dusman_dogum.set_spawn_time2(10000f);
            }
            if (sayac > sure4)
            {
                sure4 = sure4 + 15;
                if (sayac < 320)
                {
                    a4 = a4 - (a4 / 7);
                }
                if (sayac > 320)
                {
                    a4 = a4 + (a4 / 2);
                }

                if (a4 < 1f) a4 = 1f;
                if (a4 > 40f) a4 = 50f;
                dusman_dogum.set_spawn_time4(a4);
            }
            if(sayac == 330)
            {
                sure4 = 10000f;
                
                dusman_dogum.set_spawn_time4(10000f);
            }
            if (sayac > sure5)
            {
                sure5 = sure5 + 15;
                if (sayac < 380)
                {
                    a5 = a5 - (a5 / 7);
                }
                if (sayac > 380)
                {
                    a5 = a5 + (a5 / 2);
                }

                if (a5 < 1f) a5 = 1f;
                if (a5 > 50f) a5 = 50f;
                dusman_dogum.set_spawn_time5(a5);
            }
            if (sayac == 400)
            {
                sure5 = 10000f;
                dusman_dogum.set_spawn_time5(1000f);
                boss = true;
            }
            if (sayac ==420) {
                dusman_dogum.set_spawn_time2(1f);
            }
            if(sayac == 440)
            {
                sure2 = 100000f;
                dusman_dogum.set_spawn_time2(10000f);
            }
            if (sayac > sure6)
            {
                sure6 = sure6+ 5;
                if (sayac < 500)
                {
                    a6 = a6 - (a6 / 7);
                }
                if (sayac > 500)
                {
                    a6 = a6 + (a6 / 2);
                }

                if (a6 < 1f) a6 = 1f;
                if (a6 > 50f) a6 = 50f;
                dusman_dogum.set_spawn_time6(a6);
            }
            if (sayac == 510)
            {
                dusman_dogum.set_spawn_time6(10000f);
                sure6 = 10000f;
            }
            if((sayac == 520))
            {
                dusman_dogum.set_mermili_boss(true);
                
            }
            if((sayac == 530))
            {
                son_boss = true;
            }
            if((sayac == 550))
            {
                dusman_dogum.set_spawn_time6(1f);
            }
            if ((sayac == 560))
            {
                dusman_dogum.set_spawn_time6(10000f);
            }
            if (sayac > 570)
            {
                a8 = a8 - (a8 / 2);
                if (a8 < 1f) a8 = 1f;
                dusman_dogum.set_spawn_time8(a8);
                
            }
            if(sayac == 600)
            {
                PAUSE.IsPaused = true;
                Time.timeScale = 0f;
                winnMenu.SetActive(true);
                
            }
        }
    }
}
