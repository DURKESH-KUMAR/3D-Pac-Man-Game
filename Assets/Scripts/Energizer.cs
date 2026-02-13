using UnityEngine;
using System.Collections;

public class Energizer : MonoBehaviour
{
    public int points = 50;
    public float duration = 8f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(points);
            StartCoroutine(GhostManager.Instance.StartFrightenedMode(duration));
            Destroy(gameObject);
        }
    }
}
