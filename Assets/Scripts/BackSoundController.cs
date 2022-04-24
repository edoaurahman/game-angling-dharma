using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSoundController : MonoBehaviour
{
    static AudioSource audioSrc;
    int mute;
    AudioClip clipaudio;
    string backsound;

    void Start()
    {
        backsound = PlayerPrefs.GetString("BgSound");
        if (backsound == "")
        {
            PlayerPrefs.SetString("BgSound", "Backsound1");
        }
        backsound = PlayerPrefs.GetString("BgSound");
        audioSrc = GetComponent<AudioSource>();
        clipaudio = Resources.Load<AudioClip>(backsound);
    }
 
    public void PlayStopMusik()
    {
       if (!audioSrc.isPlaying){
            audioSrc.PlayOneShot(clipaudio);
            PlayerPrefs.SetInt("mute", 0);

        }else{
            PlayerPrefs.SetInt("mute", 1);
            audioSrc.Stop();
        }
    }
    public void Backsound1(){
        PlayerPrefs.SetString("BgSound", "Backsound1");
        PlayerPrefs.SetInt("mute", 0);
        audioSrc.Stop();
        clipaudio = Resources.Load<AudioClip>("Backsound1");
        audioSrc.PlayOneShot(clipaudio);
    }
    public void Backsound2(){
        PlayerPrefs.SetString("BgSound", "Backsound2");
        PlayerPrefs.SetInt("mute", 0);
        audioSrc.Stop();
        clipaudio = Resources.Load<AudioClip>("Backsound2");
        audioSrc.PlayOneShot(clipaudio);
    }
    private void Update() 
    {
    mute = PlayerPrefs.GetInt("mute");
        if (!audioSrc.isPlaying & mute == 0){
        audioSrc.PlayOneShot(clipaudio);
        }
    }
    public void StopMusik()
    {
        mute += 1;
        audioSrc.Stop();
        
    }
}
