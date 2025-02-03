using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [Header("Canvas")]
    public Canvas main;
    public Canvas settings;
    
    [Header("Camera")]
    public Camera mainCamera;
    public Camera settingsCamera;

    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        settings.enabled = false;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void OnSettings()
    {
        main.enabled = false;
        settings.enabled = true;
        mainCamera.enabled = false;
        settingsCamera.enabled = true;
    }

    public void OnBackToMain()
    {
        main.enabled = true;
        settings.enabled = false;
        mainCamera.enabled = true;
        settingsCamera.enabled = false;
    }
}
