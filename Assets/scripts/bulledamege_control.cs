using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bulledamege_control : MonoBehaviour
{
    private const float MAX_damege = 10f;
    public static float damege = 0;
    private Image damege_bar;
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        damege_bar = GetComponent<Image>();
    }

    public void OnButtonClick()
    {
        xp_control.xp_puan = xp_control.xp_puan - 1;
        damege++;
        damege_bar.fillAmount = damege / MAX_damege;
        Bullet.hasar = Bullet.hasar+1;
        if (damege >= MAX_damege)
        {
            myButton.interactable = false;
        }
    }
}
