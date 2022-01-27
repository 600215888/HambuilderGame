using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwayDown : Breed
{
    public float speed = 3.0f;
    public int rot_angle = -30;
    public bool go_back = false;
    Vector2 movement = new Vector2();

    public void move(Enemy enemy, Vector3 startpos,float dist)
    {
        Rigidbody2D rb2D = enemy.GetComponent<Rigidbody2D>();
        movement.y -= 1;
        movement.Normalize();
        rb2D.velocity = movement * speed;

        if (rot_angle > 30)
        {
            rot_angle -= 60;
            go_back = true;
        }

        if (go_back == true)
        {
            rot_angle -= 1;
        }

        if (rot_angle < -30)
        {
            go_back = false;
        }

        if (go_back == false)
        {
            rot_angle += 1;
        }
        enemy.gameObject.transform.rotation = Quaternion.Euler(Vector3.forward * (rot_angle));
    }
}