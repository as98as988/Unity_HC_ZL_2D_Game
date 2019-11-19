using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMethod1 : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    private string PrintName(string name)
    {
        return "hi~" + name + "你好";
    }

    private void Drive(int speed)
    {
        print("引擎音效");
        print("車正在往前開,時速:" + speed);
    }


    private void Shoot(int count, string direction = "前方", string prop = "無")
    {
        print("弓箭數量:" + count);
        print("弓箭方向:" + direction);
        print("弓箭屬性:" + prop);
    }
    private void Start()
    {
        Drive(100);
        Drive(200);
        Shoot(1);
        Shoot(100, "前後");
        Shoot(3, prop: "火屬性");

        string pn = PrintName("KID");
        print(pn);
        print(PrintName("guava"));
    }
}
