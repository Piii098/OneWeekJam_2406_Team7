using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class BGM : MonoBehaviour
{
    [SerializeField]private AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.isGameOver)
        {
            m_AudioSource.Stop();
        }

    }
}
