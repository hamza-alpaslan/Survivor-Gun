using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class can_bar_kontrol : MonoBehaviour
{
    private static float gecenSure = 0f;
    float can = 100f;
    public static int icerdema=0;
    float kontrol = 0.5f;
    public GameObject deathMenu;
    // Start is called before the first frame update
    void Start()
    {
        deathMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gecenSure += Time.deltaTime;
        if(gecenSure > kontrol)
        {
            kontrol = kontrol + 0.2f;
            can = can - icerdema;

        }
        HealtBar.health = can;
        if (can <= 0)
        {
            icerdema = 0;
            Time.timeScale = 0f;
            PAUSE.IsPaused = true;
            deathMenu.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "enemy"|| col.gameObject.tag == "enemy2")
        {
            icerdema = icerdema+1;
            can = can - 10;
        }
        HealtBar.health = can;
        if (col.gameObject.tag == "enemyBullet")
        {
            can= can-5;
        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other ==null)
        {
            icerdema = 0;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "enemy" || col.gameObject.tag == "enemy2")
        {
            icerdema = icerdema-1;
        }
    }
}
