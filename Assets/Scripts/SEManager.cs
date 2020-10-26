using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{

    public AudioClip sound_good;
    public AudioClip sound_bad;
    public AudioClip sound_clear;

    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayOK()
    {
        audioSource.PlayOneShot(sound_good);
    }
    public void PlayBad()
    {
        audioSource.PlayOneShot(sound_bad);
    }
    public void PlayClear()
    {
        audioSource.PlayOneShot(sound_clear);
    }

    // void Update()
    // {
    //     // 左
    //     if (Input.GetKey(KeyCode.LeftArrow))
    //     {
    //         audioSource.PlayOneShot(sound_good);
    //     }
    //     // 右
    //     if (Input.GetKey(KeyCode.RightArrow))
    //     {
    //         audioSource.PlayOneShot(sound_bad);
    //     }

    //     // 上
    //     if (Input.GetKey(KeyCode.DownArrow))
    //     {
    //         audioSource.PlayOneShot(sound_clear);
    //     }
    // }

}