using UnityEngine;
public class MoveForward : MonoBehaviour
{
    public static float speed = 7f; // Karakterin hareket hızı
    static public bool hareket = false;

    private void Start()
    {
        speed = 5f;
    }

    private void Update()
    {
        if (!PAUSE.IsPaused)
        {
            float moveDistance = speed * Time.deltaTime; // Zaman bağımlı hareket hesaplama

            // İleri hareket
            if (Input.GetKey(KeyCode.W))
            {
                hareket = true;
                transform.Translate(Vector3.forward * moveDistance);
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Vector3.right * moveDistance);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-Vector3.right * moveDistance);
                }
            }

            // Geri hareket
            else if (Input.GetKey(KeyCode.S))
            {
                hareket = true;
                transform.Translate(-Vector3.forward * moveDistance);
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Vector3.right * moveDistance);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-Vector3.right * moveDistance);
                }
            }

            // Sağa hareket
            else if (Input.GetKey(KeyCode.D))
            {
                hareket = true;
                transform.Translate(Vector3.right * moveDistance);
                if (Input.GetKey(KeyCode.W))
                {
                    transform.Translate(Vector3.forward * moveDistance);
                }

                // Geri hareket
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(-Vector3.forward * moveDistance);
                }
            }

            // Sola hareket
            else if (Input.GetKey(KeyCode.A))
            {
                hareket = true;
                transform.Translate(-Vector3.right * moveDistance);
                if (Input.GetKey(KeyCode.W))
                {
                    transform.Translate(Vector3.forward * moveDistance);
                }

                // Geri hareket
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(-Vector3.forward * moveDistance);
                }
            }
            else
            {
                hareket = false;
            }
        }
    }
}
