using UnityEngine;

public class ChispasDestroyer : MonoBehaviour
{
    float duration;
    private void Start()
    {
        duration = GetComponentInChildren<ParticleSystem>().main.duration;
    }

    private void Update()
    {
        Destroy(gameObject, duration);
    }
}
