using UnityEngine;

public class Slime : MonoBehaviour
{
    //宣告指派變數
    public int _health = 100; //血量起始數值為100
    int _attack = 1;
    public float _moveSpeed = 1.12f;
    public bool _isDead = false;
    string _name = "軟綿綿";

    public int Level { get; set; } = 1;
    //public int Level { get; } = 1; //無法從其他地方改變
    //public int Level { get; set;} = 1; //加上set可複寫Level原本設定的等級

    //property有兩個用法 - get return(回傳)
    //public string Name { get { return _name; } }  //使用這個方法就可用private去做宣告，不會由外部做隨意更改

    //property有兩個用法 - set value
    public string Name { get { return _name; } set { _name = value; } } //透過property去複寫另一個變數



    public Slime()
    {
        //Debug.Log("slime");
    }

    public void Move() //void不會回傳資料
    {
        Debug.Log("我準備移動了");
        string newLocation = GetLocation();
        Debug.Log("我移動了");
        Debug.Log("我移動好了");
    }

    private string GetLocation()
    {
        string location = "新手村東邊";
        return location; //宣告method時 回傳給string的值 //return會回傳並馬上離開methood
    }

    public void Attack (string playerName) //誇號裡增加參數，由外部決定和操控的變數
    {
        Debug.Log("我對" + playerName + "造成了" + _attack + "點傷害");
    }

    public void TakeDamage(int damage)
    {
        _health = _health - damage; //等號左邊為複寫，右邊為讀取
        Debug.Log("我的生命值為 : " + _health);
    }
}


