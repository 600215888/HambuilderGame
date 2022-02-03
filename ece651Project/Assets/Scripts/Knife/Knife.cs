
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 3.0f;
    private GameObject knifeobj;
    Vector2 movement = new Vector2();
    public int rot_angle = -30;
    public bool go_back = true;

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        knifeobj = GameObject.Find("Knife");
        knifeobj.transform.rotation = Quaternion.Euler(Vector3.forward * (rot_angle));
    }

    private void FixedUpdate()
    {
        movement.y -= 1;
        movement.Normalize();
        rb2D.velocity = movement * movementSpeed;

        if (rot_angle >= 30)
        {
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

        knifeobj.transform.rotation = Quaternion.Euler(Vector3.forward * (rot_angle));

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //On TriggerEnter2D is for when we collide we something for the first time
    //so that will be if you want the knife to disappear as soon as it collides with something
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Logic for collision goes here. 
        //We could probably check the tag of what we've collided with and decide what to do from there.
        knifeobj.transform.position = new Vector2(0, 4);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
