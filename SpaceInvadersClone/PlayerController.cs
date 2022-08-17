using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float xRange = 10.5f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // allow player to "teleport" to the other edge by going just off screen
        // example: player goes out of bounds on left side to appear from the right side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 projectileOrigion = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
            Instantiate(projectilePrefab, projectileOrigion, projectilePrefab.transform.rotation);
        }

    }
}
