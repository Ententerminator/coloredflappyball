using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLight : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x > 15)
        {
            transform.position = new Vector3(-10f, 3f, -2f);
        }
    }
}
