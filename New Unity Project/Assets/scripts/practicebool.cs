using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practicebool : MonoBehaviour
{
    public bool open;
   public int score;
    public int hit;
    void Start()
    {
        //判斷是 if(switch)
        //語法
        //(布林值){當if()布林值為true執行這裡}

        if(true)
        {
            print("嗨");
        }
    }

    
   private void Update()
    {
        if (open)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        if(score>=60)
        {
            print("及格");

        }
        else if(score>=40)
        {
            print("可補考");
        }
        else if(score>=10)
        {
            print("付錢補考");
        }
        else
        {
            print("不及格");
        }

        if(hit>=150)
        {
            print("攻擊10倍");
        }
        else if(hit>=100)
        {
            print("攻擊5倍");

        }
        else if(hit>=50)
        {
            print("攻擊2倍");
        }
        else 
        {
            print("自爆");
        }
    }
}
