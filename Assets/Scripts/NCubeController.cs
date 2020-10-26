using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NCubeController : MonoBehaviour
{
    //オブジェクトの速度
    public float speed = 1;
    //ユニティちゃんを格納する変数
    public GameObject player;
    // //テキストを格納する変数
    // public GameObject text;

    //RestartManager型
    public RestartManager restart;

    public SEManager seManager;

    void Start()
    {
        //インスタンス生成
        // restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        if (!restart.IsGameOver())
        {
            //フレーム毎speedの値分だけx軸方向に移動する
            this.gameObject.transform.Rotate(speed, 0, 0);

            if (player.transform.position.z - this.gameObject.transform.position.z >= 0.5)
            {
                restart.PrintGameOver("You missed a face!\n\nGameOver...\n\nTap to restart.");
                seManager.PlayBad();
            }
        }
        else
        {
            //フレーム毎speedの値分だけz軸方向に移動する
            this.gameObject.transform.Rotate(0, speed * 2, 0);
            //ゲームオーバーしていて画面がクリックされたとき
            if (Input.GetMouseButton(0))
            {
                restart.Restart();
            }

        }

    }

    //ユニティちゃんとの当たり判定
    private void OnTriggerEnter(Collider other)
    //private void OnCollisionEnter(Collision other)
    {
        // restart.PrintGameOver(other.gameObject.name + player.name + restart.IsGameOver().ToString());
        //接触したオブジェクトがユニティちゃんのとき
        if (!restart.IsGameOver() && other.gameObject.name == player.name)
        {
            seManager.PlayOK();
            this.gameObject.SetActive(false);
        }
    }


}
