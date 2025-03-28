using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sound_Butons : MonoBehaviour
{
    public GameObject SoundbuttonOn;
    public GameObject SoundbuttonOff;
    public GameObject SFXButtonON;
    public GameObject SFXButtonOFF;
    public GameObject SFXSounds;
    public AudioSource BGM;
    private bool Sound;
    private bool SFX;
    // Update is called once per frame

    void Start()
    {
        if(!PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetInt("Sound", 0);
            Load();
        }else
        {
            Load();
        }
        
        if(!PlayerPrefs.HasKey("SFX"))
        {
            PlayerPrefs.SetInt("SFX", 0);
            Load();
        }else
        {
            Load();
        }
        UpdateSFXButton();
        UpdateButton();
        if(Sound == false)
        {
            BGM.Pause();
        }
        if(SFX == false)
        {
            SFXSounds.SetActive(false);
        }
    }

    void UpdateButton()
    {
        if(Sound == false)
        {
            SoundbuttonOff.SetActive(true);
            SoundbuttonOn.SetActive(false);
        }else
        {
            SoundbuttonOff.SetActive(false);
            SoundbuttonOn.SetActive(true);
        }
    }

    void UpdateSFXButton()
    {
        if(SFX == false)
        {
            SFXButtonOFF.SetActive(true);
            SFXButtonON.SetActive(false);
        }else
        {
            SFXButtonOFF.SetActive(false);
            SFXButtonON.SetActive(true);
        }
    }

    public void SFXButtonPress()
    {
        if(SFX == false)
        {
            SFX = true;
            SFXSounds.SetActive(true);
        }else
        {
            SFX = false;
            SFXSounds.SetActive(false);
        }
        UpdateSFXButton();
        Save();
    }

    public void OnButtonPress()
    {

        if(Sound == false)
        {
            Sound = true;
            BGM.Play();
        }else
        {
            Sound = false;
            BGM.Pause();
        }

        Save();
        UpdateButton();
    }

    private void Load()
    {
        Sound = PlayerPrefs.GetInt("Sound") == 1;
        SFX = PlayerPrefs.GetInt("SFX") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("Sound", Sound ? 1 : 0);
        PlayerPrefs.SetInt("SFX", SFX ? 1 : 0);
    }
}
