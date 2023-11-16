using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_Manager : MonoBehaviour
{
    private int current_question = 0;

    Screens_Manager screens_manager;


    [SerializeField] List<Question_Model> all_questions = new List<Question_Model>();


    void Start() => screens_manager = GetComponent<Screens_Manager>();


    public void Load_Question()
    {
        if (current_question < all_questions.Count)
        {
            screens_manager.Active_Question_HUD();
            Hud_Manager.hud_singleton.Update_Hud_Question(all_questions[current_question],all_questions.Count); 
            return;
        }
        
        screens_manager.Active_Ending_HUD();
    }


    public void Verify_Answer(string _choosen_answer)
    {
        string _content_text;

        if (_choosen_answer == all_questions[current_question].Get_Correct_Answer())
        {
            _content_text = "ACERTOU, MEUS PARABÉNS!";
            
        }
        else
        {
            _content_text = "ERROU, A resposta certa era " + all_questions[current_question].correct_content_question;
        }
       
        Hud_Manager.hud_singleton.Change_HUD_Answer_Screen(all_questions[current_question], all_questions.Count, _content_text);

        current_question++;

    }


}
