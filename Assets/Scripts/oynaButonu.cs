using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oynaButonu : MonoBehaviour
{
    
    public void oyunagecis()
    {
        SceneManager.LoadScene("Oyun");
    }
    public void oyundanc�k�s()
    {
        
        Application.Quit();
    }
}
