using UnityEngine;

public class LearnIf : MonoBehaviour
{

    public bool openDoor;
    public int score = 100;

    public int combo = 0;
    public int attack = 10;

    private void Start()
    {
        // 語法 : if (布林值) { 陳述式或演算法 }
        // () 內的布林值為 true 執行 { }
        if (true)
        {
            print("測試!");
        }
    }
    private void Update()
    {
        #region if
        if (openDoor)
        {
            //   if () 內的布林值為 true 執行 if { }
            print("開門");
        }
        else
        {
            //  if () 內的布林值為 false 執行 else { }
            print("關門");
        }


        if (score >= 60 )
        {
            print("及格");
        }
        else if (score >= 50)
        {
            print("可以補考~");
        }
        else if (score >= 40)
        {
            print("可以付錢補考~");
        }
        else
        {
            print("被當惹");
        }
        #endregion

        if(combo>=50 && combo <= 99)
        {
            attack = attack * 2;
            print(attack);
        }
        else if (combo >= 100 && combo <= 149)
        {
            attack = attack * 5;
            print(attack);
        }
        else if(combo>=150)
        {
            attack = attack * 10;
            print(attack);
        }
        else
        {
            attack = 10;
            print(attack);
        }


    }
}
