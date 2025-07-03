using UnityEngine;

public class BulletParticlesInput : MonoBehaviour
{
    public GameObject particle;
    public Transform spawnCanon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(particle, spawnCanon);
        }
    }
}
