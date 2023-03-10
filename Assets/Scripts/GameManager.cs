using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

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
            
           
        }
        else
        {
            animatorCajonDestornillador.SetBool("abrir", false);
            
        }
    }
}
