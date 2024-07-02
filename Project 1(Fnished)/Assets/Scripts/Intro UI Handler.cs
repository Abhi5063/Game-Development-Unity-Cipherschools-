using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroUIHandler : MonoBehaviour
{
    public GameObject instructionpanel;
    public void ToggleInstructionPanel(string toggle)
    {
        if (toggle == "false")
        {
            instructionpanel.SetActive(false);
        } 
        else if (toggle == "true")
        {
            
        
        
            instructionpanel.SetActive(true);
        }
    }
    public void ChangeCurrentSecne()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        int nextIndex = currentScene.buildIndex + 1;
        SceneManager.LoadScene(nextIndex);
    }
}
