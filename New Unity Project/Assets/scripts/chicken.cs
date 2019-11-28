using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{
    
   
    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM;
    
    private void Jump()
    {
        //如果按下左鍵
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("按下左鍵");

            //分數顯示
            goScore.SetActive(true);
            //GM顯示
            goGM.SetActive(true);
        }
    }

 




    private void DEAD()        
    {
       
    }




    private void passpipe() 
       
    {
       
    }
    private void Update()
    {
        Jump();
    }
}
