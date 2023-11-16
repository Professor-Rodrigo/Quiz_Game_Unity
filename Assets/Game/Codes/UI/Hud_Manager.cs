using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hud_Manager : MonoBehaviour
{
    public static Hud_Manager hud_singleton;

    [Header("Question HUD")]

    [SerializeField] TMP_Text txt_question_number;

    [SerializeField] TMP_Text txt_question_content;

    [SerializeField] TMP_Text txt_alternative_A;
    [SerializeField] TMP_Text txt_alternative_B;
    [SerializeField] TMP_Text txt_alternative_C;
    [SerializeField] TMP_Text txt_alternative_D;


    [Header("Answer HUD")]
    [SerializeField] TMP_Text txt_answered_question_number;
    [SerializeField] TMP_Text txt_answered_content;


    void Awake() => hud_singleton = this;


    public void Update_Hud_Question(Question_Model _data_question, int _quantity_of_questions)
    {
        txt_question_number.text = "" + _data_question.number_question + "/" + _quantity_of_questions;

        txt_question_content.text = "" + _data_question.alternative_question;

        txt_alternative_A.text = "A - " + _data_question.alternative_A;
        txt_alternative_B.text = "B - " + _data_question.alternative_B;
        txt_alternative_C.text = "C - " + _data_question.alternative_C;
        txt_alternative_D.text = "D - " + _data_question.alternative_D;

    }

    public void Change_HUD_Answer_Screen(Question_Model _data_question, int _quantity_of_questions, string _content)
    {
        txt_answered_question_number.text = "" + _data_question.number_question + "/" + _quantity_of_questions;

        txt_answered_content.text = "" + _content;
    }

}
