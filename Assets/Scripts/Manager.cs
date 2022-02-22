using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    GameObject[] startGameUIComponents;
    GameObject[] gameOverUIComponents;
    [SerializeField] GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponets");
        gameOverUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponets");
        DisableUIComponent(gameOverUIComponents);
        EnableUIComponent(startGameUIComponents);
        DisableScore(score);
    }

    public void DisableStartUI()
    {
        DisableUIComponent(startGameUIComponents);
    }

    public void Startgame()
    {
        EnableUIComponent(startGameUIComponents);
    }
    public void GameOver()
    {
        EnableUIComponent(gameOverUIComponents);
    }
    public void ShowScore()
    {
        score.SetActive(true);
    }

    public void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }

    public void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }

    private void EnableUIComponent(GameObject[] startGameUIComponents)
    {
        foreach (GameObject obj in startGameUIComponents)
        {
            obj.SetActive(true);
        }
    }

    private void DisableUIComponent(GameObject[] startGameUIComponents)
    {
        foreach (GameObject obj in startGameUIComponents)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()   
    {
        
    }
}