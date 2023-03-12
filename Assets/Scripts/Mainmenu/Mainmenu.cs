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
    [SerializeField] private AutoFillInputField playerName;

    private void Start()
    {
        playerName = GetComponent<AutoFillInputField>();
    }

    private void CambiaEscena(string sceneName)
    {
        // canvasGroup.DOFade(0f, transitionDuration).SetEase(transitionEase).OnComplete(() => SceneManager.LoadScene(sceneName));
        SceneManager.LoadScene(sceneName);
    }

    public void CambioEscenaGame(string sceneName)
    {
        if (playerName.inputField1.text.Length < 1)
            return;
        InfoManager.instance.SetPlayerName(playerName.inputField1.text);
        canvasGroup.blocksRaycasts = true;

        myPanel.DOLocalMoveX(1500.0f, transitionDuration).SetEase(transitionEase).OnComplete(()=>CambiaEscena(sceneName));

        //se pasa a la siguiente escena por orden
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //llamada Game
        //SceneManager.LoadScene("Game");
    }
}
