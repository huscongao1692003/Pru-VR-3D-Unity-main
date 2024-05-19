using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
   
    void Start()
    {
        SceneManager.LoadSceneAsync("Gameplay");
        //Additive mode adds the Scene to the current loaded Scenes, in this case Gameplay scene
        SceneManager.LoadSceneAsync("Level00", LoadSceneMode.Additive);
    }

}
