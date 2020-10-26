using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    //ユニティちゃんを格納するための変数
    public GameObject player;
    // //テキストを格納するための変数
    // public GameObject text;
    //RestartManager型
    public RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス生成
        // restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }

    //当たり判定関数
    private void OnTriggerEnter(Collider other)
    {
        //当たってきたオブジェクトの名前がユニティちゃんの名前と同じとき
        if (other.name == player.name)
        {
            restart.PrintGameOver("Goal !!!\nTap to restart.");
        }
    }
}
