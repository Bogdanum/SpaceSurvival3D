﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScript : MonoBehaviour
{
    public GameObject Rules;

    void Start()
    {
        Rules.gameObject.SetActive(false);
    }
}
