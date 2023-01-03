
using UnityEngine;
using System.Collections;
using Games.GlobeDefine;
using GCGame;
using GCGame.Table;

using System;

using Games.Scene;
using System.Collections.Generic;



    public class Obj_OtherPlayer : Obj_Character
    {
        public Obj_OtherPlayer()
        {
            m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_OTHER_PLAYER;
        }


        private UInt64 m_GUID = GlobeVar.INVALID_GUID;
        public UInt64 GUID
        {
            get { return m_GUID; }
            set { m_GUID = value; }
        }

        private UInt64 m_GuildGUID = GlobeVar.INVALID_GUID;
        public virtual System.UInt64 GuildGUID
        {
            get { return m_GuildGUID; }
            set { m_GuildGUID = value; }
        }

        //跑商状态
        private int m_GuildBusinessState = GlobeVar.INVALID_ID;
        public int GuildBusinessState
        {
            get { return m_GuildBusinessState; }
            set { m_GuildBusinessState = value; }
        }

        /// <summary>
        /// 更新  特效
        /// </summary>
        /// <param name="nState"></param>

        public void UpdateGBStateEffect(int nState)
        {
            //判断状态

        }

        private int m_fellowID;
        public int FellowID
        {
            get { return m_fellowID; }
            set { m_fellowID = value; }
        }

        private bool m_bIsWildEnemyForMainPlayer = false;
        public bool IsWildEnemyForMainPlayer
        {
            get { return m_bIsWildEnemyForMainPlayer; }
            set { m_bIsWildEnemyForMainPlayer = value; }
        }

        public bool Init(Obj_Init_Data initData)
        {
            //获取地形位置

            //如果tabItemVisual取出来charModel为空，则给默认charModel
            //这个问题会出现在无职业的ZombiePlayer上

            //初始化动作特效

            //初始化特效

            //初始化寻路代理


            //初始化AutoMove功能模块


            //初始化名字面板
            InitNameBoard();

            //初始化数据

            return true;
        }

        /// <summary>
        /// 进入可视区域  unity mono自带
        /// </summary>
        void OnBecameVisible()
        {
            //设置是否在视口内标记位，为其他系统优化判断标识

            //显示名字版

            //如果已经死亡，则切换到死亡状态


            //显示模型
        }

        /// <summary>
        /// 离开可视区域
        /// </summary>
        void OnBecameInvisible()
        {
            //设置是否在视口内标记位，为其他系统优化判断标识
            //隐藏名字版   
            // 隐藏模型

        }
        /// <summary>
        /// mono生命周期
        /// </summary>
        void FixedUpdate()
        {
            //更新各种技能
            UpdateAttckCF(this.Profession);
            UpdateAttckSY();
            UpdateAttckYS();
            UpdateAttckHT();
            UpdateAttckXS();
            UpdateTargetMove();
            UpdateAnimation();
            UpdateQingGong();       //由于轻功可能改变玩家坐标，所以放在UpdateTargetMove之后进行
                                    //UpdateAttckPGCF (this.Profession);
                                    //多次冒血的
                                    //UpdateShowMultiShowDamageBoard();
                                    //技能结束检测

            updateWeaponPoint();
            updateBreakForActStand();

        }
        /// <summary>
        /// 初始化名字面板
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
            //不为空
            //Show名字面板
            //Show 标题  vip  
            //跑商
        }
        public void UpdateGBNameBoard()
        {

        }
        /// <summary>
        /// 更新状态值
        /// </summary>
        public virtual void UpdateCombatValue()
        {
            //播放需要的特效  停止不同类型的

        }
        /// <summary>
        /// 更新vip信息
        /// </summary>
        public virtual void UpdateVipInfo()
        {
        }
        public class PlayerHeadInfo{
            }
        public PlayerHeadInfo m_playerHeadInfo;

        private string m_strTitleInvestitive;
        public string StrTitleInvestitive
        {
            get { return m_strTitleInvestitive; }
            set { m_strTitleInvestitive = value; }
        }

        private int m_CurTitleID;
        public int CurTitleID
        {
            get { return m_CurTitleID; }
            set { m_CurTitleID = value; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public void ShowTitleInvestitive()
        {
           
        }

        //职业
        private int m_nProfession = -1;
        public virtual int Profession
        {
            get { return m_nProfession; }
            set { m_nProfession = value; }
        }
        //VIP
        private int m_nVipCost = -1;
        public virtual int VipCost
        {
            get { return m_nVipCost; }
            set { m_nVipCost = value; UpdateVipInfo(); }
        }


        private int m_nOtherCombatValue = -1;
        public virtual int OtherCombatValue
        {
            get { return m_nOtherCombatValue; }
            set { m_nOtherCombatValue = value; }
        }
        //PK模式
        private int m_nPkModle = -1;
        public virtual int PkModle
        {
            get { return m_nPkModle; }
            set { m_nPkModle = value; }
        }
        //是否在主角的反击列表中
        private bool m_bIsInMainPlayerPKList = false;
        public bool IsInMainPlayerPKList
        {
            get { return m_bIsInMainPlayerPKList; }
            set { m_bIsInMainPlayerPKList = value; }
        }
        /// <summary>
        /// 获取名字面板颜色
        /// </summary>
        /// <returns></returns>
        public  Color GetNameBoardColor()
        {
            //陌生人白色
            //其他关系的其他的颜色

            //对方开了杀戮模式 且尚未攻击过主角 紫名


            return new Color();
        }
        /// <summary>
        /// PK模式改变
        /// </summary>
        public virtual void OptChangPKModle()
        {
            //设置名字面板的颜色
        }
        public class GC_BROADCAST_ATTR
        {

        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="packet"></param>
        public  void UpdateAttrBroadcastPackt(GC_BROADCAST_ATTR packet)//override
        {
            //服务器返回职业  虚拟id 武器 更新
           
        }
        public class Obj_Mount
        {

        }
        /// <summary>
        ///  坐骑相关
        /// </summary>
        private Obj_Mount m_MountObj = null;
        public Obj_Mount MountObj
        {
            get { return m_MountObj; }
            set { m_MountObj = value; }
        }

        private int m_MountID = -1;
        virtual public int MountID
        {
            get { return m_MountID; }
            set
            {
                m_MountID = value;
            }
        }

        private bool m_bIsNeedUnMount = false;
        public bool IsNeedUnMount
        {
            get { return m_bIsNeedUnMount; }
            set { m_bIsNeedUnMount = value; }
        }
        /// <summary>
        /// 获取马面板高度
        /// </summary>
        /// <returns></returns>
        public float GetMountNameBoardHeight()
        {
           //读表获取基础数据

            return 0;
        }

        /// <summary>
        /// 上马下马 统一接口
        /// </summary>
        /// <param name="nMountID"></param>
        public virtual void RideOrUnMount(int nMountID)
        {
           
        }
        /// <summary>
        /// 骑马
        /// </summary>
        /// <param name="nMountID"></param>
        private void RideMount(int nMountID)
        {
            //动画改变
            //上下马
        }

        /// <summary>
        /// 下马
        /// </summary>
        private void UnMount()
        {
            //调用统一的接口上下马
        }
        /// <summary>
        /// //名字变化后的操作
        /// </summary>
        public  void OptNameChange()//override
        {
            //展示名字面板
        }
        /// <summary>
        /// //势力变化后的操作
        /// </summary>
        public  void OptForceChange()//override
        {
           // base.OptForceChange();
        }
        public  bool OnCorpse()//override
        {
           // base.OnCorpse();
            return true;
        }
        /// <summary>
        /// Obj死亡时候调用
        /// </summary>
        /// <returns></returns>
        public  bool OnDie() //override
        {
           // base.OnDie();
            return true;
        }
        public  bool OnRelife()//override
        {
           // base.OnRelife();

            return true;
        }

        /// <summary>
        ///  纸娃娃系统换装
        /// </summary>
        private int m_ModelVisualID = GlobeVar.INVALID_ID;
        public virtual int ModelVisualID
        {
            get { return m_ModelVisualID; }
            set { m_ModelVisualID = value; }
        }

        private int m_CurWeaponDataID = GlobeVar.INVALID_ID;
        public virtual int CurWeaponDataID
        {
            get { return m_CurWeaponDataID; }
            set { m_CurWeaponDataID = value; }
        }

        private int m_WeaponEffectGem = GlobeVar.INVALID_ID;
        public int WeaponEffectGem
        {
            get { return m_WeaponEffectGem; }
            set { m_WeaponEffectGem = value; }
        }

        public void ReloadWeaponEffectGem()
        {
           
        }

        // 放技能时换装需要等待
        private bool m_UpdateModelWait = false;
        private bool m_UpdateWeaponWait = false;
        private bool m_UpdateWeaponGemWait = false;
        /// <summary>
        /// 更新技能前
        /// </summary>
        public void UpdateVisualAfterSkill()
        {
            //重新载入玩家模式 玩家武器 特效
        }

        //玩家轻功部分处理
        private bool m_bQingGongState = false;
        public bool QingGongState
        {
            get { return m_bQingGongState; }
            set { m_bQingGongState = value; }
        }

        private Vector3 m_QingGongSrc = Vector3.zero;
        private Vector3 m_QingGongDst = Vector3.zero;
        private int m_nQingGongType = GlobeVar.INVALID_ID;
        private int m_nQingGongPointID = GlobeVar.INVALID_ID;
        public int QingGongPointID
        {
            get { return m_nQingGongPointID; }
        }
        private float m_fQingGongMaxHeight = 0;
        private float m_fQingGongTime = 0;
        private float m_fQingGongBeginTime = 0;
        public class GameEvent
        {

        }
        /// <summary>
        /// 开始轻功
        /// </summary>
        /// <param name="_event"></param>
        public virtual void BeginQingGong(GameEvent _event)
        {

            //得到目标点坐标
            //轻功bool状态改变
            //忽略阻挡前进
            //记录朝向，注意抛物线轨迹由UpdateQingGong进行位移操作，不使用系统MoveTo
            FaceTo(m_QingGongDst);

            //根据不同类型模拟线路和调整玩家角度
            if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.PARABOLA)
            {
                //如果是抛物线移动
                CurObjAnimState = GameDefine_Globe.OBJ_ANIMSTATE.STATE_JUMP;

                //根据起始点和目标点计算本次轻功运动时间
                float fTreckDistance = Vector3.Distance(m_QingGongSrc, m_QingGongDst);
                if (m_fMoveSpeed > 0)
                {
                    m_fQingGongTime = fTreckDistance / m_fMoveSpeed;
                }

                //记录轻功开始时间
                m_fQingGongBeginTime = Time.time;
            }
            else if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.TURN_LEFT)
            {
                //如果是线性移动
                CurObjAnimState = GameDefine_Globe.OBJ_ANIMSTATE.STATE_FASTRUN_LEFT;

                //直线移动，使用底层MoveTo即可
                MoveTo(m_QingGongDst, null, 0.0f);
            }
            else if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.TURN_RIGHT)
            {
                //如果是线性移动
                CurObjAnimState = GameDefine_Globe.OBJ_ANIMSTATE.STATE_FASTRUN_RIGHT;

                //直线移动，使用底层MoveTo即可
                MoveTo(m_QingGongDst, null, 0.0f);
            }

            //播放轻功特效
            if (null != ObjEffectLogic)
            {
                ObjEffectLogic.PlayEffect(62);
            }
        }
        /// <summary>
        /// 轻功结束
        /// </summary>
        public virtual void EndQingGong()
        {
            //结束移动 轻功状态改变
           
            //恢复数据 寻路恢复
            //移动速度为基础速度
            //重置参数
        }

        public virtual void UpdateQingGong()
        {
            if (false == m_bQingGongState)
            {
                return;
            }

            //到达目的地，轻功结束
            if (Vector3.Distance(m_ObjTransform.position, m_QingGongDst) < 0.4f)
            {
                EndQingGong();
            }

            //如果是抛物线轨迹，根据最大高度进行抛物线轨迹更新
            if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.PARABOLA)
            {
                //计算从轻功开始到结束的流逝时间
                float fElapseTime = Time.time - m_fQingGongBeginTime;

                //如果轻功持续时间结束，也结束轻功
                //if (fElapseTime >= m_fQingGongTime)
                //{
                //    EndQingGong();
                //}

                //更新运动轨迹
                Vector3 fMoveDirection = (m_QingGongDst - m_QingGongSrc).normalized;

                //当前点
                Vector3 curPos = m_QingGongSrc + fMoveDirection * m_fMoveSpeed * fElapseTime;

                if (m_fQingGongMaxHeight > 0 && m_fQingGongTime > 0)
                {
                    //获得当前时间在轻功总行程中的路径比例
                    float fRate = fElapseTime / m_fQingGongTime;

                    float fHeightRefix = 0.0f;
                    //抛物线分前半段和后半段，分别处于上升和下降
                    if (fRate < 0.5f)
                    {
                        fHeightRefix = m_fQingGongMaxHeight * (fRate / 0.5f);
                    }
                    else
                    {
                        fHeightRefix = m_fQingGongMaxHeight * ((1 - fRate) / 0.5f);
                    }

                    //修正MainPlayer的高度
                    //Vector3 pos = transform.position;
                    curPos.y = curPos.y + fHeightRefix;
                    m_ObjTransform.position = curPos;
                }
            }
        }
        public class ChatHistoryItem
        {

        }
        /// <summary>
        /// 聊天面板
        /// </summary>
        /// <param name="history"></param>
        public void ShowChatBubble(ChatHistoryItem history)
        {
            //头不为空  展示聊天内容
          
        }
        /// <summary>
        /// 设置可见
        /// </summary>
        /// <param name="bVisible"></param>
        public virtual void SetVisible(bool bVisible)
        {
            //改变玩家动画转台
            //找跟随着
        }

        //==============
        public void updateWeaponPoint()//GameDefine_Globe.OBJ_ANIMSTATE ObjState
        {
          
        }
       public class Tab_WeaponModel
        {

        }
        private Tab_WeaponModel reloadWeaponPath()
        {
            // 重载武器
           
            return new Tab_WeaponModel();
        }

        /// <summary>
        /// 合并武器路径
        /// </summary>
        /// <param name="weaponUrl"></param>
        /// <param name="tempIndex"></param>
        private void changeWeaponPath(string weaponUrl, int tempIndex)
        {
         

          
        }
        //==========end=========
        private int breakStandTime = 50;
        private void updateBreakForActStand()
        {
           
        }

    
}
