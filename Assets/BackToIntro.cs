using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToIntro : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape") || Input.GetKeyDown("b"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }
}
