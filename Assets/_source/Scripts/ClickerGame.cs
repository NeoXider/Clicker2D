using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickerGame : MonoBehaviour, IPointerDownHandler
{
    public float score = 0;
    public int clickPower = 1;
    public int penaltyAmount = 5;
    public TMP_Text textScore;

    private void Start()
    {
        Debug.Log("Счет: " + score);
        Debug.Log("Клик: " + clickPower);
    }

    private void Update()
    {
        score -= penaltyAmount * Time.deltaTime;
        transform.localScale = Vector3.one * (1 + score / 100);

        textScore.text = ((int)score).ToString();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        score += clickPower;
        Debug.Log("Счет: " + score);
    }
}

