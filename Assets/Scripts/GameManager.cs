using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;
using DG.Tweening;
using System.Collections.Generic;
using UnityEngine.UI;

public enum IDFinales
{
   ClickLol = 0, Plagio = 1, RobarMochila = 2, Pajaros = 3, Timelimit = 4, 
   Bombardeo = 5, Profesores = 6, Correct = 7, Laboratorio = 8, E = 9
}

public class GameManager : MonoBehaviour
{

    #region parameters

   

    [SerializeField]
    private int nSubmits;
    public int Submits { get { return nSubmits; } }

    [SerializeField]
    private int limitesSubmits;

    public int correctEndingSubmits;

    // cuantos finales hay
    private int nFinales = 10;
    // array de booleanos de si el final 'i' se ha conseguido
    private bool[] finales;
    public bool[] GetFinales { get { return finales; } }

    #endregion

    #region references

   

    #endregion

    public static GameManager instance; // singleton instance of the GameManager

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject); // don't destroy the GameManager object when a new scene is loaded
            DOTween.Init(true, true);
        }
        else
        {
            Destroy(this.gameObject); // if an instance already exists, destroy this one
        }

        finales = new bool[nFinales];
        for (int i = 0; i < nFinales; ++i)
        {
            finales[i] = false;
        }
    }

    public void ConseguirFinal(IDFinales final)
    {
        finales[(int)final] = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // reload the current scene
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
        //Application.Quit();
#endif
    }

    //JUGABILIDAD----------------------------------------------------

    //boton que da orden de abrirse o cerrarse
   

    public int Submit()
    {
        //musica soundManager
        SoundManager.instance.PlayEffect(0, 1f);
        //efecto
        nSubmits++;
        //Debug.Log("Intentos en el juez: " + nSubmits);

        //comprobacion de si hemos pulsado submit suficientes veces
        if (Submits >= limitesSubmits)
        {
            //correct answer
            Debug.Log("Correct Answer");
        }

        return nSubmits;
    }

    public void ResetSubmits()
    {
        nSubmits = 0;
    }
}
