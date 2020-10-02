using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Q1. 7283 x 5332 を計算してConsoleに表示してください。
        //回答例
        Debug.Log(7283 * 5332);

        //Q2. 159, 163, 182, 175, 171 の平均値を計算してConsoleに表示してください。
        //回答例
        int sum = 159 + 163 + 182 + 175 + 171;
        Debug.Log(sum / 5);
        //または
        Debug.Log((159 + 163 + 182 + 175 + 171) / 5);


        //Q3. 以下の変数a, bを使って"Hello World!"を表示してください。
        string a = "Hello";
        string b = "World!";
        //回答例
        Debug.Log(a + " " + b);
    }
}
