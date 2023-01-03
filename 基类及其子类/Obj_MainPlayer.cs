

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
    // 加载模型相关
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
        //主角进行Init的时候调用一次Unload方法
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
        //初始化自动信息
        //特殊的信息
        //名字面板
        //更新任务头像显示 HP MP XP LEVEL FORCE Stealth  名字 pk 玩家标题 藏经阁 cd
        //在监狱的话 打开PK界面 放在更新公告之前
        //玩家数据池
        //开始每分钟一次的循环 StartCoroutine(UpdatePerMinute());
        //玩家的组队 队长
        //如果是安卓
        //开始每秒一次的循环


        //开始每分钟一次循环
        //针对挂机崩溃的情况，如果是挂机状态，则进行一分钟一次的系统回收
        //更新Obj_MainPlayer逻辑数据
    }
    float updateSecondStep = 0;
    /// <summary>
    /// 秒调
    /// </summary>
    void UpdateSecond()
    {
        //更新时间

        //体能恢复倒计时
        //玩家还在  更新自动打怪  当前选中目标距离检测

    }
    /// <summary>
    /// 计时功能
    /// </summary>
    void Update()
    {
        //秒调 每秒调用的逻辑
        //相机控制
        //目标物体的移动
        //轻功
        //武器
        //状态
    }
    public class PlayerData
    {

    }
    PlayerData m_playDataTool = null;
    void FixedUpdate()
    {
        //更新动画状态
        //技能 冲锋 隐身 ...
        // 活动添加   
        //涉及逻辑更新函数
        //同步位置给Server其他玩家
        //多次冒血的
        //技能结束检测
        //自动战斗 中断状态检测
       
    }

    //更新玩家脚本
    void UpdateStep()
    {
        //有坐骑播放坐骑声音
        //  没有  播放玩家跑步声音    
    }

    public static float m_fTimeSecond = Time.realtimeSinceStartup;
    void UpdateReliveEntryTime()
    {
       
    }
    /// <summary>
    /// 向服务器同步相关同步位置信息间隔
    /// </summary>
    const float m_fSyncPosTimeInterval = 0.2f;
    float m_fLastSyncPosTime = 0.0f;
    Vector3 m_fLastSyncPos = new Vector3(0.0f, 0.0f, 0.0f);
    public UnityEngine.Vector3 LastSyncPos
    {
        get { return m_fLastSyncPos; }
        set { m_fLastSyncPos = value; }
    }
    //同步位置信息给Server
    void SyncPosToServer()
    {
        //轻功状态下不同步
        //技能核心是否移动
        //检查上一次同步的坐标和当前坐标是否有差距
        //新Obj同步机制修改，改用CG_MOVE包
    }

    public  BaseAttr BaseAttr //override
    {
        //屏蔽掉自己的 m_BaseAttr，而从GameManager中读取，保证切场景依然存在
        get { return  null; }
        set { BaseAttr = value; }
    }
    /// <summary>
    ///  ResourceManager 加载名字面板
    /// </summary>
    void InitNameBoard()
    {

    }
    /// <summary>
    /// 加载名字面板
    /// </summary>
    /// <param name="objNameBoard"></param>
    void OnLoadNameBoard(GameObject objNameBoard)
    {
            //加载玩显示 名字  标题  vip
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
    /// 更新
    /// </summary>
    public void UpadatePlayerGBState()
    {
        if (null != m_playerHeadInfo)
        {
          //  m_playerHeadInfo.UpdateGuildBusinessIcon(GuildBusinessState);
        }
    }

    /// <summary>
    /// 玩家登陆接口
    /// </summary>
    public void OnPlayerLogin()
    {
    }

    /// <summary>
    /// 切换场景调用接口
    /// </summary>
    public void OnPlayerEnterScene()
    {
        //设置初始位置
        //这个之后会改为读取PlayerDataPool中的位置
        //做个藏经阁特例,用于做轻功
        //添加主角摇杆控制组件
        //添加主角摄像机控制组件
        //添加主角AI组件
        //初始化寻路代理
        //初始化特效
        //初始化RoleBaseID
        //初始化ServerID
        //当场景id为剧情江夏时，添加指路箭头
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
    //摄像机相关
    /// </summary>
    private CameraController m_CameraController = null;



    void UpdateCameraController()
    {

    }
    /// <summary>
    /// 移动和动画相关
    /// </summary>
    protected override void OnMoveOver()
    {
        //移动结束，如果发现存在目标NPC，则进行移动结束后的操作
        //目前暂定两种：
        //1.友方NPC开始对话操作
        //2.敌方NPC开始攻击操作
        //如果是地方NPC，则开始攻击
        //如果是友方NPC，则开始对话
        //处理移动后事件
        //移动圈消失
    }

    /// <summary>
    /// 目标选择逻辑
    /// </summary>
    private Obj_Character m_selectTarget = null;      //选择的目标
    public Obj_Character SelectTarget
    {
        get { return m_selectTarget; }
        set { m_selectTarget = value; }
    }
    private bool m_onSelectForClick = false;//标记从点击选择的目标
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
    /// 选择物体
    /// </summary>
    /// <param name="targetObj"></param>
    /// <param name="isMoveAgainSelect"></param>
    public void OnSelectTarget(GameObject targetObj, bool isMoveAgainSelect = true)
    {
        //如果targetObj为空，则进行取消选择逻辑
        //如果之前已经选择，则移动过去
        //获取目标物体基础数据
        //屏蔽移动逻辑修改为npc过去，怪不过去
        //是队友
        //修改奔跑中有目标了突然转身的情况             
        //如果选择的目标在播放技能范围的特效 切换目标时得 修改特效播放的对象
      
        //发包给服务器 发送的是目标物体的id
       
    }
    /// <summary>
    /// 更新选择目标屋头
    /// </summary>
    public void UpdateSelectTarget()
    {
        //更新目标选取策略
        //距离为11
        //再次根据目标选择，是否为其他玩家
        //按照之前的估计，一个屏幕的宽度大概为场景宽度的1/3~1/2，所以当玩家离NPC的距离为场景宽度的1/6的时候，进行取消选择逻辑
       
    }
    /// <summary>
    /// 坐骑相关 本地数据里面获取
    /// </summary>
    public int MountID
    {
        get { return 0; }
        set { MountID = value; }
    }

    /// <summary>
    /// 上下马
    /// </summary>
    /// <param name="nMountID"></param>
    public override void RideOrUnMount(int nMountID)
    {
        base.RideOrUnMount(nMountID);
      
    }
    // 是否装备坐骑
    public int GetEquipMountID()
    {
        return 0;
    }
    /// <summary>
    /// 伙伴相关
    /// </summary>

    //当前召出伙伴服务器objid
    private int m_nCurFellowObjId = -1;
    public int CurFellowObjId
    {
        get { return m_nCurFellowObjId; }
        set { m_nCurFellowObjId = value; }
    }

    /// <summary>
    /// 当前召出伙伴
    /// </summary>
    /// <returns></returns>
    public Obj_Fellow GetCurFellow()
    {
        //找跟随物体id
        return null;
    }

     /// <summary>
     /// 自动使用homo
     /// </summary>
    public void AutoUseHPMPDrug()
    {
        //设置挂机,自动吃药 tt198507不挂机也可以自动吃药
        //不可以连续发包
        //重新选择药
        //设置挂机,自动吃药 tt198507不挂机也可以自动吃药
    }

    public bool isUp = false;
    /// <summary>
    /// 血量变化后的操作
    /// </summary>
    public void OptHPChange()  //override
    {
        //更新血条
    }
    /// <summary>
    /// 法力变化后的操作
    /// </summary>
    public void OptMPChange()// //override
    {
        //改变MP
    }
    /// <summary>
    ///XP变化后的操作
    /// </summary>
    public  void OptXPChange() //override
    {
        //添加地图是否允许使用xp技能判断
       

    }
    /// <summary>
    /// VIP 升级或者其他的
    /// </summary>
    public void OnVipCostChange()
    {
    }

    private int m_lastLevel = -1;
    /// <summary>
    /// 等级变化后的操作
    /// </summary>
    public void OptLevelChange()//  override
    {
        //播放50id特效
        //如果背包界面开着 刷新下背包物品显示（根据是否满足级别会有标红）
        //vip2的时候选择自动强化
        // 升级的时候给SDK同步一下当前角色信息
    }
    /// <summary>
    /// 头像变化后的操作
    /// </summary>
    public void OptHeadPicChange()//override
    {
       
    }
    /// <summary>
    /// 名字变化后的操作
    /// </summary>
    public void OptNameChange()// override
    {
        //更新登陆界面信息
    }

    public  void OnExpChange() //override
    {
      
    }

    public void OnOffLineExpChange()
    {
      
    }
    /// <summary>
    /// 势力变化后的操作
    /// </summary> override
    public void OptForceChange()
    {
        base.OptForceChange();
        //重置周围玩家名字颜色
    }

    public void AskCombatValue(bool bPowerRemind)
    {
      
    }

    //死亡相关
    private int m_nReliveEntryTime = 0;//记录复活剩余秒
    public int ReliveEntryTime
    {
        get { return m_nReliveEntryTime; }
        set { m_nReliveEntryTime = value; }
    }
    public  bool OnCorpse() //override
    {
        base.OnCorpse();
        // 死亡 弹出复活UI
        return true;
    }


    /// <summary>
    /// Obj死亡时候调用
    /// </summary>
    /// <returns> override</returns>

    public bool OnDie()
    {

        // 死亡 弹出复活UI

        // 玩家死亡停止自动寻路
        return true;
    }
    /// <summary>
    /// 复活
    /// </summary>
    /// <returns>override</returns>
    public bool OnRelife() 
    {
        base.OnRelife();
       
        // 复活 关闭复活UI
        return true;
    }
    public override void OptChangPKModle()
    {
        base.OptChangPKModle();
        //重置周围玩家名字颜色
      
        //显示不同状态的按钮
       
    }
    /// <summary>
    /// 获取名字面板颜色
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

    //玩家是否接受外部移动指令
    public bool IsCanOperate_Move()
    {
         //使用的技能中 不能移动释放且不能被移动打断 则不让移动

        //有绑定父节点
       //有禁止移动的BUFF
        return true;
    }

    /// <summary>
    /// 玩家轻功部分处理
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
    /// 玩家轻功开始之后，强制更新一下轻功点给服务器
    /// </summary>
    /// <param name="pos"></param>
    public void SycQingGongPos(Vector3 pos)
    {
        //新Obj同步机制修改，改用CG_MOVE包
        
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

    //切磋
    public UInt64 DuelTargetGuid { set; get; }
    
    public void ReqDuel(UInt64 targetGuid)
    {
        //向服务器发送邀请某人加入队伍消息
       
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
    /// 开始剧情
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
        // 组队副本 又有队伍 还不是队长
       
    }
    public void OnOpenCopySceneNO()
    {

    }

    // 随玩家等级开放按钮
    void LevelUpButtonActive()
    {
       
    }

    void InitLevelButtonActive()
    {
    }

    // 体能恢复倒计时
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
            CONTENT_TYPE_ATTR = 0,        // 属性
            CONTENT_TYPE_GEM,             // 宝石
        }

        public enum OPEN_TYPE
        {
            OPEN_TYPE_INVALID = -1,
            OPEN_TYPE_FRIEND = 0,        // 通过好友界面打开的
            OPEN_TYPE_POPMENU = 1,
            OPEN_TYPE_LASTSPEAKER = 2,
            OPEN_TYPE_TEAM = 3,
            OPEN_TYPE_NUM,             // 
        }
    }

    public void ReqViewOtherPlayer(UInt64 targetGuid, OtherRoleViewLogic.OPEN_TYPE oPenType)
    {
        //向服务器发送查看属性消息
     
    }
    /// <summary>
    ///  请求隐藏伙伴
    /// </summary>
    public void ReqHideFellow()
    {
       //服务器发送
    }
    /// <summary>
    /// 请求显示伙伴
    /// </summary>
    public void ReqShowFellow()
    {
        //请求显示伙伴 Ctog
     
    }

    public bool IsInJianYu()
    {
        return false;
    }

    //跑商状态判断
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
    /// 使用物品
    /// </summary>
    /// <param name="item"></param>
    public void UseItem(GameItem item)
    {
        
        UseMountItem(item);
    }

    void UseMountItem(GameItem item)
    {

            //已经拥有永久坐骑
        
    }

    void OnUseMountItemOk()
    {
        //CG_USE_ITEM 客户端发送 传m_CurUseMountItemGuid
     
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
        //背包是否还有空间
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

    //宝石孔是否满足级别需求
    public bool CheckLevelForGemSlot(int slotindex)
    {
       
        return true;
    }

    //此装备位是否已有相同属性宝石
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
    /// // 重载武器
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