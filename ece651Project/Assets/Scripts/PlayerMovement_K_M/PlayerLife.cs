using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
        else if (collision.gameObject.CompareTag("Stun"))
        {
            Stun();
        }

    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void Stun()
    {
        anim.SetTrigger("stun");
        while (anim.GetCurrentAnimatorStateInfo(0).IsName("stun"))
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
