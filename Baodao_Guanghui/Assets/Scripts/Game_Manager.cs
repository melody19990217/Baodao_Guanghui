﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Go_BuyMeat()
    {
        SceneManager.LoadScene(3);
    }

    public void Go_HotFried()
    {
        SceneManager.LoadScene(2);
    }
}
