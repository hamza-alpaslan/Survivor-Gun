using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy4 : MonoBehaviour
{
    public float can = 200;
    private int oh;
    private int ow;
    private Vector3 vec;
    float angle;
    float a;
    float b;
    float þu_an;
    public Transform player;
    public float speed = 3.25f;
    public int xp = 150;
    // Update is called once per frame
    void Update()
    {
        float moveDistance = speed * Time.deltaTime;

        if (PAUSE.IsPaused == false)
        {
            transform.Translate(Vector3.left * moveDistance);
        }
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

    bool ic = false;
    //void OnCollisionEnter
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            ic = true;
        }

        if (col.gameObject.tag == "Bullet")
        {
            can = can - Bullet.hasar;
        }
        if (can <= 0)
        {
            xp_control.xp = xp_control.xp + xp;
            //Destroy(col.gameObject);

            if (ic == true)
            {
                can_bar_kontrol.icerdema = can_bar_kontrol.icerdema - 1;
            }

            Destroy(gameObject);
        }
        if (col.gameObject.tag == "sinir")
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            ic = false;
    }
}