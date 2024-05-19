using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    
    //List of the scenes to load from Main Menu
    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();
    public void StartGame()
    {
        HideMenu();
        //Load the Scene asynchronously in the background
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Gameplay"));
        //Additive mode adds the Scene to the current loaded Scenes, in this case Gameplay scene
        scenesToLoad.Add(SceneManager.LoadSceneAsync("Level00", LoadSceneMode.Additive));
     
    }

  

    public void HideMenu()
    {
        menu.SetActive(false);
    }

}