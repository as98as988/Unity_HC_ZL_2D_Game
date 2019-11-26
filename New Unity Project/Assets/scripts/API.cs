using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API : MonoBehaviour
{
    private SpriteRenderer SpriteA;
    public Transform tranA;
    public Transform tranB;

    // Start is called before the first frame update
    void Start()
    {
        print("輸出");
        Debug.Log("輸出訊息");
       
        
        // 靜態成員：屬性的取得方式
        print(Random.value);

        // 練習取得PI
        print(Mathf.PI);

        print("隨機範圍:"+Random.Range(50.5f, 100.9f)
            
            );
        Debug.Log(true);
        Debug.LogWarning("警告");
        Debug.LogError("錯誤");

        print(tranA.position);
        print(tranB.position);
        //print(Transform.position):  錯誤

    }

    // Update is called once per frame
    void Update()
    {

        // 輸入.按鍵名稱
        print(Input.inputString);

        //練習偵測按S
        if (Input.GetKeyDown("s"))
        {
            Debug.Log(Input.mousePosition);
        }
        //非靜態方法:實體類別.方法(對應的引數)
        tranA.Rotate(0, 0, 10);
        tranA.localScale = new Vector3(5, 5, 5);
        
        SpriteA.flipX = true;
        
    }
}
