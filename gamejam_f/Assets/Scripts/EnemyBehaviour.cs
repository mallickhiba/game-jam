using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent navMeshAgent;
    private Animator animator;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        if (target == null)
        {
            Debug.LogError("Target is not assigned!");
        }
    }

    void Update()
    {
        if (target != null)
        {
            navMeshAgent.SetDestination(target.position);
            float speed = navMeshAgent.velocity.magnitude;

            // Set animation parameters based on speed
            animator.SetBool("IsWalking", speed > 0.1f && speed <= 2.0f);
            animator.SetBool("IsRunning", speed > 2.0f);
        }
    }
}

