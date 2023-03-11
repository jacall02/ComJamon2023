using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;
using DG.Tweening;

public class GameManager : MonoBehaviour
{

    #region parameters
    private bool cajonAbierto = true;

    [SerializeField]
    private int nSubmits;

    [SerializeField]
    private int limitesSubmits;

    //numero de veces que se ha pulsdo E
    [SerializeField]
    private int nE;

    //limite de veces que hay que pulsar E para final que suene musica
    [SerializeField]
    private int limitesE;

    public int Submits { get { return nSubmits; } }

    public int EPressed { get { return nE; } }

    public int correctEndingSubmits;

    #endregion

    #region references

    [SerializeField]
    private Animator animatorCajonDestornillador;

    [SerializeField]
    private Animator pulsarPalanca;

    private protected SoundManager soundManager;

    #endregion

    public static GameManager instance; // singleton instance of the GameManager

    private void Awake()
    {
        //buscamos el soundManager
        soundManager = FindObjectOfType<SoundManager>();

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
        soundManager.SeleccionAudio(0, 1f);
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

    public void PulsarE()
    {
        //musica soundManager
        soundManager.SeleccionAudio(0, 1f);
        //efecto
        nE++;
        Debug.Log("Veces pulsadas E: " + nE);

        //comprobacion de si hemos pulsado E suficientes veces
        if(EPressed >= limitesE)
        {
            //suena musica
            soundManager.SeleccionAudio(1, 1f);
        }
    }

    public void PulsarPalanca()
    {
       
        //si se pulsa
        ///*if(Input.GetMouseButtonDown(0))*/
        //{
            Debug.Log("hce");
            pulsarPalanca.SetBool("palancapulsada", true);
            Invoke("QuitarPalanca", 1f);
        //}
        //else
        //{
            //pulsarPalanca.SetBool("palancapulsada", false);
        //}
        
    }

    private void QuitarPalanca()
    {
        pulsarPalanca.SetBool("palancapulsada", false);
    }
}
