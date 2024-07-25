using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public static float bulletSpeed = 2f;
    public static float bulletTime = 2f;
    private float _currentTime;
    void Start()
    {

        StartCoroutine(CountdownTime());
    }

    private IEnumerator CountdownTime()
    {
        while (true)
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;

            yield return new WaitForSeconds((float)bulletTime);
        }
        yield return null;
    }
}
