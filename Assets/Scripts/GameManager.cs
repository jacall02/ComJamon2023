using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;
using DG.Tweening;
using System.Collections.Generic;
using UnityEngine.UI;

public enum IDFinales
{
    E = 0, TimeLimit = 1, Correct = 2, Profesores = 3
}

public class GameManager : MonoBehaviour
{

    #region parameters

    private bool cajonAbierto = true;

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

    #endregion

    #region references

    [SerializeField]
    private Animator animatorCajonDestornillador;

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
        Application.Quit();
#endif
    }

    //JUGABILIDAD----------------------------------------------------

    //boton que da orden de abrirse o cerrarse
    public void AbrirCajon()
    {
        if(cajonAbierto)
        {
            animatorCajonDestornillador.SetBool("abrir", true);
            cajonAbierto = false;
                    
        }
    }

    public void CerrarCajon()
    {
        if (!cajonAbierto)
        {
            animatorCajonDestornillador.SetBool("abrir", true);
            cajonAbierto = false;
        }
    }

    public void Submit()
    {
        //musica soundManager
        SoundManager.instance.SeleccionAudio(0, 1f);
        //efecto
        nSubmits++;
        Debug.Log("Intentos en el juez: " + nSubmits);

        //comprobacion de si hemos pulsado submit suficientes veces
        if (Submits >= limitesSubmits)
        {
            //correct answer
            Debug.Log("Correct Answer");
        }
    }

    public void ResetSubmits()
    {
        nSubmits = 0;
    }
}
