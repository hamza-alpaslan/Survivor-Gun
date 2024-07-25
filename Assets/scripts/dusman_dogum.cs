using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_dogum : MonoBehaviour
{
    int randomSayi;
    public Transform enemySpawnPoint;
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemyPrefab4;
    public GameObject enemyPrefab5;
    public GameObject enemyPrefab6;
    public GameObject enemyPrefab7;
    public GameObject enemyPrefab8;
    private float _currentTime;
    float sayac = 0f;
    float sayac2 = 0f;
    float sayac3 = 0f;
    float sayac4 = 0f;
    float sayac5 = 0f;
    float sayac6 = 0f;
    float sayac7 = 0f;
    float sayac8 = 0f;
    public static float spawnTime = 5f;
    public static float spawnTime2 = 90f;
    public static float spawnTime3 = 150f;
    public static float spawnTime4 = 300f;
    public static float spawnTime5 = 350f;
    public static float spawnTime6 = 480f;
    public static float spawnTime7 = 520;
    public static float spawnTime8 = 560;
    public static bool mermili_boss =false;
    bool degis =false;
    void Start()
    {

        StartCoroutine(CountdownTime());
    }
    public static void set_mermili_boss(bool b)
    {
        mermili_boss = b;
    }
    public static void set_spawn_time(float a)
    {
            spawnTime = a;
    }

    public static void set_spawn_time2(float a2)
    {   
        spawnTime2 = a2;
    }
    public static void set_spawn_time3(float a3)
    {
        spawnTime3 = a3;
    }
    public static void set_spawn_time4(float a4)
    {
        spawnTime4 = a4;
    }
    public static void set_spawn_time5(float a5)
    {
        spawnTime5 = a5;
    }
    public static void set_spawn_time6(float a6)
    {
        spawnTime6 = a6;
    }
    public static void set_spawn_time7(float a7)
    {
        spawnTime7 = a7;
    }
    public static void set_spawn_time8(float a8)
    {
        spawnTime8 = a8;
    }
    private IEnumerator CountdownTime()
    {
        
        while (true)
        {
            sayac=sayac+1f;
            sayac2 = sayac2 + 1f;
            sayac3 = sayac3 + 1f;
            sayac4 = sayac4 + 1f;
            sayac5 = sayac5 + 1f;
            sayac6 = sayac6 + 1f;
            sayac7 = sayac7 + 1f;
            sayac8 = sayac8 + 1f;
            randomSayi = Random.Range(0, 10);
            if(spawnTime == 1f)
            {
                GameObject enemy = Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (spawnTime2 == 1f)
            {
                GameObject enemy2 = Instantiate(enemyPrefab2, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (spawnTime6 == 1f && randomSayi>4)
            {
                GameObject enemy6 = Instantiate(enemyPrefab6, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            else if(sayac>spawnTime && randomSayi== 1)
            {
                sayac = 0f;
                GameObject enemy = Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (sayac2 > spawnTime2 && randomSayi == 2)
            {
                sayac2 = 0;
                GameObject enemy2 = Instantiate(enemyPrefab2, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (sayac3 > spawnTime3 && randomSayi >5)
            {
                sayac3 = 0;
                GameObject enemy3 = Instantiate(enemyPrefab3, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (sayac4 > spawnTime4 && randomSayi ==3)
            {
                sayac4 = 0;
                GameObject enemy4 = Instantiate(enemyPrefab4, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (sayac5 > spawnTime5 && randomSayi == 4)
            {
                sayac5 = 0;
                GameObject enemy5 = Instantiate(enemyPrefab5, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (sayac6 > spawnTime6 && randomSayi == 4)
            {
                sayac6 = 0;
                GameObject enemy6 = Instantiate(enemyPrefab6, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if(dalga.get_bos()==true && randomSayi==5)
            {
                GameObject enemy6 = Instantiate(enemyPrefab6, enemySpawnPoint.position, enemySpawnPoint.rotation);
                dalga.set_bos(false);
            }
            if (degis == true)
            {
                mermili_boss = false;
            }
            if (mermili_boss ==true)
            {
                GameObject enemy7 = Instantiate(enemyPrefab7, enemySpawnPoint.position, enemySpawnPoint.rotation);
                degis = true;
                
            }
            if (sayac8 > spawnTime8 && randomSayi == 8)
            {
                sayac8 = 0;
                GameObject enemy8 = Instantiate(enemyPrefab8, enemySpawnPoint.position, enemySpawnPoint.rotation);
            }
            if (dalga.get_son_bos() == true && randomSayi == 8)
            {
                GameObject enemy8 = Instantiate(enemyPrefab8, enemySpawnPoint.position, enemySpawnPoint.rotation);
                dalga.set_son_bos(false);
            }
            yield return new WaitForSeconds(1f);

        }
        yield return null;
    }
}
