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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void updatePath()
    {
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, navMeshPath);

        path = NavMeshPath.corners.ToList();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
