using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class charecter_speed_control : MonoBehaviour
{
    private const float MAX_speed = 10f;
    public static float speed = 0;
    private Image speed_bar;
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
        speed_bar = GetComponent<Image>();
    }

    public void OnButtonClick()
    {
        xp_control.xp_puan = xp_control.xp_puan - 1;
        speed++;
        speed_bar.fillAmount = speed / MAX_speed;
        MoveForward.speed = MoveForward.speed + 0.7f;
        if (speed >= MAX_speed)
        {
            myButton.interactable = false;
        }
    }
}
