using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;
using DG.Tweening;
using System.Collections.Generic;
public enum IDFinales
{
    E = 1, TimeLimit = 2, Correct = 3, Profesores = 4
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
    private int nFinales;
    // array de booleanos de si el final 'i' se ha conseguido
    private bool[] finales;

    // Imagen que bloquea el input cuando consigues un final
    [SerializeField] private GameObject blockImage;

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
