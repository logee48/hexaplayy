using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_color : MonoBehaviour
{
    public static int score = 0;
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject ref1;
    public GameObject textt;



    // random num generator
    List<int> usedvalues = new List<int>();
    public int unirand(int min, int max)
    {
      int val = Random.Range(min, max);
      while(usedvalues.Contains(val))
      {
        val = Random.Range(min, max);
      }
      return val;
    }

    Color[] pile1c = {new Color32(248,100,255,230), new Color32(118,100,255,230), new Color32(76,247,255,230), new Color32(51,255,35,230), new Color32(237,255,0,230), new Color32(255,191,0,230),
      new Color32(255,85,0,230), new Color32(255,0,101,230)};
    Color[] pile2c = {new Color32(118,100,255,230), new Color32(76,247,255,230), new Color32(51,255,35,230), new Color32(237,255,0,230), new Color32(255,191,0,230), new Color32(255,85,0,230),
      new Color32(255,0,101,230), new Color32(248,100,255,230)};
    Color[] pile3c = {new Color32(76,247,255,230), new Color32(51,255,35,230), new Color32(237,255,0,230), new Color32(255,191,0,230), new Color32(255,85,0,230), new Color32(255,0,101,230),
      new Color32(248,100,255,230), new Color32(118,100,255,230)};
    Color[] pile4c = {new Color32(51,255,35,230), new Color32(237,255,0,230), new Color32(255,191,0,230), new Color32(255,85,0,230), new Color32(255,0,101,230), new Color32(248,100,255,230),
      new Color32(118,100,255,230), new Color32(76,247,255,230)};
    Color[] refc = {new Color32(248,100,255,230), new Color32(237,255,0,230), new Color32(51,255,35,230), new Color32(255,191,0,230), new Color32(237,255,0,230), new Color32(248,100,255,230),
      new Color32(255,0,101,230), new Color32(118,100,255,230)};



    // public Material bb;
    // public void functionsxfn()
    // {
    //   print(aa.GetComponent<Image>().color);
    //   Color butcolor = aa.GetComponent<Image>().color;
    //   aa.GetComponent<Image>().color = new Color32(255,255,2,10);
    //   bb.SetColor("_Color", butcolor);
    // }
    public void fun1()
    {
      int num = unirand(0,8);
      if(but1.GetComponent<Image>().color == ref1.GetComponent<Image>().color)
      {
        // vib_edit.Cancel();
        score+=1;
        but1.GetComponent<Image>().color =  pile1c[num];
        but2.GetComponent<Image>().color = pile2c[num];
        but3.GetComponent<Image>().color = pile3c[num];
        but4.GetComponent<Image>().color = pile4c[num];
        ref1.GetComponent<Image>().color = refc[num];
        vib_edit.Vibrate(250);
      }
    }
    public void fun2()
    {
      int num = unirand(0,8);
      if(but2.GetComponent<Image>().color == ref1.GetComponent<Image>().color)
      {
        // vib_edit.Cancel();
        score+=1;
        but1.GetComponent<Image>().color =  pile1c[num];
        but2.GetComponent<Image>().color = pile2c[num];
        but3.GetComponent<Image>().color = pile3c[num];
        but4.GetComponent<Image>().color = pile4c[num];
        ref1.GetComponent<Image>().color = refc[num];
        vib_edit.Vibrate(250);
      }
    }
    public void fun3()
    {
      // vib_edit.Cancel();
      int num = unirand(0,8);
      if(but3.GetComponent<Image>().color == ref1.GetComponent<Image>().color)
      {
        score+=1;
        but1.GetComponent<Image>().color =  pile1c[num];
        but2.GetComponent<Image>().color = pile2c[num];
        but3.GetComponent<Image>().color = pile3c[num];
        but4.GetComponent<Image>().color = pile4c[num];
        ref1.GetComponent<Image>().color = refc[num];
        vib_edit.Vibrate(250);
      }
    }
    public void fun4()
    {
      // vib_edit.Cancel();
      int num = unirand(0,8);
      if(but4.GetComponent<Image>().color == ref1.GetComponent<Image>().color)
      {
        score+=1;
        but1.GetComponent<Image>().color =  pile1c[num];
        but2.GetComponent<Image>().color = pile2c[num];
        but3.GetComponent<Image>().color = pile3c[num];
        but4.GetComponent<Image>().color = pile4c[num];
        ref1.GetComponent<Image>().color = refc[num];
        vib_edit.Vibrate(250);
      }
    }
    float timerr = 30;
    void Update()
    {
      timerr -= Time.deltaTime;
      if((int)timerr == 0)
      {
        SceneManager.LoadScene("endscene");
      }
      else if((int)timerr < 10)
      {
        textt.GetComponent<Text>().text = "0"+((int)timerr).ToString();
      }
      else
      {
        textt.GetComponent<Text>().text = ((int)timerr).ToString();
      }
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
