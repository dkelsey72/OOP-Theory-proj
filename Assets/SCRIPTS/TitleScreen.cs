using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if Unity_Editor
using UnityEditor;
#endif


public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene(1);
        Debug.Log("main");

    }

    public void QuitGame()
   {
    

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();

    # else
        Application.Quit();

    #endif 
   }       
}
