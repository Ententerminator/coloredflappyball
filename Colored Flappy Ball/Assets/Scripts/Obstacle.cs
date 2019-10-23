using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float speed = -6.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < -12)
        {
            Debug.Log("destroyed object");
            Destroy(this.gameObject);
        }
    }
}
