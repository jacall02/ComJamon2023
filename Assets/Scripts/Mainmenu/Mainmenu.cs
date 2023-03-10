using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void CambioEscenaGame()
    {
        //se pasa a la siguiente escena por orden
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //llamada Game
        //SceneManager.LoadScene("Game");
    }
}
