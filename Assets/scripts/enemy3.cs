using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    public float can = 50;
    private int oh;
    private int ow;
    private Vector3 vec;
    float angle;
    float a;
    float b;
    float þu_an;
    public Transform player;
    public float speed = 0.00f;
    public int xp = 30;
    // Update is called once per frame


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