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
        startGameUIComponents = GameObject.FindGameObjectsWithTag("StartGameUIComponets");
        gameOverUIComponents = GameObject.FindGameObjectsWithTag("GameOverUIComponets");
        DisableUIComponent(gameOverUIComponents);
        EnableUIComponent(startGameUIComponents);
        DisableScore(score);
    }

    public void GameOver()
    {
        EnableUIComponent(startGameUIComponents);
    }
    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }

    private void EnableScore(GameObject score)
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