using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int _sceneMenu = 0;
    private int _sceneShop = 1;
    private int _sceneGame = 2;

    public void LoadMenu()
    {
        SceneManager.LoadScene(_sceneMenu);
    }

    public void LoadShop()
    {
        SceneManager.LoadScene(_sceneShop);
    }

    public void LoadGame()
   {
        SceneManager.LoadScene(_sceneGame);
   }
}
