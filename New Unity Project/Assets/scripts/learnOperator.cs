using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnOperator : MonoBehaviour
{
    public int a = 10, b = 3;
    public int c = 9, d = 1;
    // Start is called before the first frame update
    private void Start()
    {
        //數學運算子
        // +-*/%
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
        print(6 / 2 * (2 + 1));

        a = a + 1;   //等號右邊先執行再存回
        print(a++);  //先輸出再遞增
        print(++a);  //相反

        b = b + 10;
        b += 10;    //適用+-*/%

        //比較運算子
        //結果為布林值
        print(c > d);
        print(c < d);
        print(c >= d);
        print(c <= d);
        print(c != d);

    }


}
