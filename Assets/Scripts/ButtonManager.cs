using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Collections;


public class ButtonManager : MonoBehaviour {

    public int x;
    public int y;
    public string newGameLevel;

    public void Level1()
    {
        newGameLevel = "level1";
    }

    public void Level2()
    {
        newGameLevel = "level2";
    }

    public void NewGameBtn()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();

    }

    public void FullScreenBtn()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void TenEighty()
    {
        x = 1920;
        y = 1080;
    }

    public void NineHundred()
    {
        x = 1600;
        y = 900;
    }

    public void SevenTwenty()
    {
        x = 1080;
        y = 720;
    }

    public void FourKay()
    {
        x = 3840;
        y = 2160;
    }

    public void apply()
    {
        Screen.SetResolution(x, y, Screen.fullScreen);
    }

}
