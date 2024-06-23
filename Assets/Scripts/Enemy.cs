using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float destroytime;

    public Player m_player;
    private Rigidbody2D rb = null;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var spd = m_player.speed * 10 + speed;//プレイヤーが加速したとき用

        int xVector = -1;
        if (!GManager.instance.isGameOver)
        {
            rb.velocity = new Vector2(spd * xVector, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
        Destroy(gameObject, destroytime);
    }
}

