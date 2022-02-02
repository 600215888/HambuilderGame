using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform leftpoint1, rightpoint1,leftpoint2,leftpoint3;
    public float speed;
    private float leftx1, rightx1,leftx2,leftx3;
    private float lefty2, lefty3;
    private bool faceleft = true;
    public Animator anim;
    public int choose;
    public bool circle=false;
    public float x, y;
    public bool condition = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.DetachChildren();
        leftx1 = leftpoint1.position.x;
        rightx1 = rightpoint1.position.x;
        leftx2 = leftpoint2.position.x;
        leftx3 = leftpoint3.position.x;
        lefty2 = leftpoint2.position.y;
        lefty3 = leftpoint3.position.y;
        Destroy(leftpoint1.gameObject);
        Destroy(rightpoint1.gameObject);
        Destroy(leftpoint2.gameObject);
        Destroy(leftpoint3.gameObject);
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
                    return;
                }
            }
        }
        else if (choose == 2)
        {
            if (condition == true)
            {
                x = ((transform.position.x - leftx2) / ((lefty2 - transform.position.y)+ (transform.position.x - leftx2))) * speed;
                //y = (transform.position.y - lefty2)/speed;
                y = ((lefty2 - transform.position.y) / ((transform.position.x - leftx2)+ (lefty2 - transform.position.y))) * speed;
                condition = false;
            }
            if (faceleft)
            {
                rb.velocity = new Vector2(-x, y);
                //rb.velocity = new Vector2(-speed, speed);
                if (transform.position.x < leftx2)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    faceleft = false;
                }
            }
            else
            {
                rb.velocity = new Vector2(x, -y);
                //rb.velocity = new Vector2(speed, -speed);
                if (transform.position.x > rightx1)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    faceleft = true;
                    circle = true;
                    choose = Random.Range(1, 4);
                    condition = true;
                }
            }
        }
        else if (choose == 3) 
        {
            if (condition == true) {
                x = ((transform.position.x - leftx3) / ((transform.position.x - leftx3) + (transform.position.y - lefty3))) * speed;
                y = ((transform.position.y - lefty3) / ((transform.position.x - leftx3) + (transform.position.y - lefty3))) * speed;
                condition = false;
            }
            if (faceleft)
            {
                rb.velocity = new Vector2(-x, -y);
                if (transform.position.x < leftx3)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    faceleft = false;
                }
            }
            else
            {
                rb.velocity = new Vector2(x, y);
                if (transform.position.x > rightx1)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    faceleft = true;
                    circle = true;
                    choose = Random.Range(1, 4);
                    condition = false;
                }
            }
        }
    }
}
