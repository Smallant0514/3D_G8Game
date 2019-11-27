using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 定義方法
    // 語法:
    // 修飾詞 傳回類型 方法名稱 (參數) { 陳述式或演算法 }
    // 參數類型 參數名稱
    // void 無傳回
    // 自定義方法需要被呼叫
    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed">開車的速度</param>
    private void Drive(int speed)
    {
        // 輸出訊息(字串)
        print("音效~");
        // 可使用 + 號串接字串與其他類型
        print("開車,時速:" + speed);
    }

    // 有預設值的參數 選填式參數，呼叫時可不填寫
    // 有選填式參數只能寫在最右邊
    public void Shoot(int count,float speed,string prop = "無",string direction = "前方")
    {
        print("弓箭數量:" + count);
        print("弓箭速度:" + speed);
        print("弓箭屬性:" + prop);
        print("弓箭方向:" + direction);

    }

    private int Square()
    {
        return 2 * 2;
    }
    //private int Square(int number = 2)
    //{
    //    return number * number;
    //}



    // 事件 : 在指定的時間會以指定次數執行的方法
    // 初始事件 : 遊戲播放後執行一次
    private void Start()
    {
        print("哈囉，沃德~");

        Drive(200); // 呼叫自訂方法 寫幾次就叫幾次 需給予對應的引數
        Drive(300); // 裡面數字傳回到上面寫的speed 

        Shoot(1, 1.5f);
        Shoot(10,10.5f,"火屬性");
        Shoot(3, 2, direction: "前後方"); // 用指名的方式設定參數


        print(Square());  //當成傳回類型使用

        int result = Square();  //存放在區域欄位內
        print(result);

        // int result = Square(9);
        // print(result);

    }
}
