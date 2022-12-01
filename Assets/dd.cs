using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dd : MonoBehaviour
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
            animator.SetBool("isSh", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isSh", false);
        }
        if (Input.GetKey("b"))
        {
            animator.SetBool("isB1", true);
        }
        if (!Input.GetKey("b"))
        {
            animator.SetBool("isB1", false);
        }
        if (Input.GetKey("c"))
        {
            animator.SetBool("isB", true);
        }
        if (!Input.GetKey("c"))
        {
            animator.SetBool("isB", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("isB2", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("isB2", false);
        }

        if (Input.GetKey("e"))
        {
            animator.SetBool("isCh", true);
        }
        if (!Input.GetKey("e"))
        {
            animator.SetBool("isCh", false);
        }

        if (Input.GetKey("f"))
        {
            animator.SetBool("isk", true);
        }
        if (!Input.GetKey("f"))
        {
            animator.SetBool("isk", false);
        }
        if (Input.GetKey("g"))
        {
            animator.SetBool("isc", true);
        }
        if (!Input.GetKey("g"))
        {
            animator.SetBool("isc", false);
        }
        if (Input.GetKey("h"))
        {
            animator.SetBool("isu", true);
        }
        if (!Input.GetKey("h"))
        {
            animator.SetBool("isu", false);
        }
        if (Input.GetKey("i"))
        {
            animator.SetBool("isfi", true);
        }
        if (!Input.GetKey("i"))
        {
            animator.SetBool("isfi", false);
        }

        if (Input.GetKey("j"))
        {
            animator.SetBool("isSA", true);
        }
        if (!Input.GetKey("j"))
        {
            animator.SetBool("isSA", false);
        }

        if (Input.GetKey("k"))
        {
            animator.SetBool("isjk", true);
        }
        if (!Input.GetKey("k"))
        {
            animator.SetBool("isjk", false);
        }

        if (Input.GetKey("l"))
        {
            animator.SetBool("isr", true);
        }
        if (!Input.GetKey("l"))
        {
            animator.SetBool("isr", false);
        }

        if (Input.GetKey("m"))
        {
            animator.SetBool("ise", true);
        }
        if (!Input.GetKey("m"))
        {
            animator.SetBool("ise", false);
        }





    }
    public void Quit()
    {
        SceneManager.LoadScene("1");
    }
}
