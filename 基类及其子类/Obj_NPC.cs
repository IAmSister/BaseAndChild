using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;

public class Obj_NPC : Obj_Character
{
    protected GameObject m_MissionBoard;       // 头顶任务标记
    private bool m_bIsBornCreate;//是否是刚刷出来的
    private bool m_IsNameBoard = false;//标记是否已经显示了名字版(初始化时)

    public Obj_NPC()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_NPC;
        m_listMissionID = new List<int>();
    }


    public  bool Init(Obj_Init_Data initData)//override
    {


        //初始化CharModelID，并读取部分客户端信息
        //设置动作路径
        //设置名字版高度
        //服务器发过来的信息               
      
        // NPC挂任务
       
        //组件在初始化数据后进行

        //初始化寻路代理
        //初始化动画，需要在AnimationFilePath被赋值后进行
        //初始化特效
        //加箭头指引
        //创新跟玩家一样的模型

        //初始化名字版
        //InitNameBoard();

        // 帮会活动NPC判断
      
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
    private int m_nProfession;      // 职业 （创建玩家用的和模仿玩家NPC模型）
    public int Profession
    {
        get { return m_nProfession; }
        set { m_nProfession = value; }
    }
    private int m_WeaponDataID;     // 当前武器
    public int WeaponDataID
    {
        get { return m_WeaponDataID; }
        set { m_WeaponDataID = value; }
    }
    private int m_ModelVisualID;    // 当前模型外观ID
    public int ModelVisualID
    {
        get { return m_ModelVisualID; }
        set { m_ModelVisualID = value; }
    }
    private int m_WeaponEffectGem;  // 武器特效宝石
    public int WeaponEffectGem
    {
        get { return m_WeaponEffectGem; }
        set { m_WeaponEffectGem = value; }
    }

    /// <summary>
    /// 停止NPC当前播放的特效
    /// </summary>
    public void StopNPCEffect()
    {
        if (ObjEffectLogic != null)
        {
            ObjEffectLogic.NPCStopEffect();
        }
    }

    /// <summary>
    /// NPC复活后，重新值下溶解相关值
    /// </summary>
    public void PlayUnDissolve()
    { //溶解特效
       
    }

    public  bool OnDie()//override
    {

        //死亡特效
        //溶解特效
     
        return true;
    }
    // 重载模型回调
    public  void OnReloadModle()//override
    {
        //反溶解特效 //死亡特效
       
        //雁门关的BOSS 刷新身上加上一个特效
       
    }

    /// <summary>
    /// 进入可视区域
    /// </summary>
    void OnBecameVisible()
    {
       
        //设置是否在视口内标记位，为其他系统优化判断标识
       
        //显示名字版
      
        //显示模型
        
        //如果已经死亡，则切换到死亡状态
    }

    /// <summary>
    /// 离开可视区域
    /// </summary>
    void OnBecameInvisible()
    {
        //设置是否在视口内标记位，为其他系统优化判断标识
       
        //隐藏名字版
        
        //隐藏模型
       
    }

    void FixedUpdate()
    {
         //击飞
       
        //多次冒血的
     
        //技能结束检测
       
    }
    //===开放npc与主角距离用于隐藏头像
    public float m_fLastDis2MainPlayer = 0.0f; //Npc上次离主角的距离
    private Obj_MainPlayer m_mainPlayer = null;
    void AutoShowNPCDialogNear()
    { //当前距离NPC的距离
      //是黑市商人
      //来到离黑市商人2码内的距离 自动弹出对话框
      //等停下来再进行操作 
      //没有弹出对话(有选项)

            //是帮会NPC
            //来到离帮会NPC2码内的距离 自动弹出对话框
            //等停下来再进行操作 
            //没有弹出对话(无选项)

            //是仓库NPC
            ////来到离黑市商人2码内的距离 自动弹出对话框
            /////等停下来再进行操作 
            /////没有弹出对话(有选项)

            //奖励npc
            //等停下来再进行操作 
            //没有弹出对话(有选项)
      
    }
    void InitNameBoard()
    {
      
    }

    void OnLoadNameBoard(GameObject objNameBoard)
    {
        
    }

    //////////////////////////////////////////////////////////////////////////
    //NPC对话相关处理
    //////////////////////////////////////////////////////////////////////////
    private int m_nDefaultDialogID = -1;        //NPC对话索引列表
    public int DefaultDialogID
    {
        get { return m_nDefaultDialogID; }
        set { m_nDefaultDialogID = value; }
    }

    private List<int> m_listMissionID;        //NPC任务脚本
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
        //怪物向NPC 移动 到达玩家 开始攻击

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
    /// 名字变化后的操作
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
       
        //婚车特殊摆设

    }

    private bool m_bIsGuildActivityBoss = false;    // 帮会活动Boss;
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
