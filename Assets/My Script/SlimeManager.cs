using UnityEngine;

public class SlimeManager : MonoBehaviour
{
    Slime _slime; //�x�sslime���������
    Slime _slime2;
    Slime _slime3;
    int _number;
    void Start() //�w�]����private 
    {
        /*_slime = new Slime();
        _slime._health = 21;
        _slime._name = "���J�O";

        _slime2 = new Slime();
        _slime2._health = 22;
        _slime2._name = "�@��";

        _slime3 = new Slime();
        _slime3._health = 23;
        _slime3._name = "����";

        Debug.Log("�ڥs" + _slime._name + "�ڦ�" + _slime._health + "�w��q!");
        Debug.Log("�ڥs" + _slime2._name + "�ڦ�" + _slime2._health + "�w��q!");
        Debug.Log("�ڥs" + _slime3._name + "�ڦ�" + _slime3._health + "�w��q!");*/

        /*-------------------------------------------------------------------------------------------*/

        /*_slime = new Slime();
        _slime.Level = 2;
        Debug.Log("����" + _slime.Level);
        Debug.Log("Name" + _slime.Name);

        _slime.Name = "����";*/

        /*-------------------------------------------------------------------------------------------*/

        /*_slime = new Slime();
        _slime.Move();
        _slime.Attack("�s�Ӫ��s��");*/

        /*-------------------------------------------------------------------------------------------*/

        _slime = new Slime();
        _slime.TakeDamage(1);




    }


}
