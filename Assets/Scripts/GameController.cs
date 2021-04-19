using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Mental").Length;
        int count1 = GameObject.FindGameObjectsWithTag("Ball").Length;

        if (count == 0)
        {
            GameObject obj = GameObject.Find("Ball");
            Destroy(obj);
            StartCoroutine(DelayMethod(1.0f, () =>
            {
                SceneManager.LoadScene("ClearScene");
            }));
        }
        if (count1 == 0 && count != 0)
        {
            StartCoroutine(DelayMethod(1.0f, () =>
            {
                SceneManager.LoadScene("GameOverScene");
            }));
        }

    }
    /// <summary>
    /// 渡された処理を指定時間後に実行する
    /// </summary>
    /// <param name="waitTime">遅延時間[ミリ秒]</param>
    /// <param name="action">実行したい処理</param>
    /// <returns></returns>
    private IEnumerator DelayMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }
}
