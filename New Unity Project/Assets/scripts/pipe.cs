using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : floor
{
    private void OnBecameInvisible()
    {
        print("看不到");

        Destroy(gameObject, 2);  //刪除(物件,延遲時間)gameObject
    }

    //在所有相機看到呼叫一次
    private void OnBecameVisible()
    {
        print("看到了");
    }
}
