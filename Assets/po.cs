using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class po : MonoBehaviour
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
            animator.SetBool("isa", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isa", false);
        }
        if (Input.GetKey("b"))
        {
            animator.SetBool("isb", true);
        }
        if (!Input.GetKey("b"))
        {
            animator.SetBool("isb", false);
        }
        if (Input.GetKey("c"))
        {
            animator.SetBool("isc", true);
        }
        if (!Input.GetKey("c"))
        {
            animator.SetBool("isc", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("ise", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("ise", false);
        }
        if (Input.GetKey("e"))
        {
            animator.SetBool("isf", true);
        }
        if (!Input.GetKey("e"))
        {
            animator.SetBool("isf", false);
        }
        if (Input.GetKey("f"))
        {
            animator.SetBool("ish", true);
        }
        if (!Input.GetKey("f"))
        {
            animator.SetBool("ish", false);
        }
       
    }
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void startGame1()
    {
        SceneManager.LoadScene("1");
    }
    public void comba()
    {
        SceneManager.LoadScene("co");
    }
    public void dance()
    {
        SceneManager.LoadScene("Dance");
    }
    public void startGame2()
    {
        SceneManager.LoadScene("2");
    }
    public void Quit()
    {
        SceneManager.LoadScene("3");
    }
    public void Quit1()
    {
        SceneManager.LoadScene("1");
    }
    public void QuitT()
    {
        SceneManager.LoadScene("FIRST");
    }

    public void Option()
    {
        SceneManager.LoadScene("4");
    }
    public void Normal()
    {
        SceneManager.LoadScene("1");
    }
    public void Sport()
    {
        SceneManager.LoadScene("sport");
    }
    public void Combat()
    {
        SceneManager.LoadScene("combat");
    }
    public void Dance()
    {
        SceneManager.LoadScene("dance");
    }
    public void Play()
    {
        SceneManager.LoadScene("3");
    }
    public void gb()
    {
        SceneManager.LoadScene("gs1");
    }
    public void combaba()
    {
        SceneManager.LoadScene("gs2");
    }
    public void danceba()
    {
        SceneManager.LoadScene("gs3");
    }
    public void Quitba()
    {
        SceneManager.LoadScene("gs1");
    }
    public void Quittttttba()
    {
        SceneManager.LoadScene("3");
    }

}
