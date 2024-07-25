using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    private int oh;
    private int ow;
    private Vector3 vec;
    float angle;
    float a;
    float b;
    float þu_an;
    // Update is called once per frame
    void Update()
    {
        if (PAUSE.IsPaused == false) { 
            Vector3 mousePos = Input.mousePosition;
            ow = Screen.width / 2;
            oh = Screen.height / 2;
            if ((mousePos.x >= 0) && (mousePos.y >= 0) && ((Screen.width - mousePos.x) >= 0) && ((Screen.height - mousePos.y) >= 0))
            {
                a = (ow - mousePos.x);
                b = (oh - mousePos.y);
                if (a == 0 && b == 0)
                {

                }
                else if (a < 0)
                {
                    transform.Rotate(0, 90, 0);

                    þu_an = transform.localEulerAngles.y;

                    angle = -(float)(Mathf.Atan(b / a) * 180 / 3.14);
                    transform.Rotate(0, (-þu_an + angle+90), 0);
                }
                else if (a > 0)
                {
                    transform.Rotate(0, 90, 0);

                    þu_an = transform.localEulerAngles.y;

                    angle = -(float)(Mathf.Atan(b / a) * 180 / 3.14);
                    transform.Rotate(0, 180 + (-þu_an + angle+90), 0);
                }
            }

        }
    }
}