using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    private int CurrentWayPoint = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoints[CurrentWayPoint].transform.position,transform.position)< .1f)
        {
            CurrentWayPoint++;
            if (CurrentWayPoint >= waypoints.Length)
            {
                CurrentWayPoint = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[CurrentWayPoint].transform.position, Time.deltaTime * speed); //framerate independant 
    }
}
