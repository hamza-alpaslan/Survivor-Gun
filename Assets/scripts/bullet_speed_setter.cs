using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet_speed_setter : MonoBehaviour
{
    private const float MAX_speed = 10f;
    public static float speed = 0;
    private Image speedBar;
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        speedBar = GetComponent<Image>();
    }

    public void OnButtonClick()
    {
        xp_control.xp_puan = xp_control.xp_puan - 1;
        speed++;
        speedBar.fillAmount = speed / MAX_speed;
        Gun.bulletSpeed = Gun.bulletSpeed + 3;
        if (speed >= MAX_speed)
        {
            myButton.interactable = false;
        }
    }
}
