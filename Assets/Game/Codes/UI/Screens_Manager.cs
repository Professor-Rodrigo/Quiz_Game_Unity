using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screens_Manager : MonoBehaviour
{
    [SerializeField] GameObject question_HUD, answered_HUD, ending_HUD;


    public void Active_Question_HUD()
    {
        answered_HUD.SetActive(false);
        question_HUD.SetActive(true);
    }
 
    public void Active_Answered_HUD()
    {
        question_HUD.SetActive(false);
        answered_HUD.SetActive(true);
    }

    public void Active_Ending_HUD()
    {
        question_HUD.SetActive(false);
        answered_HUD.SetActive(false);
        ending_HUD.SetActive(true);
    }
}
