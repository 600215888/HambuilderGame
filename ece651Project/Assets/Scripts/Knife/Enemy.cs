using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject knifeobj;
    public Breed breed;
    public string breed_str = "move_left_right";
    private Vector3 startpos;
    // Start is called before the first frame update

    void Start()
    {
     startpos = gameObject.transform.position;
      knifeobj = GameObject.Find("KnifeObject");
      if (this.gameObject.tag == ("LeftRight"))
        {
            breed = new Left_Right();
        }

      if (this.gameObject.tag == ("SwayDown"))
        {
            breed = new SwayDown();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (breed != null)
        {
            breed.move(this,startpos,3);
        }
    }
}
