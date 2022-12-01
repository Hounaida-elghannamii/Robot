using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nn : MonoBehaviour
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
            animator.SetBool("isWalking", true);
        }
        if (!Input.GetKey("a"))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey("b"))
        {
            animator.SetBool("isLaughing", true);
        }
        if (!Input.GetKey("b"))
        {
            animator.SetBool("isLaughing", false);
        }
        if (Input.GetKey("c"))
        {
            animator.SetBool("isPraying", true);
        }
        if (!Input.GetKey("c"))
        {
            animator.SetBool("isPraying", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("isJumping", true);
        }
        if (!Input.GetKey("d"))
        {
            animator.SetBool("isJumping", false);
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
