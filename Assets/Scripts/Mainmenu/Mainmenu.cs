using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using DG.Tweening;

public class Mainmenu : MonoBehaviour
{
    public float transitionDuration = 1f;
    public Ease transitionEase = Ease.InOutQuad;

    [SerializeField] private CanvasGroup canvasGroup;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void CambioEscenaGame(string sceneName)
    {
        canvasGroup.blocksRaycasts = true;

        canvasGroup.DOFade(0f, transitionDuration).SetEase(transitionEase).OnComplete(()=>SceneManager.LoadScene(sceneName));

        //se pasa a la siguiente escena por orden
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //llamada Game
        //SceneManager.LoadScene("Game");
    }
}
