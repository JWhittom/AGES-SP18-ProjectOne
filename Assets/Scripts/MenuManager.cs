﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour 
{
    // Main menu panel
    [SerializeField]
    GameObject mainPanel;
    // Controls panel
    [SerializeField]
    GameObject controlsPanel;
    // Credits panel
    [SerializeField]
    GameObject creditsPanel;
    // Join screen
    [SerializeField]
    GameObject joinPanel;
    // Name of next scene
    [SerializeField]
    string nextScene;

    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if (creditsPanel.activeSelf)
                CreditsButton();
        }
    }

    // Go to the join screen
    public void StartButton()
    {
        mainPanel.SetActive(false);
        joinPanel.SetActive(true);
        joinPanel.GetComponentInChildren<Button>().Select();
    }

    // Show the credits panel, hide the main panel
    public void CreditsButton()
    {
        mainPanel.SetActive(false);
        creditsPanel.SetActive(true);
        creditsPanel.GetComponentInChildren<Button>().Select();
    }

    // Show the main panel, hide the credits panel
    public void BackButton()
    {
        creditsPanel.SetActive(false);
        mainPanel.SetActive(true);
        mainPanel.GetComponentInChildren<Button>().Select();
    }

    // Show controls
    public void JoinStartButton()
    {
        if (JoinScreen.NumberOfJoinedPlayers >= 2)
        {
            joinPanel.SetActive(false);
            controlsPanel.SetActive(true);
            controlsPanel.GetComponentInChildren<Button>().Select();
        }
    }

    public void ControlsStartButton()
    {
        SceneManager.LoadScene(nextScene);
    }

    // Quit the game
    public void QuitButton()
    {
        Application.Quit();
    }
}
