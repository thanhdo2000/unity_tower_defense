using System.Collections.Generic;
using UnityEngine;
//using static Unity.VisualScripting.Metadata;

public class FollowThePath : MonoBehaviour
{
    // Array of waypoints to walk from one to the next one
    List<Transform> waypoints = new();

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

    // Use this for initialization
    private void Start()
    {
        GameObject listwaypoint = GameObject.FindGameObjectWithTag("waypoint");
        foreach (Transform child in listwaypoint.transform)
        {
            //Debug.Log(child.name);
            waypoints.Add(child);
        }

        // Set position of Enemy as position of the first waypoint
        //  transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
       Move();
    }

    // Method that actually make Enemy walk
    private void Move()
    {
        Debug.Log(waypoints.Count - 1);
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Count - 1)
        {
            Debug.Log(waypointIndex);
            Debug.Log("2" + waypoints.Count);

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint

            if (transform.position.x == waypoints[waypointIndex].position.x && transform.position.y == waypoints[waypointIndex].position.y)
            {
                waypointIndex = waypointIndex + 1;
            }
        }
    }
}