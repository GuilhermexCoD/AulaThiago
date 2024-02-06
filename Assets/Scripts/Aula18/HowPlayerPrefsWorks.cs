using TMPro;
using UnityEngine;

public class HowPlayerPrefsWorks : MonoBehaviour
{
    public SaveData saveData;

    public TextMeshProUGUI _playerNameText;
    public TextMeshProUGUI _playerMoneyText;
    public TextMeshProUGUI _playerXpText;

    private void Awake()
    {
        UpdateTexts();
    }

    private void UpdateTexts()
    {
        _playerNameText.text = saveData.playerName;
        _playerMoneyText.text = $"Money: {saveData.money}";
        _playerXpText.text = $"XP: {saveData.xp}";
    }

    public void Save()
    {
        PlayerPrefs.SetInt("PlayerMoney", saveData.money);
        PlayerPrefs.SetFloat("PlayerXP", saveData.xp);
        PlayerPrefs.SetString("PlayerName", saveData.playerName);

        SaveToJsonFile saveToJsonFile = new SaveToJsonFile();
        saveToJsonFile.SaveAsync(saveData);
    }

    public void Load()
    {
        saveData.money = PlayerPrefs.GetInt("PlayerMoney", 10);
        saveData.xp = PlayerPrefs.GetFloat("PlayerXP", 0f);
        saveData.playerName = PlayerPrefs.GetString("PlayerName", "");
        UpdateTexts();
    }
}
