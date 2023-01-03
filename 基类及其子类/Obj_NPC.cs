using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;

public class Obj_NPC : Obj_Character
{
    protected GameObject m_MissionBoard;       // ͷ��������
    private bool m_bIsBornCreate;//�Ƿ��Ǹ�ˢ������
    private bool m_IsNameBoard = false;//����Ƿ��Ѿ���ʾ�����ְ�(��ʼ��ʱ)

    public Obj_NPC()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_NPC;
        m_listMissionID = new List<int>();
    }


    public  bool Init(Obj_Init_Data initData)//override
    {


        //��ʼ��CharModelID������ȡ���ֿͻ�����Ϣ
        //���ö���·��
        //�������ְ�߶�
        //����������������Ϣ               
      
        // NPC������
       
        //����ڳ�ʼ�����ݺ����

        //��ʼ��Ѱ·����
        //��ʼ����������Ҫ��AnimationFilePath����ֵ�����
        //��ʼ����Ч
        //�Ӽ�ͷָ��
        //���¸����һ����ģ��

        //��ʼ�����ְ�
        //InitNameBoard();

        // ���NPC�ж�
      
        return false;
    }
    private float m_fBornPosX = 0.0f;
    public float BornPosX
    {
        get { return m_fBornPosX; }
        set { m_fBornPosX = value; }
    }

    private float m_fBornPosY = 0.0f;
    public float BornPosY
    {
        get { return m_fBornPosY; }
        set { m_fBornPosY = value; }
    }

    private float m_fBornPosZ = 0.0f;
    public float BornPosZ
    {
        get { return m_fBornPosZ; }
        set { m_fBornPosZ = value; }
    }
    private int m_nProfession;      // ְҵ ����������õĺ�ģ�����NPCģ�ͣ�
    public int Profession
    {
        get { return m_nProfession; }
        set { m_nProfession = value; }
    }
    private int m_WeaponDataID;     // ��ǰ����
    public int WeaponDataID
    {
        get { return m_WeaponDataID; }
        set { m_WeaponDataID = value; }
    }
    private int m_ModelVisualID;    // ��ǰģ�����ID
    public int ModelVisualID
    {
        get { return m_ModelVisualID; }
        set { m_ModelVisualID = value; }
    }
    private int m_WeaponEffectGem;  // ������Ч��ʯ
    public int WeaponEffectGem
    {
        get { return m_WeaponEffectGem; }
        set { m_WeaponEffectGem = value; }
    }

    /// <summary>
    /// ֹͣNPC��ǰ���ŵ���Ч
    /// </summary>
    public void StopNPCEffect()
    {
        if (ObjEffectLogic != null)
        {
            ObjEffectLogic.NPCStopEffect();
        }
    }

    /// <summary>
    /// NPC���������ֵ���ܽ����ֵ
    /// </summary>
    public void PlayUnDissolve()
    { //�ܽ���Ч
       
    }

    public  bool OnDie()//override
    {

        //������Ч
        //�ܽ���Ч
     
        return true;
    }
    // ����ģ�ͻص�
    public  void OnReloadModle()//override
    {
        //���ܽ���Ч //������Ч
       
        //���Źص�BOSS ˢ�����ϼ���һ����Ч
       
    }

    /// <summary>
    /// �����������
    /// </summary>
    void OnBecameVisible()
    {
       
        //�����Ƿ����ӿ��ڱ��λ��Ϊ����ϵͳ�Ż��жϱ�ʶ
       
        //��ʾ���ְ�
      
        //��ʾģ��
        
        //����Ѿ����������л�������״̬
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

    void FixedUpdate()
    {
         //����
       
        //���ðѪ��
     
        //���ܽ������
       
    }
    //===����npc�����Ǿ�����������ͷ��
    public float m_fLastDis2MainPlayer = 0.0f; //Npc�ϴ������ǵľ���
    private Obj_MainPlayer m_mainPlayer = null;
    void AutoShowNPCDialogNear()
    { //��ǰ����NPC�ľ���
      //�Ǻ�������
      //�������������2���ڵľ��� �Զ������Ի���
      //��ͣ�����ٽ��в��� 
      //û�е����Ի�(��ѡ��)

            //�ǰ��NPC
            //��������NPC2���ڵľ��� �Զ������Ի���
            //��ͣ�����ٽ��в��� 
            //û�е����Ի�(��ѡ��)

            //�ǲֿ�NPC
            ////�������������2���ڵľ��� �Զ������Ի���
            /////��ͣ�����ٽ��в��� 
            /////û�е����Ի�(��ѡ��)

            //����npc
            //��ͣ�����ٽ��в��� 
            //û�е����Ի�(��ѡ��)
      
    }
    void InitNameBoard()
    {
      
    }

    void OnLoadNameBoard(GameObject objNameBoard)
    {
        
    }

    //////////////////////////////////////////////////////////////////////////
    //NPC�Ի���ش���
    //////////////////////////////////////////////////////////////////////////
    private int m_nDefaultDialogID = -1;        //NPC�Ի������б�
    public int DefaultDialogID
    {
        get { return m_nDefaultDialogID; }
        set { m_nDefaultDialogID = value; }
    }

    private List<int> m_listMissionID;        //NPC����ű�
    public List<int> MissionList
    {
        get { return m_listMissionID; }
    }
    void AddMissionToList(int nMissionID)
    {
        m_listMissionID.Add(nMissionID);
    }
    void ClearMissionList()
    {
        m_listMissionID.Clear();
    }
    public bool IsHaveMission(int nMissionID)
    {
        if (m_listMissionID.Contains(nMissionID))
        {
            return true;
        }

        return false;
    }
    protected override void OnMoveOver()
    {
        //������NPC �ƶ� ������� ��ʼ����

    }

    public override void OnAnimationFinish(int animationID)
    {
        base.OnAnimationFinish(animationID);
    }

    public  void OnEnterCombat(Obj_Character Attacker)//override
    {
       
    }

    public  void OnLevelCombat(Obj_Character Attacker) //override
    {
       
    }

    public void AddDialogMission()
    {
    }
    /// <summary>
    /// ���ֱ仯��Ĳ���
    /// </summary>
    public void OptNameChange()// override
    {
        //ShowNameBoard();
    }
    /// <summary>
    /// override
    /// </summary>
    public void OptForceChange()//x override
    {
       // base.OptForceChange();
    }

    public  Color GetNameBoardColor() //override
    {
     
        return new Color();
    }

    public bool IsNeedBecameVisible()
    {
      
        return true;
    }
    public  void OnBindOpt(Obj_Character obj) //override
    {
       
        //�鳵�������

    }

    private bool m_bIsGuildActivityBoss = false;    // ���Boss;
    public bool IsGuildActivityBoss
    {
        get { return m_bIsGuildActivityBoss; }
        set { m_bIsGuildActivityBoss = value; }
    }

    bool IsGuildBoss()
    {
       
        return false;
    }
}
