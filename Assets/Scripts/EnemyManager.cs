using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Enemy m_hole;
    [SerializeField] private Player m_player;
    [SerializeField] private float spawnIntervalMin;//次の敵が出現する最小時間
    [SerializeField] private float spawnIntervalMax;//次の敵が出現する最大時間
    private float spawnInterval=0;
    private float nowTime;
    private float[] ySpawn =  { -1.6f, -2.7f, -4f};//上段、中段、下段

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnInterval == 0)
        {
            var x = 12;
            var y = ySpawn[UnityEngine.Random.Range(0, 2)];
            var obj = Instantiate(m_hole, new Vector3(x, y, 0), Quaternion.identity);
            obj.m_player = m_player;
            spawnInterval = UnityEngine.Random.Range(spawnIntervalMin*60, spawnIntervalMax*60);
        }
        else
        {
            spawnInterval--;
        }
    }
}
