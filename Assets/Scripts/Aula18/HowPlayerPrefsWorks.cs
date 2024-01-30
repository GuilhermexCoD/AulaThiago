using TMPro;
using UnityEngine;

public class HowPlayerPrefsWorks : MonoBehaviour
{
    public int money = 10000;
    public float xp = 112.5f;
    public string playerName = "Aragorn";

    public TextMeshProUGUI _playerNameText;
    public TextMeshProUGUI _playerMoneyText;
    public TextMeshProUGUI _playerXpText;

    private void Awake()
    {
        UpdateTexts();
    }

    private void UpdateTexts()
    {
        _playerNameText.text = playerName;
        _playerMoneyText.text = $"Money: {money}";
        _playerXpText.text = $"XP: {xp}";
    }

    public void Save()
    {
        PlayerPrefs.SetInt("PlayerMoney", money);
        PlayerPrefs.SetFloat("PlayerXP", xp);
        PlayerPrefs.SetString("PlayerName", playerName);
    }

    public void Load()
    {
        money = PlayerPrefs.GetInt("PlayerMoney", 10);
        xp = PlayerPrefs.GetFloat("PlayerXP", 0f);
        playerName = PlayerPrefs.GetString("PlayerName", "");
        UpdateTexts();
    }
}
