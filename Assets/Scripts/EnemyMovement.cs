using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform endGoal;
    public float aggroRange = 50f;
    private Transform target;
    public NavMeshAgent myAgent;

    private void Update()
    {
        //TODO: Scan for target


        //Target exists, attack target else move towards the end point.
        if (target != null)
        {
            attackTarget();
        }
        else
        {
            moveTowardsGoal();
        }
    }

    //Move towards the target and attack the target.
    private void attackTarget()
    {

    }

    //Target doesn't exists so move towards end goal.
    private void moveTowardsGoal()
    {
        myAgent.SetDestination(endGoal.position);
    }

}
