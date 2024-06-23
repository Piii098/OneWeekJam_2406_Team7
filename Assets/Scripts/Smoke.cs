using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    [SerializeField]
    private Player m_player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x = m_player.transform.position.x - 2.6f;
        pos.y = m_player.transform.position.y;
        transform.position = pos;
    }
}
