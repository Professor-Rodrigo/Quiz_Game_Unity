using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    public void Change_Scene(string _scene_name)
    {
        SceneManager.LoadScene(_scene_name);
    }
}
