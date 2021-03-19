using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incinerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Something has overlapped me");
        if(other.gameObject.name == "CompanionCube")
        {
            LevelManager.LoadLevel("Menu", false);
        }
    }
}
