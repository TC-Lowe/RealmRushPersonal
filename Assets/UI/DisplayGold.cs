using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayGold : MonoBehaviour
{
    TMP_Text label;
    Bank bank;

    private void Awake()
    {
        label = GetComponent<TMP_Text>();
        bank = FindObjectOfType<Bank>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGold();
    }

    void UpdateGold()
    {
        string displayBalance = bank.CurrentBalance.ToString();
        label.text = ("Gold: " + displayBalance);
    }
}
