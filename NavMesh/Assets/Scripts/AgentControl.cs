using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControl : MonoBehaviour
{
    public Transform home;
    NavMeshAgent agent;

    void Start () {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.position);
    }
}
