using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puan : MonoBehaviour
{
    public Text ySkor;
    void Start()
    {
        ySkor.text = "HIGH SCORE \n" + PlayerPrefs.GetInt("Yskor");
    }

    
}
