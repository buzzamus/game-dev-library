using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootArrow", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootArrow()
    {
        int chanceToShoot = Random.Range(1, 3); // 50/50 chance every time this is called the enemy will shoot
        if (chanceToShoot % 2 == 0)
        {
            Vector3 arrowOrigion = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            Instantiate(projectilePrefab, arrowOrigion, projectilePrefab.transform.rotation);
        }
    }
}
