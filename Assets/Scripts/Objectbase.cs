﻿using UnityEngine;
using System.Collections;

// 要求元件(類型())
// 套用腳本時會執行
[RequireComponent(typeof(AudioSource))]
public class Objectbase : MonoBehaviour
{
    [Header("移動速度"), Range(1, 500)]
    public float speed = 10;
    [Header("音效")]
    public AudioClip sound;
    [Header("音量")]
    public float volume = 1;
    [Header("開始延遲時間")]
    public float delay = 0.1f;

    /// <summary>
    /// 喇叭
    /// </summary>
    protected AudioSource aud;

    protected virtual void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    /// <summary>
    /// 動作：由小孩 (子類別) 決定內容
    /// protected 允許小孩 (子類別) 存取，外部無法存取
    /// virtual 允許小孩 (子類別) 複寫 (改寫內容或添加內容)
    /// </summary>
    protected virtual IEnumerator Action()
    {
        yield return null;
    }

    /// <summary>
    /// 開始動作
    /// </summary>
    public void StartAction()
    {
        StartCoroutine(Action());      // 啟動協程
    }
}
