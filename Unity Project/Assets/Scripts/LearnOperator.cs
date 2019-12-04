using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    public int C = 1;
    public int D = 1, E = 1;
    public int F = 10;

    public float G = 1.5f, H = 99.9f;

    public float hp = 50;

    public bool key;
    public int enemy;

    private void Start()
    {
        #region  數學運算子
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        //  指派右邊先運算再給左邊
        C = 99 + 1;
        print(C);

        C = C + 1; // 原始寫法
        // 遞增、遞減 + -
        print(D++); // 後置遞增 : 先輸出再運算 - 看到 1 電腦內 2
        print(++E); // 前置遞增 : 先運算再輸出 - 看到 2 電腦內 2

        // 加法指派 可用於 + - * / %
        // F = F + 100 (原始寫法)
        F += 100;
        print(F);

        #endregion

        #region 比較運算子

        print(G > H);    //  false
        print(G < H);    //  true
        print(G >= H);  //  false
        print(G <= H);  //  true
        print(G == H);  //  false
        print(G != H);   //  true

        #endregion

        #region 邏輯運算子
        
        //並且 && 有一個false 結果就是 false
        print(true && true);      //  true
        print(true && false);     //  false
        print(false && true);     //  false
        print(false && false);    //  false

        // 或者 || 有一個true 結果就是 true
        print(true || true);       //  true
        print(true || false);      //  true
        print(false || true);      //  true
        print(false || false);     //  false

        //相反(顛倒)   !
        print(!true);     //  false
        print(!false);   //  true

        #endregion
    }

    private void Update()
    {
        print("死亡 : " + (hp <= 0));

        print("過關 : " + (key || enemy >= 5));
    }

}
