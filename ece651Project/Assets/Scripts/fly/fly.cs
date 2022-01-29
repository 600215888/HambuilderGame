using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform leftpoint1, rightpoint1,leftpoint2,leftpoint3;
    public float speed;
    private float leftx1, rightx1,leftx2,leftx3;
    private bool faceleft = true;
    public Animator anim;
    public int choose;
    public bool circle=false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.DetachChildren();
        leftx1 = leftpoint1.position.x;
        rightx1 = rightpoint1.position.x;
        Destroy(leftpoint1.gameObject);
        Destroy(rightpoint1.gameObject);
        choose = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (choose == 1)
        {
            if (faceleft)
            {
                rb.velocity = new Vector2(-speed, 0);
                if (transform.position.x < leftx1)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    faceleft = false;
                }
            }
            else
            {
                rb.velocity = new Vector2(speed, 0);
                if (transform.position.x > rightx1)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    faceleft = true;
                    circle = true;
                    choose = Random.Range(1, 4);
                }
            }
        }
        if (choose == 2) 
        {
            if (faceleft)
            {
                rb.velocity = new Vector2(-speed, speed);
                if (transform.position.x < leftx2)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    faceleft = false;
                }
            }
            else
            {
                rb.velocity = new Vector2(speed, -speed);
                if (transform.position.x > rightx1)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    faceleft = true;
                    circle = true;
                    choose = Random.Range(1, 4);
                }
            }
        }
        if (choose == 3) 
        {
            if (faceleft)
            {
                rb.velocity = new Vector2(-speed, -speed);
                if (transform.position.x < leftx3)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    faceleft = false;
                }
            }
            else
            {
                rb.velocity = new Vector2(speed, speed);
                if (transform.position.x > rightx1)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    faceleft = true;
                    circle = true;
                    choose = Random.Range(1, 4);
                }
            }
        }
    }
}
