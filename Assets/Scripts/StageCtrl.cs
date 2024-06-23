using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageCtrl : MonoBehaviour
{
    public GameObject gameOverObj;
    public GameObject gameClearObj;

    private bool doGameOver = false;
    private bool retryGame = false;
    private bool backMenu = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverObj.SetActive(false);
        gameClearObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.isGameOver && !doGameOver)
        {
            gameOverObj.SetActive(true);
            doGameOver = true;
        }

        if (retryGame)
        {
            GManager.instance.RetryGame();
            SceneManager.LoadScene("TitleScene");
        }

        if (GManager.instance.isGameClear)
        {
            gameClearObj.SetActive(true);
        }

        if (backMenu)
        {
            GManager.instance.BackMenu();
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void Retry()
    {
        retryGame = true;
    }

    public void BackToMenu()
    {
        backMenu = true;
    }
}