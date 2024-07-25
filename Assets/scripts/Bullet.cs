using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 6;
    public float del=0;
    public static float hasar=1;
    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnTriggerEnter(Collider Collider)
    {
        if (del <= 0 && Collider.gameObject.tag != "Bullet")
            Destroy(gameObject);
        else del = del - 1;
    }
}
