using UnityEngine;

public class Slime : MonoBehaviour
{
    //�ŧi�����ܼ�
    public int _health = 100; //��q�_�l�ƭȬ�100
    int _attack = 1;
    public float _moveSpeed = 1.12f;
    public bool _isDead = false;
    string _name = "�n����";

    public int Level { get; set; } = 1;
    //public int Level { get; } = 1; //�L�k�q��L�a�����
    //public int Level { get; set;} = 1; //�[�Wset�i�ƼgLevel�쥻�]�w������

    //property����ӥΪk - get return(�^��)
    //public string Name { get { return _name; } }  //�ϥγo�Ӥ�k�N�i��private�h���ŧi�A���|�ѥ~�����H�N���

    //property����ӥΪk - set value
    public string Name { get { return _name; } set { _name = value; } } //�z�Lproperty�h�Ƽg�t�@���ܼ�



    public Slime()
    {
        //Debug.Log("slime");
    }

    public void Move() //void���|�^�Ǹ��
    {
        Debug.Log("�ڷǳƲ��ʤF");
        string newLocation = GetLocation();
        Debug.Log("�ڲ��ʤF");
        Debug.Log("�ڲ��ʦn�F");
    }

    private string GetLocation()
    {
        string location = "�s����F��";
        return location; //�ŧimethod�� �^�ǵ�string���� //return�|�^�Ǩð��W���}methood
    }

    public void Attack (string playerName) //�ظ��̼W�[�ѼơA�ѥ~���M�w�M�ޱ����ܼ�
    {
        Debug.Log("�ڹ�" + playerName + "�y���F" + _attack + "�I�ˮ`");
    }

    public void TakeDamage(int damage)
    {
        _health = _health - damage; //�������䬰�Ƽg�A�k�䬰Ū��
        Debug.Log("�ڪ��ͩR�Ȭ� : " + _health);
    }
}


