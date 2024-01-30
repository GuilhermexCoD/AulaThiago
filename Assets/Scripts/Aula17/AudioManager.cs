using UnityEngine;
using UnityEngine.Audio;

/// <summary>
/// Responsavel por configurar o volume dos Audio Mixer Group
/// </summary>
public class AudioManager : MonoBehaviour
{
    private const string kMasterVolumeKey = "MasterVolume";
    private const string kMusicVolumeKey = "MusicVolume";
    private const string kSoundEffectVolumeKey = "SoundEffectVolume";

    public AudioMixer masterMixer;

    public void SetMasterVolumeNormalized(float volumeNormalized)
    {
        float interpolatedValue = Mathf.Log10(volumeNormalized) * 20f;
        SetMasterVolume(interpolatedValue);
        Debug.Log($"Value = {volumeNormalized} | Interpolated Value = {interpolatedValue}");
    }

    public void SetMusicVolumeNormalized(float volumeNormalized)
    {
        float interpolatedValue = Mathf.Log10(volumeNormalized) * 20f;
        SetMusicVolume(interpolatedValue);
        Debug.Log($"Value = {volumeNormalized} | Interpolated Value = {interpolatedValue}");
    }

    public void SetSoundEffectVolumeNormalized(float volumeNormalized)
    {
        float interpolatedValue = Mathf.Log10(volumeNormalized) * 20f;
        SetSoundEffectVolume(interpolatedValue);
        Debug.Log($"Value = {volumeNormalized} | Interpolated Value = {interpolatedValue}");
    }

    private void SetMasterVolume(float volume)
    {
        masterMixer.SetFloat(kMasterVolumeKey, volume);
    }

    private void SetMusicVolume(float volume)
    {
        masterMixer.SetFloat(kMusicVolumeKey, volume);
    }

    private void SetSoundEffectVolume(float volume)
    {
        masterMixer.SetFloat(kSoundEffectVolumeKey, volume);
    }
}
