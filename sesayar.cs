using UnityEngine;
using UnityEngine.UI;
public class sesayar : MonoBehaviour
{
    GameObject SoundController;

    public bool music;
    


    void Start()
    {

        SoundController = GameObject.FindGameObjectWithTag("SoundController");

        if (PlayerPrefs.HasKey("sfx_vol"))
        {
            if(music==false)
            {
                gameObject.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sfx_vol");
            }
        }
        if (PlayerPrefs.HasKey("music_vol"))
        {
            if (music == true)
            {
                gameObject.GetComponent<Slider>().value = PlayerPrefs.GetFloat("music_vol");
            }
        }
        

        
    }

    


    public void SetVolume(float vol)
    {
        if (music == true)
        {
            SoundController.GetComponent<AudioSource>().volume = vol;
            PlayerPrefs.SetFloat("music_vol", vol);
            PlayerPrefs.Save();
        }
        else
        {
            foreach(Transform child in SoundController.transform)
            {
                child.GetComponent<AudioSource>().volume = vol;
                
            }
            PlayerPrefs.SetFloat("sfx_vol", vol);
            PlayerPrefs.Save();
        }

    }
}