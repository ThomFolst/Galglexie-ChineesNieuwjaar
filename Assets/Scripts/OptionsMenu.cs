using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    //this is all the code used for the options menu
    
    //this is to adjust the audio level
    public AudioMixer audioMixer;
    

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

}
