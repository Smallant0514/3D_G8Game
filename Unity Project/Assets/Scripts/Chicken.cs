using UnityEngine; //引用unity API

//類別 類別名稱
public class Chicken : MonoBehaviour
{
    #region 變數方法
    // 宣告變數 (定義欄位 Field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 私人 - 隱藏 private (預設)
    // 公開 - 顯示 public

    [Header("移動速度")][Range(1,1000)] // Range 限制欄位範圍
    public int speed = 10;
    [Header("旋轉速度"),Tooltip("G8雞的旋轉速度"),Range(1.5f,200f)] // Tooltip 用在提示較長資訊
    public float turn = 2.5f;
    [Header("是否完成任務")]
    public bool mission = false;
    [Header("玩家名稱")]
    public string Name = "G8雞";
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;


    private void Update()
    {
        Turn();
        Run();
        Bark();
    }


    #region 方法區域

    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        float v = Input.GetAxis("Vertical"); // W 上 1 , S 下 -1 , 沒按 0
        // rig.AddForce(0, 0, speed * v);       // 世界座標
        // tran.forward 區域座標 Z 軸
        // tran.right   區域座標 X 軸
        // tran.up      區域座標 Y 軸
        rig.AddForce(tran.forward * speed * v * Time.deltaTime);  // 區域座標    = (0,0,1)*speed*v


    }

    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal"); // A 左 -1 , D 右 1 , 沒按 0
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }

    /// <summary>
    /// 亂叫
    /// </summary>
    private void Bark()
    {
        if (Input.GetKeyDown("space"))
        {
            ani.SetTrigger("拍翅膀觸發");
        }
    }

    /// <summary>
    /// 撿東西
    /// </summary>
    private void Catch()
    {

    }

    /// <summary>
    /// 檢視任務
    /// </summary>
    private void Task()
    {

    }
    #endregion
}