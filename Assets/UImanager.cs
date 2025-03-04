using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public GameObject panel1, panel2, panel3;
    public AudioSource bgmusic;
    public Slider volumeControl;

    public void VolumeChange()
    {
        bgmusic.volume = volumeControl.value;
    
    }
    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }
    public void start()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
    }
    public void continueButton()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
    }
    public void end()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
