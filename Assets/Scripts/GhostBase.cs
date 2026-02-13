using UnityEngine;
using UnityEngine.AI;

public class GhostBase : MonoBehaviour
{
    protected NavMeshAgent agent;
    protected Transform player;

    protected virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected virtual void Update()
    {
        if (!GameManager.Instance.isGameActive)
            return;

        if (!GhostManager.Instance.IsFrightened)
            agent.SetDestination(player.position);
    }

    public void ReturnToStart(Vector3 startPos)
    {
        transform.position = startPos;
    }
}
