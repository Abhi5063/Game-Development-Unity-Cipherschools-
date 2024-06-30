using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
 }
