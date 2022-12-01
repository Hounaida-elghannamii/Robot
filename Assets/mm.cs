using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mm : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            animator.SetBool("isClean", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isClean", false);
        }
        if (Input.GetKey("b"))
        {
            animator.SetBool("isGolf", true);
        }
        if (!Input.GetKey("b"))
        {
            animator.SetBool("isGolf", false);
        }
        if (Input.GetKey("c"))
        {
            animator.SetBool("isKoll", true);
        }
        if (!Input.GetKey("c"))
        {
            animator.SetBool("isKoll", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("isSn", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("isSn", false);
        }
        if (Input.GetKey("e"))
        {
            animator.SetBool("isFoot", true);
        }
        if (!Input.GetKey("e"))
        {
            animator.SetBool("isFoot", false);
        }
        if (Input.GetKey("f"))
        {
            animator.SetBool("isJ", true);
        }
        if (!Input.GetKey("f"))
        {
            animator.SetBool("isJ", false);
        }
        if (Input.GetKey("g"))
        {
            animator.SetBool("isCir", true);
        }
        if (!Input.GetKey("g"))
        {
            animator.SetBool("isCir", false);
        }
        if (Input.GetKey("h"))
        {
            animator.SetBool("isBc", true);
        }
        if (!Input.GetKey("h"))
        {
            animator.SetBool("isBc", false);
        }
        if (Input.GetKey("i"))
        {
            animator.SetBool("isP", true);
        }
        if (!Input.GetKey("i"))
        {
            animator.SetBool("isP", false);
        }
        


    }
    public void Quit()
    {
        SceneManager.LoadScene("1");
    }


}

