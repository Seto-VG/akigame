using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBehavior<GameManager>
{
    [SerializeField] private GameObject gameClear;
    [SerializeField] private GameObject retryButton;

    public void GameOver()
    {
        retryButton.SetActive(true);
    }

    public void GameClear()
    {
        gameClear.SetActive(true);
    }

    void Start()
    {
        retryButton.SetActive(false);
        gameClear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
