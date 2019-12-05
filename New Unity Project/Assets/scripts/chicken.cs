using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{

    

    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 800;
    [Header("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM;
    [Header("鋼體")]

    public Rigidbody2D r2d;
    public GM gm;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundAdd;
    private void Jump()
    {
        if (dead) return;//跳出此方法
        //如果按下左鍵
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("按下左鍵");

            //分數顯示
            goScore.SetActive(true);
            //GM顯示
            goGM.SetActive(true);

            r2d.gravityScale = 2;
            //鋼體重力=1
            r2d.Sleep();
            //鋼體睡覺
            r2d.AddForce(new Vector2(0, jump));
            //鋼體.增加推力(2維向量)
            aud.PlayOneShot(soundJump, 1.5f);
        }
        //velocity 鋼體加速度(x,y)左右x上下y
        print(r2d.velocity);
       //鋼體 設定角度
        r2d.SetRotation(8*r2d.velocity.y);
    }
    
 




    private void DEAD()        
    {
        if (dead) return;
        dead = true;
        gm.GameOver();
        aud.PlayOneShot(soundHit, 1.5f);
    }




    private void passpipe() 
       
    {
        if (dead) return;
        print("加分");
        gm.AddScore(1);
    }
    private void Update()
    {
        Jump();
        
    }
    //碰撞事件:碰到其他碰瘴氣開始執行一次
    private void OnCollisionEnter2D(Collision collision)
    {
        print(collision.gameObject.name);

       DEAD();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "04_水管 (1)" || collision.gameObject.name == "04_水管")
        {

            DEAD();
        }
        if(collision.gameObject.name=="加分區域")
        {
            passpipe();
        }

    }
}
