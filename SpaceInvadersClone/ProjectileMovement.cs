using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private float speed = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "Fireball(Clone)")
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        } else if (this.gameObject.name == "Arrow(Clone)")
        {
            transform.Translate(Vector3.down * Time.deltaTime * (speed - 2));
        }
    }
}
