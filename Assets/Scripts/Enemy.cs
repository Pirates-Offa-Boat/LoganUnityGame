using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float life;
    private Waypoints Wpoints;

    private int waypointIndex;

    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }

    void Update()
    {
        // Use Vector3.MoveTowards to move along the x, y, and z axes.
        transform.position = Vector3.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        // Check if the enemy has reached the current waypoint.
        if (Vector3.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
        {
            // Increment the waypoint index to move to the next waypoint.
            waypointIndex++;
        }

        if (waypointIndex == Wpoints.Length)
        {
            LevelManager.onEnemyDestroy.Invoke();
            Destroy(gameObject);
            return;
        }

        if (life <= 0)
        {
            LevelManager.onEnemyDestroy.Invoke();
            Destroy(gameObject);
        }
    }
}
