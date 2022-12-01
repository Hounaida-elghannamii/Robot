using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JJ : MonoBehaviour
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
            animator.SetBool("isW", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isW", false);
        }
        if (Input.GetKey("b"))
        {
            animator.SetBool("isL", true);
        }
        if (!Input.GetKey("b"))
        {
            animator.SetBool("isL", false);
        }
        if (Input.GetKey("c"))
        {
            animator.SetBool("isR", true);
        }
        if (!Input.GetKey("c"))
        {
            animator.SetBool("isR", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("isJ", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("isJ", false);
        }
        if (Input.GetKey("e"))
        {
            animator.SetBool("isD", true);
        }
        if (!Input.GetKey("e"))
        {
            animator.SetBool("isD", false);
        }
        if (Input.GetKey("f"))
        {
            animator.SetBool("isP", true);
        }
        if (!Input.GetKey("f"))
        {
            animator.SetBool("isP", false);
        }
        if (Input.GetKey("g"))
        {
            animator.SetBool("isLa", true);
        }
        if (!Input.GetKey("g"))
        {
            animator.SetBool("isLa", false);
        }
    }
    public void Quit()
    {
        SceneManager.LoadScene("1");
    }

}
