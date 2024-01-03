using UnityEngine;

public class SlimeManager : MonoBehaviour
{
    Slime _slime; //儲存slime種類的資料
    Slime _slime2;
    Slime _slime3;
    int _number;
    void Start() //預設都為private 
    {
        /*_slime = new Slime();
        _slime._health = 21;
        _slime._name = "巧克力";

        _slime2 = new Slime();
        _slime2._health = 22;
        _slime2._name = "咖啡";

        _slime3 = new Slime();
        _slime3._health = 23;
        _slime3._name = "香草";

        Debug.Log("我叫" + _slime._name + "我有" + _slime._health + "滴血量!");
        Debug.Log("我叫" + _slime2._name + "我有" + _slime2._health + "滴血量!");
        Debug.Log("我叫" + _slime3._name + "我有" + _slime3._health + "滴血量!");*/

        /*-------------------------------------------------------------------------------------------*/

        /*_slime = new Slime();
        _slime.Level = 2;
        Debug.Log("等級" + _slime.Level);
        Debug.Log("Name" + _slime.Name);

        _slime.Name = "辣椒";*/

        /*-------------------------------------------------------------------------------------------*/

        /*_slime = new Slime();
        _slime.Move();
        _slime.Attack("新來的新手");*/

        /*-------------------------------------------------------------------------------------------*/

        _slime = new Slime();
        _slime.TakeDamage(1);




    }


}
