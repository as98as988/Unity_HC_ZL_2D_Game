using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{


    [Header("速度"), Range(0, 100f)]
    public float speed = 10.5f;
    [Header("變形")]
    public Transform tran;

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void Move()
    {
        tran.Translate(-speed * Time.deltaTime, 0, 0);   
    }
    private void Update()
    {
        Move();
    }
}
