using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour
{
    public float life = 4;
    
    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnTriggerEnter(Collider Collider)
    {
        if ( Collider.gameObject.tag != "enemy")
            Destroy(gameObject);
        
    }
}