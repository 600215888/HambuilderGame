//https://answers.unity.com/questions/754633/how-to-move-an-object-left-and-righ-looping.html
//where the left and right movement code was obtained from

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left_Right : Breed
{
    public float speed = 2f;
    // Start is called before the first frame update
    public void move(Enemy enemy, Vector3 startpos, float dist)
    {
        var position = enemy.gameObject.transform.position;
        Rigidbody2D rb2D = enemy.GetComponent<Rigidbody2D>();
        double endpos = startpos.x + dist;
        startpos.x = dist * Mathf.Sin(Time.time * speed);
        enemy.gameObject.transform.position = startpos;
    }
}


