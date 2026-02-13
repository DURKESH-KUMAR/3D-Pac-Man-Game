using UnityEngine;
using System.Collections;

public class GhostManager : MonoBehaviour
{
    public static GhostManager Instance;

    GhostBase[] ghosts;
    public bool IsFrightened { get; private set; }

    int ghostEatMultiplier = 200;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        ghosts = FindObjectsOfType<GhostBase>();
    }

    public IEnumerator StartFrightenedMode(float duration)
    {
        IsFrightened = true;
        ghostEatMultiplier = 200;

        foreach (var ghost in ghosts)
            ghost.GetComponent<UnityEngine.AI.NavMeshAgent>().speed *= 0.5f;

        yield return new WaitForSeconds(duration);

        IsFrightened = false;

        foreach (var ghost in ghosts)
            ghost.GetComponent<UnityEngine.AI.NavMeshAgent>().speed *= 2f;
    }

    public void EatGhost(GameObject ghost)
    {
        ScoreManager.Instance.AddScore(ghostEatMultiplier);
        ghostEatMultiplier *= 2;

        ghost.transform.position = Vector3.zero;
    }
}
