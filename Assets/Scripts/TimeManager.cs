using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    //時間表示用テキスト
    public Text timeText;
    //制限時間
    private float score = 0;
    //ゲームオーバー表示用テキスト
    // public GameObject text;
    // //ユニティちゃん格納用
    // public GameObject player;

    //RestartManager型
    public RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        //インスタンス生成
        // restart = new RestartManager(player, text);
        timeText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームオーバーしていて画面がクリックされたとき
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
        if (restart.IsGameOver())
        {
            return;
        }
        score += Time.deltaTime;
        timeText.text = "Score: " + score.ToString("f1");
        // timeText.text = restart.IsGameOver().ToString();
    }
}