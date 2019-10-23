using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float jump = 8f;

    public Rigidbody2D BodyofRigid;
    public SpriteRenderer RendererofSprites;

    public AudioSource jumping;
    //public AudioSource dying;

    public string color;

    public Color Red;
    public Color Yellow;
    public Color Blue;
    public Color Green;

    public GameObject ObstaclePrefab;

    public float wait = 4f;
    // Start is called before the first frame update
    void Start()
    {
        AssignColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetKeyDown("w"))
        {
            BodyofRigid.velocity = Vector2.up * jump;
            jumping.Play();
        }

        if (Input.GetKeyDown("s"))
        {
            BodyofRigid.velocity = -Vector2.up * jump;
        }

        if(transform.position.y > 5 || transform.position.y < -5)
        {
            Debug.Log("Oh noes, you ded");
            SceneManager.LoadScene("Restart");
        }


        wait -= Time.deltaTime;
        if (wait <= 0)
        {
            MoreObstacles();
        }

    }

    void OnTriggerEnter2D(Collider2D cool)
    {
        if (cool.tag != color) {
            Debug.Log("Oh noes, you ded");
            SceneManager.LoadScene("Restart");
        }
    }

    void OnTriggerExit2D(Collider2D cool)
    {
        if (cool.tag == color)
        {
            AssignColor();
        }
    }


    void AssignColor()
    {
        int index = Random.Range(0,4);

        switch (index)
        {
            case 0:
                color = "Red";
                RendererofSprites.color = Red;
                break;
            case 1:
                color = "Yellow";
                RendererofSprites.color = Yellow;
                break;
            case 2:
                color = "Blue";
                RendererofSprites.color = Blue;
                break;
            case 3:
                color = "Green";
                RendererofSprites.color = Green;
                break;
        }
    }

    void MoreObstacles()
    {
        Instantiate(ObstaclePrefab, new Vector3(12f, 0f, 0f), Quaternion.identity);
        wait = Random.Range(1f,3.5f);
    }

}
