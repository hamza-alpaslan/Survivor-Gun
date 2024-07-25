using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaking : MonoBehaviour
{
    public float moveSpeed = 2f; // Küpün hareket hýzý

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Random.Range(-1f, 1f);
        float verticalMovement = Random.Range(-1f, 1f);

        // Yeni pozisyonu belirle
        Vector3 newPosition = transform.position + new Vector3(horizontalMovement, verticalMovement, 0f) * moveSpeed * Time.deltaTime;

        // Yeni pozisyonu uygula
        transform.position = newPosition;
    }
}
