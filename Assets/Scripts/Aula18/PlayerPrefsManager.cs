using UnityEngine;

/// <summary>
/// Responsavel por gerenciar as preferencias do jogador
/// </summary>
public class PlayerPrefsManager : MonoBehaviour
{
    private const string kMasterVolumeKey = "master-volume";
    private const string kMusicVolumeKey = "music-volume";
    private const string kSfxVolumeKey = "sfx-volume";

    #region Master 

    public void SaveMasterVolume(float volume)
    {
        PlayerPrefs.SetFloat(kMasterVolumeKey, volume);
    }

    public float LoadMasterVolume()
    {
        return PlayerPrefs.GetFloat(kMasterVolumeKey, 1f);
    }

    #endregion

    #region Music

    public void SaveMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat(kMusicVolumeKey, volume);
    }

    public float LoadMusicVolume()
    {
        return PlayerPrefs.GetFloat(kMusicVolumeKey, 1f);
    }

    #endregion

    #region SFX

    public void SaveSfxVolume(float volume)
    {
        PlayerPrefs.SetFloat(kSfxVolumeKey, volume);
    }

    public float LoadSfxVolume()
    {
        return PlayerPrefs.GetFloat(kSfxVolumeKey, 1f);
    }

    #endregion
}
