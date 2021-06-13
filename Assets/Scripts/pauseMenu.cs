using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pauseP;
    void Start()
    {
        pauseP.SetActive(false);
    }

    public void buton_Kontrol(string butonkontrol)
    {
        if (butonkontrol == "pause")
        {
            pauseP.SetActive(true);
            Time.timeScale = 0;
        }
        else if (butonkontrol == "devamEt")
        {
            pauseP.SetActive(false);
            Time.timeScale = 1;
        }
        else if (butonkontrol == "cýkýs")
        {
            Application.Quit();
        }
    }
}
