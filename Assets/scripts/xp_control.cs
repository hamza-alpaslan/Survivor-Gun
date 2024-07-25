using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xp_control : MonoBehaviour
{
    public float seviye_carpaný = 1.7f;
    // Start is called before the first frame update
    public static  float MAX_XP = 10f;
    public static float xp = 0;
    private Image healthBar;
    public Text myText;
    public Text xp_text;
    public Text Canvas_text;
    public Button myButton;
    public Button myButton2;
    public Button myButton3;
    public Button myButton4;
    public static int xp_puan=1;
    public Canvas canvasToDisable;
    bool canvas = false;
    int level;
    bool show_canvas = true;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {

        if (xp<MAX_XP)
        healthBar.fillAmount = xp / MAX_XP;
        else
        {
            xp_puan++;
            level++;
            xp = xp-MAX_XP;
            MAX_XP = MAX_XP * seviye_carpaný;
            myText.text = "LEVEL"+level;
            if(bullet_frequency.freq <10)
            myButton.interactable = true;
            if(bullet_speed_setter.speed<10)
            myButton2.interactable = true;
            if(bulledamege_control.damege<10)
            myButton3.interactable = true;
            if(charecter_speed_control.speed<10)
            myButton4.interactable = true;

        }
        if(xp_puan <= 0)
        {
            myButton.interactable = false;
            myButton2.interactable = false;
            myButton3.interactable = false;
            myButton4.interactable = false;
        }
        xp_text.text = xp_puan + "";
    }
    public void OnButtonPress()
    {
        if (show_canvas == true)
        {
            show_canvas = false;
            canvasToDisable.enabled = false;
            Canvas_text.text = ">";
        }
        else{
            show_canvas= true;
            canvasToDisable.enabled = true;
            Canvas_text.text = "<";
        }
    }
}
