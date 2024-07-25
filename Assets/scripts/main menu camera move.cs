using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenucameramove : MonoBehaviour
{
    private int oh;
    private int ow;
    private Vector3 vec;
    float angle;
    float a;
    float b;
    float þu_an;
    public Transform player;
    public float speed = 0.025f;
    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
        a = (transform.localPosition.x - player.transform.localPosition.x);
        b = (transform.localPosition.z - player.transform.localPosition.z);
        if (a < 0)
        {
            transform.Rotate(0, 90, 0);

            þu_an = transform.localEulerAngles.y;

            angle = -(float)(Mathf.Atan(b / a) * 180 / 3.14);
            transform.Rotate(0, 180 + (-þu_an + angle), 0);
        }
        else if (a == 0)
        {
            a = 1;
        }
        else
        {
            transform.Rotate(0, 90, 0);

            þu_an = transform.localEulerAngles.y;

            angle = -(float)(Mathf.Atan(b / a) * 180 / 3.14);
            transform.Rotate(0, (-þu_an + angle), 0);
        }

    }
}
