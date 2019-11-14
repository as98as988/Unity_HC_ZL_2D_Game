using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;
    
    private void jump1()
    {
        print(111); 
    }



    private void Start()
    {
        jump1();
    }




    private void DEAD()        
    {
        print(123);
    }




    private void arrivepool() 
       
    {
        print(456);
    }
}
