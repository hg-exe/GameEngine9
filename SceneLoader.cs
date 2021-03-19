using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] string SceneToLoad;
    bool sceneLoaded = false;
    [SerializeField] bool LoadAsAdditive = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !sceneLoaded)
        {
            print("Loading scene");
            LevelManager.LoadLevel(SceneToLoad, LoadAsAdditive);
            sceneLoaded = true;
        }
    }
}
