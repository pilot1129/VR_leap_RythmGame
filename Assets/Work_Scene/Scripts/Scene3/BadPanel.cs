﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadPanel : MonoBehaviour {

    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = PlayData.PlayResult.bad.ToString();
    }
}
