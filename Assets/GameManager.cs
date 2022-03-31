using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public int lives = 100;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    public void loseLife()
    {
        lives--;
        Debug.Log("lost life!" + lives + " left");
        if(lives <= 0)
        {
            gameOver();
        }
    }

    //TODO:
    private void gameOver()
    {
        Debug.Log("Ded");
    }


    //TODO:
    public void gameWon()
    {
        Debug.Log("Win!");
    }
}
