using System.Collections.Generic;
using UnityEngine;
//using static Unity.VisualScripting.Metadata;

public class Crep1Move : MonoBehaviour
{
    // Array of waypoints to walk from one to the next one
    List<Transform> waypoints = new();

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 3f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;
    private GameObject Castle;
    // Use this for initialization
    private void Start()
    {
        Castle = GameObject.FindGameObjectWithTag("Castle");
        int x = 0;
        x = Random.Range(1, 5);
        GameObject listwaypoint = null;
        if (x == 1)
        {
            listwaypoint = GameObject.FindGameObjectWithTag("waypoint1");

        }
        if (x == 2)
        {
            listwaypoint = GameObject.FindGameObjectWithTag("waypoint2");

        }
        if (x == 3)
        {
            listwaypoint = GameObject.FindGameObjectWithTag("waypoint3");

        }
        if (x == 4)
        {
            listwaypoint = GameObject.FindGameObjectWithTag("waypoint4");

        }
        if (x == 5)
        {
            listwaypoint = GameObject.FindGameObjectWithTag("waypoint5");

        }


       
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

        float distance = Vector3.Distance(gameObject.transform.position, Castle.transform.position);

        if (distance < 1f)
        {
            Destroy(gameObject);
            CountHealth.count -= 1;

        }
    }
}