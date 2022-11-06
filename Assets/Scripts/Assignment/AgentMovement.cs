using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{
    private Vector2 target;
    NavMeshAgent agent;
    private GameObject Castle;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        Castle = GameObject.FindGameObjectWithTag("Castle");
        SetTargetPosition();
        SetAgentPosition();
        agent.speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, Castle.transform.position);

        if(distance < 1f)
        {
            GameManager.Instance.gameEffectPool.Despawn(transform);
            CountHealth.count -= 1;
        }
    }

    void SetTargetPosition()
    {
        target = Castle.transform.position;
        Debug.Log(target.x);
        Debug.Log(target.y);

    }
    void SetAgentPosition()
    {
        agent.SetDestination(new Vector3(target.x, target.y, transform.position.z));
    } 
}
