﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //加入SceneManagement功能

public class GameStart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("遊戲開始跑圖");
        }
    }
}
