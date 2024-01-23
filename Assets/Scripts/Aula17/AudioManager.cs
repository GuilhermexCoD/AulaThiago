using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private const string kMasterVolumeKey = "MasterVolume";
    private const string kMusicVolumeKey = "MusicVolume";
    private const string kSoundEffectVolumeKey = "SoundEffectVolume";

    public AudioMixer masterMixer;

    public void SetMasterVolumeNormalized(float volumeNormalized)
    {
        float interpolatedValue = Mathf.Lerp(-80, 0, volumeNormalized);
        SetMasterVolume(interpolatedValue);
        Debug.Log($"Value = {volumeNormalized} | Interpolated Value = {interpolatedValue}");
    }

    public void SetMusicVolumeNormalized(float volumeNormalized)
    {
        float interpolatedValue = Mathf.Lerp(-80, 0, volumeNormalized);
        SetMusicVolume(interpolatedValue);
        Debug.Log($"Value = {volumeNormalized} | Interpolated Value = {interpolatedValue}");
    }

    public void SetSoundEffectVolumeNormalized(float volumeNormalized)
    {
        float interpolatedValue = Mathf.Lerp(-80, 0, volumeNormalized);
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
