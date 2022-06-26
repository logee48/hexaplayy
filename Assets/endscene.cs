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
      scoretext.GetComponent<Text>().text = (timer.score).ToString();
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
