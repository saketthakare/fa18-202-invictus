﻿using UnityEngine;
using UnityEngine.UI;

public class HomeMenu : MonoBehaviour, IHomeMenu
{
    readonly ICommand quitCommand = new QuitCommand();
    readonly ICommand settingsCommand = new SettingsCommand();
    readonly ICommand helpCommand = new HelpCommand();
    readonly ICommand playCommand = new PlayCommand();
    public Button quitButton, settingsButton, helpButton, playButton;

    void Start(){
        quitButton.onClick.AddListener(quitCommand.Execute);
        settingsButton.onClick.AddListener(settingsCommand.Execute);
        helpButton.onClick.AddListener(helpCommand.Execute);
        playButton.onClick.AddListener(playCommand.Execute);
    }
    /*public void handleInput(){
    }
    public void Play()
    {

    }

    public void Help()
    {

    }

    public void Settings()
    {
        GameObject.FindWithTag("MainMenu").SetActive(false);
        GameObject.Find("Canvas").transform.Find("SettingsMenu").gameObject.SetActive(true);
    }

    public void Quit()
    {
       quitCommand.Execute();
    }*/
}