using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;
    [HideInInspector] public bool isGameOver = false;
    [HideInInspector] public bool isGameClear = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GameOverFunc()
    {
        isGameOver = true;
    }

    public void RetryGame()
    {
        isGameOver = false;
    }

    public void GameClearFunc()
    {
        isGameClear = true;
    }

    public void BackMenu()
    {
        isGameClear = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
