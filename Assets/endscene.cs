using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endscene : MonoBehaviour
{
    public GameObject scoretext;


    void Start()
    {
      scoretext.GetComponent<Text>().text = (button_color.score).ToString();
      button_color.score = 0;
    }

    public void restart()
    {
      SceneManager.LoadScene("maingame");
    }
    public void home()
    {
      SceneManager.LoadScene("home");
    }
}
