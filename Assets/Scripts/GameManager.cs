using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null) { _instance = FindObjectOfType<GameManager>(); }
            return _instance;
        }
    }
    private void OnDestroy() => _instance = null;
    #endregion
    
    public UIDocument document;
    public Label ScoreLabel;
    
    private int CoinsCollected = 0;

    private void Start()
    {
        ScoreLabel = document.rootVisualElement.Q<Label>("ScoreLabel");
        Debug.Log(ScoreLabel);
    }

    public void PickupCoin(Coin coin)
    {
        CoinsCollected += coin.Value;
        Debug.Log($"Coin Collected, new score is: {CoinsCollected}");
        ScoreLabel.text = $"SCORE: {CoinsCollected:000}";
    }
}
