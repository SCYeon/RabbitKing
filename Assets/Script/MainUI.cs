using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUI : MonoBehaviour
{
    //Button Event
    public void ClickStore()
    {
        SceneManager.LoadScene("StoreScene");
    }
    public void ClickGame(int num) 
    {
        if (num == 1)
            SceneManager.LoadScene("Game1Scene");
        else if(num == 2)
            SceneManager.LoadScene("Game2Scene");
        else if(num == 3)
            SceneManager.LoadScene("Game3Scene");
    }
}   
