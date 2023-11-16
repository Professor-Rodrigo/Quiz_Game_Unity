using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Question_Data")]
public class Question_Model : ScriptableObject
{
    public int number_question;


    public enum possible_answers
    {
        A,
        B,
        C,
        D
    }

    [Space(15)]
    public possible_answers correct_alternative;

    

    [Space(20)]
    [TextArea(2,10)]
    public string alternative_question;

    [Space(20)]
    [TextArea(2,10)]
    public string alternative_A;

    [Space(20)]
    [TextArea(2,10)]
    public string alternative_B;

    [Space(20)]
    [TextArea(2,10)]
    public string alternative_C;

    [Space(20)]
    [TextArea(2,10)]
    public string alternative_D;

    [Space(20)]
    [TextArea(2,10)]
    public string correct_content_question;
    

    public string Get_Correct_Answer()
    {
        string _correct_answer = correct_alternative.ToString();

        return _correct_answer;
    }
}
