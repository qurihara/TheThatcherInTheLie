﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class RestartManager : MonoBehaviour
{
    public GameObject player;
    public GameObject text;

    private bool isGameOver = false;

    //コンストラクタ
    public RestartManager(GameObject player, GameObject text)
    {
        this.player = player;
        this.text = text;
        text.SetActive(false);
    }
    public RestartManager()
    {
        // text.SetActive(false);
    }

    public void PrintGameOver(string msg)
    {
        //ゲームオーバーを表示する
        text.GetComponent<Text>().text = msg;
        text.SetActive(true);

        //ユニティちゃんを動けなくする
        player.GetComponent<UnityChanCustomeMoveController>().enabled = false;
        //アニメーションをオフにする
        player.GetComponent<Animator>().enabled = false;

        //ゲームオーバー
        isGameOver = true;
    }

    //シーンを再読み込みする
    public void Restart()
    {
        // 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }

    //ゲームオーバーしているかどうか確認
    public bool IsGameOver()
    {
        return isGameOver;
    }
}