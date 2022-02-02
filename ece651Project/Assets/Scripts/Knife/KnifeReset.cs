using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeReset : MonoBehaviour
{
    private Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
        startpos = gameObject.GetComponent<Transform>().position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MapBorder"))
        {
            gameObject.transform.position = startpos;
        }
    }
}
