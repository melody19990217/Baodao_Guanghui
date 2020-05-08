﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider BGMSlider;
    public AudioSource BGMSource;

    public void BGM_Controller()
    {
        BGMSource.volume = BGMSlider.value;
    }
}
    
