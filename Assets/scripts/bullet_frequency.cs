using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bullet_frequency : MonoBehaviour
{
    private const float MAX_freq = 10f;
    public static float freq = 0;
    private Image freq_bar;
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        freq_bar = GetComponent<Image>();
    }

    public void OnButtonClick()
    {
        xp_control.xp_puan = xp_control.xp_puan - 1;
        freq++;
        freq_bar.fillAmount = freq / MAX_freq;
        Gun.bulletTime = Gun.bulletTime *17/24;
        if (freq >= MAX_freq)
        {
            myButton.interactable = false;
        }
    }
}
