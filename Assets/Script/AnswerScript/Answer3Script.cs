using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer3Script : MonoBehaviour
{
    public int Answer3 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButtonStart()
    {
        Answer3 = 3;
        // コルーチンの起動
        StartCoroutine(DelayCoroutine());
    }

    // コルーチン本体
    private IEnumerator DelayCoroutine()
    {
        // 3秒間待つ
        yield return new WaitForSeconds(0.1f);

        Answer3 = 0;
    }
}
