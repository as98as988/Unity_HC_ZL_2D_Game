using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    
    
    [Header("目前分數")]
        public int score;
        [Header ("最高分數")]
        public int scoreheight;
    [Header("水管")]
    public GameObject pipe;//G
    [Header("介面群組")]
    public GameObject goUI;

    /// <summary>
    /// 生成水管功能
    /// </summary>
    public void SpawnPipe()
    {
        float y = Random.Range(-0.8f, 1.7f);
        Vector3 pos = new Vector3(6f, y, 0);

        Quaternion rot = new Quaternion(0, 0, 0, 0);
        //因為有繼承類別才能簡寫 
        //Object Instantiate(pipe);
        Instantiate(pipe,pos,rot);

    }
    /// <param name="add"></param>
    public void AddScore(int add)
    {

    }

    private void SetHighScore()
    {

    }

    public void GameOver()
    {
        goUI.SetActive(true);
    }
    private void Start()
    {
        // SpawnPipe();

        InvokeRepeating("SpawnPipe", 0, 1.5f);
    }
}
