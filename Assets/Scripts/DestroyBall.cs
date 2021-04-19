using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 衝突時に呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        // 当たったゲームオブジェクトを削除する
        Destroy(collision.gameObject);
    }
}
