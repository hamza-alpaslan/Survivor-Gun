using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = .1f;

    private void Update()
    {
        while(Input.GetKeyDown(KeyCode.Space)) 
        transform.Translate(transform.forward * speed);
    }

}