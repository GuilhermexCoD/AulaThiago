using UnityEditor.ShaderGraph.Drawing.Inspector.PropertyDrawers;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Integrar as configuracoes de audio com as preferencias do usuario
/// </summary>
public class OptionsUI : MonoBehaviour
{
    public AudioManager audioManager;
    public PlayerPrefsManager playerPrefsManager;

    public Slider masterVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider sfxVolumeSlider;

    void Start()
    {
        LoadAudioVolumes();

        RegisterVolumeChanges();
    }

    public void LoadAudioVolumes()
    {
        float masterVolume = playerPrefsManager.LoadMasterVolume();
        masterVolumeSlider.value = masterVolume;
        audioManager.SetMasterVolumeNormalized(masterVolume);

        float musicVolume = playerPrefsManager.LoadMusicVolume();
        musicVolumeSlider.value = musicVolume;
        audioManager.SetMusicVolumeNormalized(musicVolume);

        float sfxVolume = playerPrefsManager.LoadSfxVolume();
        sfxVolumeSlider.value = sfxVolume;
        audioManager.SetSoundEffectVolumeNormalized(sfxVolume);
    }

    public void RegisterVolumeChanges()
    {
        masterVolumeSlider.onValueChanged.AddListener(OnMasterVolumeChanged);
        musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged); 
        sfxVolumeSlider.onValueChanged.AddListener(OnSfxVolumeChanged); 
    }

    public void UnRegisterVolumeChanges()
    {
        masterVolumeSlider.onValueChanged.RemoveListener(OnMasterVolumeChanged);
        musicVolumeSlider.onValueChanged.RemoveListener(OnMusicVolumeChanged);
        sfxVolumeSlider.onValueChanged.RemoveListener(OnSfxVolumeChanged);
    }

    private void OnMasterVolumeChanged(float volume)
    {
        audioManager.SetMasterVolumeNormalized(volume);
        playerPrefsManager.SaveMasterVolume(volume);
    }

    private void OnMusicVolumeChanged(float volume)
    {
        audioManager.SetMusicVolumeNormalized(volume);
        playerPrefsManager.SaveMusicVolume(volume);
    }

    private void OnSfxVolumeChanged(float volume)
    {
        audioManager.SetSoundEffectVolumeNormalized(volume);
        playerPrefsManager.SaveSfxVolume(volume);
    }

    private void OnDestroy()
    {
        UnRegisterVolumeChanges();
    }

}
