using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    [SerializeField] int score = 0;
    private void Awake()
    {
        int numGameCtrl = FindFirstObjectByType<GameController>().score;
        if (numGameCtrl > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore()
    {
        score = score + 1;
    }
}
