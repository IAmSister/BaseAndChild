

using System.Runtime.Serialization.Formatters;

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Games.GlobeDefine;
using Games.Scene;
using GCGame;
using GCGame.Table;
using System;
using Games.LogicObj;
public class BaseAttr
{

}
public partial class Obj_MainPlayer : Obj_OtherPlayer
{
    // ����ģ�����
    private static int m_originalModelID = -1;
    public static int OriginalModelID { set { m_originalModelID = value; } get { return m_originalModelID; } }
    private static int m_changeModelID = -1;
    public static int ChangeModelID { set { m_changeModelID = value; } get { return m_changeModelID; } }
    public static BaseAttr m_BaseAttr;
    public Obj_MainPlayer()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_MAIN_PLAYER;
        m_BaseAttr = new BaseAttr();

    }

    public bool Init(Obj_Init_Data initData)//override
    {
        //���ǽ���Init��ʱ�����һ��Unload����
        Resources.UnloadUnusedAssets();
        LastHeartBeatTime = -1;
        return true;
    }
    void Awake()
    {
        if (null == m_ObjTransform)
        {
            m_ObjTransform = transform;
        }
    }

    
    private UInt64 m_CurUseMountItemGuid;

    public float LastHeartBeatTime = -1;
    void Start()
    {
        //��ʼ���Զ���Ϣ
        //�������Ϣ
        //�������
        //��������ͷ����ʾ HP MP XP LEVEL FORCE Stealth  ���� pk ��ұ��� �ؾ��� cd
        //�ڼ����Ļ� ��PK���� ���ڸ��¹���֮ǰ
        //������ݳ�
        //��ʼÿ����һ�ε�ѭ�� StartCoroutine(UpdatePerMinute());
        //��ҵ���� �ӳ�
        //����ǰ�׿
        //��ʼÿ��һ�ε�ѭ��


        //��ʼÿ����һ��ѭ��
        //��Թһ����������������ǹһ�״̬�������һ����һ�ε�ϵͳ����
        //����Obj_MainPlayer�߼�����
    }
    float updateSecondStep = 0;
    /// <summary>
    /// ���
    /// </summary>
    void UpdateSecond()
    {
        //����ʱ��

        //���ָܻ�����ʱ
        //��һ���  �����Զ����  ��ǰѡ��Ŀ�������

    }
    /// <summary>
    /// ��ʱ����
    /// </summary>
    void Update()
    {
        //��� ÿ����õ��߼�
        //�������
        //Ŀ��������ƶ�
        //�Ṧ
        //����
        //״̬
    }
    public class PlayerData
    {

    }
    PlayerData m_playDataTool = null;
    void FixedUpdate()
    {
        //���¶���״̬
        //���� ��� ���� ...
        // ����   
        //�漰�߼����º���
        //ͬ��λ�ø�Server�������
        //���ðѪ��
        //���ܽ������
        //�Զ�ս�� �ж�״̬���
       
    }

    //������ҽű�
    void UpdateStep()
    {
        //�����ﲥ����������
        //  û��  ��������ܲ�����    
    }

    public static float m_fTimeSecond = Time.realtimeSinceStartup;
    void UpdateReliveEntryTime()
    {
       
    }
    /// <summary>
    /// �������ͬ�����ͬ��λ����Ϣ���
    /// </summary>
    const float m_fSyncPosTimeInterval = 0.2f;
    float m_fLastSyncPosTime = 0.0f;
    Vector3 m_fLastSyncPos = new Vector3(0.0f, 0.0f, 0.0f);
    public UnityEngine.Vector3 LastSyncPos
    {
        get { return m_fLastSyncPos; }
        set { m_fLastSyncPos = value; }
    }
    //ͬ��λ����Ϣ��Server
    void SyncPosToServer()
    {
        //�Ṧ״̬�²�ͬ��
        //���ܺ����Ƿ��ƶ�
        //�����һ��ͬ��������͵�ǰ�����Ƿ��в��
        //��Objͬ�������޸ģ�����CG_MOVE��
    }

    public  BaseAttr BaseAttr //override
    {
        //���ε��Լ��� m_BaseAttr������GameManager�ж�ȡ����֤�г�����Ȼ����
        get { return  null; }
        set { BaseAttr = value; }
    }
    /// <summary>
    ///  ResourceManager �����������
    /// </summary>
    void InitNameBoard()
    {

    }
    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="objNameBoard"></param>
    void OnLoadNameBoard(GameObject objNameBoard)
    {
            //��������ʾ ����  ����  vip
    }
    public override void UpdateVipInfo()
    {
        base.UpdateVipInfo();
        OnVipCostChange();
    }

    public void ShowPlayerTitleInvestitive()
    {
    }
    /// <summary>
    /// ����
    /// </summary>
    public void UpadatePlayerGBState()
    {
        if (null != m_playerHeadInfo)
        {
          //  m_playerHeadInfo.UpdateGuildBusinessIcon(GuildBusinessState);
        }
    }

    /// <summary>
    /// ��ҵ�½�ӿ�
    /// </summary>
    public void OnPlayerLogin()
    {
    }

    /// <summary>
    /// �л��������ýӿ�
    /// </summary>
    public void OnPlayerEnterScene()
    {
        //���ó�ʼλ��
        //���֮����Ϊ��ȡPlayerDataPool�е�λ��
        //�����ؾ�������,�������Ṧ
        //�������ҡ�˿������
        //�������������������
        //�������AI���
        //��ʼ��Ѱ·����
        //��ʼ����Ч
        //��ʼ��RoleBaseID
        //��ʼ��ServerID
        //������idΪ���齭��ʱ�����ָ·��ͷ
    }
    public  void UpdateAttrBroadcastPackt(GC_BROADCAST_ATTR packet)//override
    {
        base.UpdateAttrBroadcastPackt(packet);

    }
    public void ChangeHeadPic()
    {
    }
    public void OnPlayerLeaveScene()
    {
    }
    public class CameraController
    {

    }
    /// <summary>
    //��������
    /// </summary>
    private CameraController m_CameraController = null;



    void UpdateCameraController()
    {

    }
    /// <summary>
    /// �ƶ��Ͷ������
    /// </summary>
    protected override void OnMoveOver()
    {
        //�ƶ�������������ִ���Ŀ��NPC��������ƶ�������Ĳ���
        //Ŀǰ�ݶ����֣�
        //1.�ѷ�NPC��ʼ�Ի�����
        //2.�з�NPC��ʼ��������
        //����ǵط�NPC����ʼ����
        //������ѷ�NPC����ʼ�Ի�
        //�����ƶ����¼�
        //�ƶ�Ȧ��ʧ
    }

    /// <summary>
    /// Ŀ��ѡ���߼�
    /// </summary>
    private Obj_Character m_selectTarget = null;      //ѡ���Ŀ��
    public Obj_Character SelectTarget
    {
        get { return m_selectTarget; }
        set { m_selectTarget = value; }
    }
    private bool m_onSelectForClick = false;//��Ǵӵ��ѡ���Ŀ��
    public bool OnSelectForClick
    {
        get { return m_onSelectForClick; }
        set { m_onSelectForClick = value; }
    }

    public void OnSelectTargetForClick(GameObject targetObj, bool isMoveAgainSelect = true)
    {
        m_onSelectForClick = true;
        OnSelectTarget(targetObj, isMoveAgainSelect);
    }
    /// <summary>
    /// ѡ������
    /// </summary>
    /// <param name="targetObj"></param>
    /// <param name="isMoveAgainSelect"></param>
    public void OnSelectTarget(GameObject targetObj, bool isMoveAgainSelect = true)
    {
        //���targetObjΪ�գ������ȡ��ѡ���߼�
        //���֮ǰ�Ѿ�ѡ�����ƶ���ȥ
        //��ȡĿ�������������
        //�����ƶ��߼��޸�Ϊnpc��ȥ���ֲ���ȥ
        //�Ƕ���
        //�޸ı�������Ŀ����ͻȻת������             
        //���ѡ���Ŀ���ڲ��ż��ܷ�Χ����Ч �л�Ŀ��ʱ�� �޸���Ч���ŵĶ���
      
        //������������ ���͵���Ŀ�������id
       
    }
    /// <summary>
    /// ����ѡ��Ŀ����ͷ
    /// </summary>
    public void UpdateSelectTarget()
    {
        //����Ŀ��ѡȡ����
        //����Ϊ11
        //�ٴθ���Ŀ��ѡ���Ƿ�Ϊ�������
        //����֮ǰ�Ĺ��ƣ�һ����Ļ�Ŀ�ȴ��Ϊ������ȵ�1/3~1/2�����Ե������NPC�ľ���Ϊ������ȵ�1/6��ʱ�򣬽���ȡ��ѡ���߼�
       
    }
    /// <summary>
    /// ������� �������������ȡ
    /// </summary>
    public int MountID
    {
        get { return 0; }
        set { MountID = value; }
    }

    /// <summary>
    /// ������
    /// </summary>
    /// <param name="nMountID"></param>
    public override void RideOrUnMount(int nMountID)
    {
        base.RideOrUnMount(nMountID);
      
    }
    // �Ƿ�װ������
    public int GetEquipMountID()
    {
        return 0;
    }
    /// <summary>
    /// ������
    /// </summary>

    //��ǰ�ٳ���������objid
    private int m_nCurFellowObjId = -1;
    public int CurFellowObjId
    {
        get { return m_nCurFellowObjId; }
        set { m_nCurFellowObjId = value; }
    }

    /// <summary>
    /// ��ǰ�ٳ����
    /// </summary>
    /// <returns></returns>
    public Obj_Fellow GetCurFellow()
    {
        //�Ҹ�������id
        return null;
    }

     /// <summary>
     /// �Զ�ʹ��homo
     /// </summary>
    public void AutoUseHPMPDrug()
    {
        //���ùһ�,�Զ���ҩ tt198507���һ�Ҳ�����Զ���ҩ
        //��������������
        //����ѡ��ҩ
        //���ùһ�,�Զ���ҩ tt198507���һ�Ҳ�����Զ���ҩ
    }

    public bool isUp = false;
    /// <summary>
    /// Ѫ���仯��Ĳ���
    /// </summary>
    public void OptHPChange()  //override
    {
        //����Ѫ��
    }
    /// <summary>
    /// �����仯��Ĳ���
    /// </summary>
    public void OptMPChange()// //override
    {
        //�ı�MP
    }
    /// <summary>
    ///XP�仯��Ĳ���
    /// </summary>
    public  void OptXPChange() //override
    {
        //��ӵ�ͼ�Ƿ�����ʹ��xp�����ж�
       

    }
    /// <summary>
    /// VIP ��������������
    /// </summary>
    public void OnVipCostChange()
    {
    }

    private int m_lastLevel = -1;
    /// <summary>
    /// �ȼ��仯��Ĳ���
    /// </summary>
    public void OptLevelChange()//  override
    {
        //����50id��Ч
        //����������濪�� ˢ���±�����Ʒ��ʾ�������Ƿ����㼶����б�죩
        //vip2��ʱ��ѡ���Զ�ǿ��
        // ������ʱ���SDKͬ��һ�µ�ǰ��ɫ��Ϣ
    }
    /// <summary>
    /// ͷ��仯��Ĳ���
    /// </summary>
    public void OptHeadPicChange()//override
    {
       
    }
    /// <summary>
    /// ���ֱ仯��Ĳ���
    /// </summary>
    public void OptNameChange()// override
    {
        //���µ�½������Ϣ
    }

    public  void OnExpChange() //override
    {
      
    }

    public void OnOffLineExpChange()
    {
      
    }
    /// <summary>
    /// �����仯��Ĳ���
    /// </summary> override
    public void OptForceChange()
    {
        base.OptForceChange();
        //������Χ���������ɫ
    }

    public void AskCombatValue(bool bPowerRemind)
    {
      
    }

    //�������
    private int m_nReliveEntryTime = 0;//��¼����ʣ����
    public int ReliveEntryTime
    {
        get { return m_nReliveEntryTime; }
        set { m_nReliveEntryTime = value; }
    }
    public  bool OnCorpse() //override
    {
        base.OnCorpse();
        // ���� ��������UI
        return true;
    }


    /// <summary>
    /// Obj����ʱ�����
    /// </summary>
    /// <returns> override</returns>

    public bool OnDie()
    {

        // ���� ��������UI

        // �������ֹͣ�Զ�Ѱ·
        return true;
    }
    /// <summary>
    /// ����
    /// </summary>
    /// <returns>override</returns>
    public bool OnRelife() 
    {
        base.OnRelife();
       
        // ���� �رո���UI
        return true;
    }
    public override void OptChangPKModle()
    {
        base.OptChangPKModle();
        //������Χ���������ɫ
      
        //��ʾ��ͬ״̬�İ�ť
       
    }
    /// <summary>
    /// ��ȡ���������ɫ
    /// </summary>
    /// <returns>override</returns>
    public  Color GetNameBoardColor()
    {

        return new Color();
    }

    private bool m_bIsInModelStory = false;
    public bool IsInModelStory
    {
        get { return m_bIsInModelStory; }
        set { m_bIsInModelStory = value; }
    }

    private bool m_bIsNoMove = false;
    public bool IsNoMove
    {
        get { return m_bIsNoMove; }
        set { m_bIsNoMove = value; }
    }

    public void SendNoticMsg(bool IsFilterRepeat, string strMsg, params object[] args)
    {
       // GUIData.AddNotifyData2Client(IsFilterRepeat, strMsg, args);
    }

    //����Ƿ�����ⲿ�ƶ�ָ��
    public bool IsCanOperate_Move()
    {
         //ʹ�õļ����� �����ƶ��ͷ��Ҳ��ܱ��ƶ���� �����ƶ�

        //�а󶨸��ڵ�
       //�н�ֹ�ƶ���BUFF
        return true;
    }

    /// <summary>
    /// ����Ṧ���ִ���
    /// </summary>
    /// <param name="_event"></param>
    public override void BeginQingGong(GameEvent _event)
    {
        ReqHideFellow();
        base.BeginQingGong(_event);
        ProcessQingGongStart();
    }

    public override void EndQingGong()
    {
        base.EndQingGong();
        ProcessQingGongOver();
        ReqShowFellow();
    }

    /// <summary>
    /// ����Ṧ��ʼ֮��ǿ�Ƹ���һ���Ṧ���������
    /// </summary>
    /// <param name="pos"></param>
    public void SycQingGongPos(Vector3 pos)
    {
        //��Objͬ�������޸ģ�����CG_MOVE��
        
    }

    private int m_ModelStoryID = GlobeVar.INVALID_ID;
    public int ModelStoryID
    {
        get { return m_ModelStoryID; }
        set { m_ModelStoryID = value; }
    }
    void ProcessQingGongStart()
    {
        
    }
    void ProcessQingGongOver()
    {
       
    }

    //�д�
    public UInt64 DuelTargetGuid { set; get; }
    
    public void ReqDuel(UInt64 targetGuid)
    {
        //���������������ĳ�˼��������Ϣ
       
    }

    public void DuelWithMe(UInt64 targetGuid, string name)
    {
       
    }

    public void AgreeDuelWithOther() { DecideDuelWithOrNot(1); }
    public void RefuseDuelWithOther() { DecideDuelWithOrNot(0); }

    public void DecideDuelWithOrNot(int agree)
    {
      
    }

 
    private int m_SpcialAnimationID = -1;
    private Obj_Client m_SpcicalClient1;
    private Obj_Client m_SpcicalClient2;
    /// <summary>
    /// ��ʼ����
    /// </summary>
    /// <param name="storyID"></param>
    public void OnStartPlayStory(int storyID)
    {
       
    }

    public void RemoveAllSpicalClient()
    {
        RemoveSpicalClient(1);
        RemoveSpicalClient(2);
    }

    public void OnPlayStoryOver(int storyID)
    {
       
    }

    private void RemoveSpicalClient(int idx)
    {
        
    }

    public void ProcessQingGongCharAsycLoadOver(object param1, object param2)
    {
    }

    public void ProcessQingGongBossAsycLoadOver(object param1, object param2)
    {
        
    }

    public void ProcessCharFastMoveToMainPlayerAsycLoadOver(object param1, object param2)
    {
        
    }
    public void FastMoveToMainPlayer(Obj_Client oclient, float diffZ)
    {
        
    }

    public void ProcessCharPlayAnimationAsycLoadOver(object param1, object param2)
    {
       
    }

    public int CurFashionID
    {
        get { return 0; }
        set { CurFashionID = value; }
    }

    public override int ModelVisualID
    {
        get { return 0; }
        set { ModelVisualID = value; }
    }

    public void InitYanMenGuanWaiVisual()
    {
    
    }

    private int m_nCopySceneId = -1;
    private int m_nCopySceneSingle = -1;
    private int m_nCopySceneDifficult = -1;
    public void SendOpenScene(int nSceneId, int nSingle, int nDifficult)
    {
       
    }
    public void OnOpenCopySceneOK()
    {
        // ��Ӹ��� ���ж��� �����Ƕӳ�
       
    }
    public void OnOpenCopySceneNO()
    {

    }

    // ����ҵȼ����Ű�ť
    void LevelUpButtonActive()
    {
       
    }

    void InitLevelButtonActive()
    {
    }

    // ���ָܻ�����ʱ
    private float m_StaminaCoutDownTimer = GlobeVar.INVALID_ID;

    public int GetStaminaFull()
    {
        return 0;
        //return (int)GlobeVar.MAX_STAMINA + BaseAttr.Level;
    }

    void StaminaTimerFunc()
    {
           
    }
    public class OtherRoleViewLogic
    {
        private static OtherRoleViewLogic m_Instance = null;
        public static OtherRoleViewLogic Instance()
        {
            return m_Instance;
        }

        public enum CONTENT_TYPE
        {
            CONTENT_TYPE_INVALID = -1,
            CONTENT_TYPE_ATTR = 0,        // ����
            CONTENT_TYPE_GEM,             // ��ʯ
        }

        public enum OPEN_TYPE
        {
            OPEN_TYPE_INVALID = -1,
            OPEN_TYPE_FRIEND = 0,        // ͨ�����ѽ���򿪵�
            OPEN_TYPE_POPMENU = 1,
            OPEN_TYPE_LASTSPEAKER = 2,
            OPEN_TYPE_TEAM = 3,
            OPEN_TYPE_NUM,             // 
        }
    }

    public void ReqViewOtherPlayer(UInt64 targetGuid, OtherRoleViewLogic.OPEN_TYPE oPenType)
    {
        //����������Ͳ鿴������Ϣ
     
    }
    /// <summary>
    ///  �������ػ��
    /// </summary>
    public void ReqHideFellow()
    {
       //����������
    }
    /// <summary>
    /// ������ʾ���
    /// </summary>
    public void ReqShowFellow()
    {
        //������ʾ��� Ctog
     
    }

    public bool IsInJianYu()
    {
        return false;
    }

    //����״̬�ж�
    public bool IsInGuildBusiness()
    {
        return (GuildBusinessState == 1 || GuildBusinessState == 2);
    }

    public bool IsGBCanAccept()
    {
      
        return false;
    }
    public class GameItem { }
    /// <summary>
    /// ʹ����Ʒ
    /// </summary>
    /// <param name="item"></param>
    public void UseItem(GameItem item)
    {
        
        UseMountItem(item);
    }

    void UseMountItem(GameItem item)
    {

            //�Ѿ�ӵ����������
        
    }

    void OnUseMountItemOk()
    {
        //CG_USE_ITEM �ͻ��˷��� ��m_CurUseMountItemGuid
     
    }

    public bool CheckUseItem(GameItem item)
    {
     
        return false;
    }

    public void EquipItem(GameItem item)
    {
       
    }

    public bool CheckEquipItem(GameItem item)
    {
        return true;
    }

    public void UnEquipItem(GameItem item)
    {
        //�����Ƿ��пռ�
    }

    public bool CheckUnEquipItem(GameItem item)
    {
        return true;
    }

    public void ThrowItem(GameItem item)
    {
    }

    public bool CheckThrowItem(GameItem item)
    {
        return true;
    }

    //��ʯ���Ƿ����㼶������
    public bool CheckLevelForGemSlot(int slotindex)
    {
       
        return true;
    }

    //��װ��λ�Ƿ�������ͬ���Ա�ʯ
    public bool IsSameGemForEquipSlot(int gemId, int equipSlot)
    {
       

        return false;
    }
    public void InitCangJingGeInfo()
    {
       
    }

    public void CangKuPutIn(GameItem item)
    {
        //CG_PUT_ITEM_STORAGEPACK 
       
    }

    public void CangKuTakeOut(GameItem item)
    {
        //CG_TAKE_ITEM_STORAGEPACK
      
    }

    public int GetTotalEquipCombatValue()
    {
       
        return 0;
    }

    public int GetTotalGemCombatValue()
    {
       
        return 0;
    }

    public int GetTotalFellowCombatValue()
    {
        
        return 0;
    }

    public void updateWeaponPoint()
    {

    }
    /// <summary>
    /// // ��������
    /// </summary>
    /// <returns></returns>

    public Tab_WeaponModel reloadWeaponPath()
    {

        return new Tab_WeaponModel();
    }

    public void changeWeaponPath(string weaponUrl, int tempIndex)
    {
       
    }

    private int breakStandTime = 50;
    private void updateBreakForActStand()
    {
     
    }
    public bool isHideWeapon = false;
    public void HideOrShowWeanpon()
    {	  

    }

}