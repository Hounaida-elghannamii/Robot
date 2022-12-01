using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sl : MonoBehaviour
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
            animator.SetBool("isAr", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isAr", false);
        }
        if (Input.GetKey("b"))
        {
            animator.SetBool("isK", true);
        }
        if (!Input.GetKey("b"))
        {
            animator.SetBool("isK", false);
        }
        if (Input.GetKey("c"))
        {
            animator.SetBool("isM", true);
        }
        if (!Input.GetKey("c"))
        {
            animator.SetBool("isM", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("isSu", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("isSu", false);
        }
        if (Input.GetKey("e"))
        {
            animator.SetBool("isUn", true);
        }
        if (!Input.GetKey("e"))
        {
            animator.SetBool("isUn", false);
        }
        if (Input.GetKey("f"))
        {
            animator.SetBool("isPu", true);
        }
        if (!Input.GetKey("f"))
        {
            animator.SetBool("isPu", false);
        }
        if (Input.GetKey("g"))
        {
            animator.SetBool("isFig", true);
        }
        if (!Input.GetKey("g"))
        {
            animator.SetBool("isFig", false);
        }
    }
    public void Quit()
    {
        SceneManager.LoadScene("1");
    }


}
