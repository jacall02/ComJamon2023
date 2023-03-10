using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
