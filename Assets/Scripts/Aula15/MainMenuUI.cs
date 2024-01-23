using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public string gameLevelName;
    public GameObject optionUI;

    public void OnNewGameClick()
    {
        SceneManager.LoadScene(gameLevelName);
    }

    public void OnOptionsClick()
    {
        optionUI.SetActive(true);
    }

    public void OnQuitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
