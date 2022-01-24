using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 3.0f;
    private GameObject knifeobj;
    Vector2 movement = new Vector2();

    Rigidbody2D rb2D;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        knifeobj = GameObject.Find("KnifeObject");
    }

    private void FixedUpdate()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.x += 1;
        //movement.y = Input.GetAxisRaw("Vertical");
        movement.y -= 1;
        // 7
        movement.Normalize();
        // 8
        rb2D.velocity = movement * movementSpeed;

        //movement.y += movementSpeed;
        //movement.Normalize();
        //rb2D.velocity = movement * movementSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        knifeobj.transform.position = new Vector2(0,4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
