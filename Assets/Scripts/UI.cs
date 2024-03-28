using System;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI Instance => instance;

    private static UI instance;

    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI killsText;

    private void Awake()
    {
        instance = this;
        ChangeKillsText(0);
    }

    public void ChangeHealthText(string text)
    {
        healthText.text = "Life: " + text;
    }

    public void ChangeKillsText(int kills)
    {
        killsText.text = "Kills: " + kills;
    }
}
