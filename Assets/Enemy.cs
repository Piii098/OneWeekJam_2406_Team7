using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float destroytime;

    private Rigidbody2D rb = null;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int xVector = -1;
        if (!GManager.instance.isGameOver)
        {
            rb.velocity = new Vector2(speed * xVector, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
        Destroy(gameObject, destroytime);
    }
}

