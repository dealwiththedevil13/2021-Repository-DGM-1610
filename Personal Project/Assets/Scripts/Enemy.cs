using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;


public class Enemy : MonoBehaviour
{
    public int curHp, maxHp;
    public int moveSpeed, attackRange, ypathOffset;

    private List<Vector3> path;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerContol>().gameObject;
        InvokeRepeating("UpdatePath",0.0f,0.5f);
    
        curHp=maxHp;
    }

    void updatePath()
    {
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, navMeshPath);

        path = NavMeshPath.corners.ToList();
    }
    void ChaseTarget()
    {
        if(path.count == 0)
        return;

        tranform.position = Vector3.MoveTowards(tranform.position, path[0] + new Vector3(0,yPathOffset,0), moveSpeed * Time.deltaTime);
            path.RemoveAt(0);
    }

    void Die()
    {
        GameManager.instance.AddScore(scoreToGive);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
