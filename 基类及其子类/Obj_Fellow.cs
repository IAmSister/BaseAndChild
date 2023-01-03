using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;

public class Obj_Fellow : Obj_Character
{
    public Obj_Fellow()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_FELLOW;
        m_OwnerObjId = -1;
    }

    public  bool Init(Obj_Init_Data initData)//override
    {
        
        //��ʱ д���� �������÷�����
        m_ObjTransform.Rotate(Vector3.up * 135);

        //����������������Ϣ               

        //��ֹ���׷�����ﵼ�¶��������� �ѿͻ������ǻ���ٶ��޸�Ϊ������һ��
        //��ʼ��CharModelID������ȡ���ֿͻ�����Ϣ
        //���ö���·��
        //�������ְ�߶�
        //��ʼ��Ѱ·����

        //��ʼ��AutoMove����ģ��

        //��ʼ����������Ҫ��AnimationFilePath����ֵ�����

        //AnimLogic = gameObject.GetComponent<AnimationLogic>();
        //��ʼ����Ч
        //�ٳ�������Ч

        //������Ч ��ΪUI�ٻ���ť��

        return false;
    }

    /// <summary>
    /// �����������
    /// </summary>
    void OnBecameVisible()
    {
        //�����Ƿ����ӿ��ڱ��λ��Ϊ����ϵͳ�Ż��жϱ�ʶ
        //��ʾ���ְ�
        //��ʾģ�� 
    }

    /// <summary>
    /// �뿪��������
    /// </summary>
    void OnBecameInvisible()
    {
        //�����Ƿ����ӿ��ڱ��λ��Ϊ����ϵͳ�Ż��жϱ�ʶ
        //�������ְ�
        //����ģ��
    }

    /// <summary>
    /// ����Obj_Fellow�߼�����
    /// </summary>
    void FixedUpdate()
    {
        //���ǻ���ƶ�
        //���ܽ������  
    }

    void InitNameBoard()
    {
       // ResourceManager.LoadHeadInfoPrefab(UIInfo.FellowHeadInfo, gameObject, "FellowHeadInfo", OnLoadNameBoard);
    }

    void OnLoadNameBoard(GameObject objNameBoard)
    {
      
    }

    public  Color GetNameBoardColor()//override
    {
        //������ָ���Ʒ�ʾ���
        return new Color();
    }

    /// <summary>
    /// ���Ʒ��
    /// </summary>
    private int m_Quality;
    public int Quality
    {
        get { return m_Quality; }
        set { m_Quality = value; }
    }

    private int m_OwnerObjId;
    public int OwnerObjId
    {
        get { return m_OwnerObjId; }
        set { m_OwnerObjId = value; }
    }

    /// <summary>
    /// �Ƿ����ǵĻ��
    /// </summary>
    public bool IsOwnedByMainPlayer()
    {
       
        return false;
    }

    /// <summary>
    /// �����ǻ��ͻ����ٶ�����Ϊ������һ��
    /// </summary>
    public void SetMoveSpeedAsMainPlayer()
    {
       
    }

    private void UpdateFellowMove()
    {
        //�ж��Ƿ���ս��
        //����̫Զ ֱ������ȥ
    }

    private Vector3 GetFellowPos(Obj_MainPlayer mainPlayer)
    {
        //����λ��

        //���ǳ���

        //��ת

        //ƽ��

        return Vector3.back ;
    }

}
