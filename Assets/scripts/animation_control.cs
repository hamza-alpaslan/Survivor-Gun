using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_control : MonoBehaviour
{
    private Animator animator;
    public bool h=false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        h = MoveForward.hareket;
        if (h == true)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

    }
}
