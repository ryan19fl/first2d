using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 200f;
    public float enemyhealth = 100f;
    public float enemyMaxhealth = 100f;
    public float enemyDamage = 10f;
    public float nextwaypointdistance = 3f;
    Path path;

    public Transform enemyGpath;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;
    Seeker seeker;
    Rigidbody2D ri;
    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        ri = GetComponent<Rigidbody2D>();
        InvokeRepeating("UpdatePath", 0f, 0.5f);
        enemyhealth = enemyMaxhealth;
    }
    public void UpdateEnemyhealth(float hitdamage)
    {
        enemyhealth += hitdamage;
        if(enemyhealth<=0f)
        {
            Destroy(gameObject);
        }
    }
    void UpdatePath()
    {
        if(seeker.IsDone())
        seeker.StartPath(ri.position, target.position, pathcomplete);
    }
    void pathcomplete(Path p) 
    {
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if(path==null)
        
            return;
        if(currentWaypoint>=path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }
        Vector2 diraction = ((Vector2)path.vectorPath[currentWaypoint] - ri.position).normalized;
        Vector2 force = diraction * speed * Time.deltaTime;
        ri.AddForce(force);
        float distance = Vector2.Distance(ri.position, path.vectorPath[currentWaypoint]);
        if (distance <nextwaypointdistance )
        {
            currentWaypoint++;
        }
        if (force.x >= 0.01f)
        {
            enemyGpath.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (force.x <= -0.01f)
        {
            enemyGpath.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
