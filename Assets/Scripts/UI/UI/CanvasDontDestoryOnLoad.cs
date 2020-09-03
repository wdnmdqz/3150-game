﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDontDestoryOnLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution(1024,768,false);
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
      
    }
}
