using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float updownspeed;

    private Rigidbody2D rb = null;
    private string enemyTag = "Enemy";
    private string goalTag = "Goal";
    private Animator anim = null;
    private bool isDown = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float ySpeed = 0.0f;
        float verticalKey = Input.GetAxis("Vertical");

        if (!isDown)
        {
            if (verticalKey > 0)
            {
                ySpeed = updownspeed;
            }
            else if (verticalKey < 0)
            {
                ySpeed = -updownspeed;
            }
            else
            {
                ySpeed = 0.0f;
            }

            rb.velocity = new Vector2(0.0f, ySpeed);
        }
        else
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == enemyTag)
        {
            Debug.Log("“G‚ÆÚGI");
            anim.Play("car_down");
            ReceiveDamage(true);
        }

        if (collision.tag == goalTag)
        {
            ReceiveGoal();
        }
    }

    private void ReceiveDamage(bool downAnim)
    {
        if (isDown)
        {
            return;
        }
        else
        {
            if (downAnim)
            {
                anim.Play("car_down");
            }
            isDown = true;
            GManager.instance.GameOverFunc();
        }
    }

    private void ReceiveGoal()
    {
        GManager.instance.GameClearFunc();
    }
}

