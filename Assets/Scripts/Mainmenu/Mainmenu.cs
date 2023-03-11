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
    [SerializeField] private RectTransform myPanel;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    private void CambiaEscena(string sceneName)
    {
        canvasGroup.DOFade(0f, transitionDuration).SetEase(transitionEase).OnComplete(() => SceneManager.LoadScene(sceneName));
    }

    public void CambioEscenaGame(string sceneName)
    {
        canvasGroup.blocksRaycasts = true;

        myPanel.DOLocalMoveX(1500.0f, transitionDuration).SetEase(transitionEase).OnComplete(()=>CambiaEscena(sceneName));

        //se pasa a la siguiente escena por orden
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //llamada Game
        //SceneManager.LoadScene("Game");
    }
}
