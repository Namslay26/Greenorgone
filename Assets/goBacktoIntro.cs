﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goBacktoIntro : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("GameIntro");
            }
    }
}
