using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public static int score = 0;
    // public GameObject aa;
    // float currentime;
    // float startingtime = 10f;
    //
    // void Start()
    // {
    //   currentime = startingtime;
    //   aa.GetComponent<Text>().text = currentime;
    // }
    // void Update()
    // {
    //   currentime -= 1*Time.deltaTime;
    //   aa.GetComponent<Text>().text = ToString(currentime);
    // }

    // public gameObject aa;
    // Color ocolor = new Color(255f, 255f, 255f, 255f);
    // if (this.gameObject.renderer.material.color == ocolor)
    // {
    //   print("worksssssss");
    // }
    // public void setcolortoblack()
    // {
    //   print("works");
    //     // mat.SetColor("_Color", Color.red);
    //   if(mat1.GetColor("_Color") == mat1.GetColor("_Color"))
    //   {
    //     print("matchinggg worksss");
    //   }
    //   else
    //   {
    //     print("no matching");
    //     // mat.SetColor("_Color", Color.(mat1.GetColor("_Color")));
    //   }
    // }

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

    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material ref1;
    public GameObject textt;



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


    public void fun2()
    {
      int num = unirand(0,8);
      if(mat2.GetColor("_Color") == ref1.GetColor("_Color"))
      {
        score+=1;
        mat1.SetColor("_Color", pile1c[num]);
        mat2.SetColor("_Color", pile2c[num]);
        mat3.SetColor("_Color", pile3c[num]);
        mat4.SetColor("_Color", pile4c[num]);
        ref1.SetColor("_Color", refc[num]);
      }
    }
    public void fun1()
    {
      // print(unirand(0,8));
      // mat1.SetColor("_Color", aa[unirand(0,8)]);
      int num = unirand(0,8);
      if(mat1.GetColor("_Color") == ref1.GetColor("_Color"))
      {
        score+=1;
        mat1.SetColor("_Color", pile1c[num]);
        mat2.SetColor("_Color", pile2c[num]);
        mat3.SetColor("_Color", pile3c[num]);
        mat4.SetColor("_Color", pile4c[num]);
        ref1.SetColor("_Color", refc[num]);
      }
    }

    public void fun3()
    {
      int num = unirand(0,8);
      if(mat3.GetColor("_Color") == ref1.GetColor("_Color"))
      {
        score+=1;
        mat1.SetColor("_Color", pile1c[num]);
        mat2.SetColor("_Color", pile2c[num]);
        mat3.SetColor("_Color", pile3c[num]);
        mat4.SetColor("_Color", pile4c[num]);
        ref1.SetColor("_Color", refc[num]);
      }
    }
    public void fun4()
    {
      score+=1;
      int num = unirand(0,8);
      if(mat4.GetColor("_Color") == ref1.GetColor("_Color"))
      {
        mat1.SetColor("_Color", pile1c[num]);
        mat2.SetColor("_Color", pile2c[num]);
        mat3.SetColor("_Color", pile3c[num]);
        mat4.SetColor("_Color", pile4c[num]);
        ref1.SetColor("_Color", refc[num]);
      }
    }

    //time counter
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
