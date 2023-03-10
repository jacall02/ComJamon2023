using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;
using DG.Tweening;

public class GameManager : MonoBehaviour
{

    #region parameters
    private bool cajonAbierto = true;
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

   

    //boton que da orden de abrirse o cerrarse
    public void AbrirCajon()
    {
        if(cajonAbierto)
        {
            animatorCajonDestornillador.SetBool("abrir", true);
            cajonAbierto = false;
            
           
        }
        else
        {
            animatorCajonDestornillador.SetBool("abrir", false);
            cajonAbierto = true;
        }
    }
}
