using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecargarPartida : MonoBehaviour
{
    [SerializeField]
    private Animator pulsarPalanca;

    private void Start()
    {
        GameManager.instance.ResetSubmits();
    }

    public void PulsarPalanca()
    {
        Debug.Log("Palancas pulsadas");
        pulsarPalanca.SetBool("palancapulsada", true);
        Invoke("QuitarPalanca", 1f);

    }

    private void QuitarPalanca()
    {
        pulsarPalanca.SetBool("palancapulsada", false);
        GameManager.instance.RestartGame();
    }

}
