using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Instance;
    public Text counterText;

    private void Awake()
    {
        Instance = this;
    }

    private void Money_Counter()
    {
        counterText.text = MoneyCounter.Instance.counter.ToString();
    }

    private void Update()
    {
        Money_Counter();
    }
}
