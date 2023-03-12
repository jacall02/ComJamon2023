using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecargarPartida : MonoBehaviour
{
    [SerializeField]
    private Animator pulsarPalanca;
    [SerializeField]
    private GameObject palancaIluminada;

    private void Start()
    {
        GameManager.instance.ResetSubmits();
    }

    public void PulsarPalanca()
    {
        Debug.Log("Palancas pulsadas");
        pulsarPalanca.SetBool("palancapulsada", true);
        SoundManager.instance.PlayEffect(27, 1f);
        palancaIluminada.SetActive(false);
        Invoke("QuitarPalanca", 1f);

    }

    private void QuitarPalanca()
    {
        pulsarPalanca.SetBool("palancapulsada", false);
        SoundManager.instance.controlAudio.Stop();
        SoundManager.instance.PlayEffect(28, 1f);
        GameManager.instance.RestartGame();
    }

}
