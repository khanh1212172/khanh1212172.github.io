using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{

    public static GamePlayController instance;

    void Awake()
    {
        _MakeInstance();
    }
    void _MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    [SerializeField]
    private GameObject gameOverPanel;

    //[SerializeField]
    //private Text scoreText;

    public void PlaneDiedShowPanel()
    {
        gameOverPanel.SetActive(true);
    }
    /*
    public void _SetScore(int score)
    {
        scoreText.text =  score.ToString();
    }
    */
    public void ReStartButton()
    {
        gameOverPanel.SetActive(false);
        Application.LoadLevel("GamePlay");
    }
}
