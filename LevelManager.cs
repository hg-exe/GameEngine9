using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        } 
        else if( instance != this)
        {
            Destroy(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public static void LoadLevel(string LevelName, bool LoadAsAdditive = false)
    {
        // DO stuff I need to do before changing level
        SceneManager.LoadScene(LevelName, LoadAsAdditive ? (LoadSceneMode.Additive):(LoadSceneMode.Single));
    }
}
