
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

        //����״̬
        private int m_GuildBusinessState = GlobeVar.INVALID_ID;
        public int GuildBusinessState
        {
            get { return m_GuildBusinessState; }
            set { m_GuildBusinessState = value; }
        }

        /// <summary>
        /// ����  ��Ч
        /// </summary>
        /// <param name="nState"></param>

        public void UpdateGBStateEffect(int nState)
        {
            //�ж�״̬

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
            //��ȡ����λ��

            //���tabItemVisualȡ����charModelΪ�գ����Ĭ��charModel
            //���������������ְҵ��ZombiePlayer��

            //��ʼ��������Ч

            //��ʼ����Ч

            //��ʼ��Ѱ·����


            //��ʼ��AutoMove����ģ��


            //��ʼ���������
            InitNameBoard();

            //��ʼ������

            return true;
        }

        /// <summary>
        /// �����������  unity mono�Դ�
        /// </summary>
        void OnBecameVisible()
        {
            //�����Ƿ����ӿ��ڱ��λ��Ϊ����ϵͳ�Ż��жϱ�ʶ

            //��ʾ���ְ�

            //����Ѿ����������л�������״̬


            //��ʾģ��
        }

        /// <summary>
        /// �뿪��������
        /// </summary>
        void OnBecameInvisible()
        {
            //�����Ƿ����ӿ��ڱ��λ��Ϊ����ϵͳ�Ż��жϱ�ʶ
            //�������ְ�   
            // ����ģ��

        }
        /// <summary>
        /// mono��������
        /// </summary>
        void FixedUpdate()
        {
            //���¸��ּ���
            UpdateAttckCF(this.Profession);
            UpdateAttckSY();
            UpdateAttckYS();
            UpdateAttckHT();
            UpdateAttckXS();
            UpdateTargetMove();
            UpdateAnimation();
            UpdateQingGong();       //�����Ṧ���ܸı�������꣬���Է���UpdateTargetMove֮�����
                                    //UpdateAttckPGCF (this.Profession);
                                    //���ðѪ��
                                    //UpdateShowMultiShowDamageBoard();
                                    //���ܽ������

            updateWeaponPoint();
            updateBreakForActStand();

        }
        /// <summary>
        /// ��ʼ���������
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
            //��Ϊ��
            //Show�������
            //Show ����  vip  
            //����
        }
        public void UpdateGBNameBoard()
        {

        }
        /// <summary>
        /// ����״ֵ̬
        /// </summary>
        public virtual void UpdateCombatValue()
        {
            //������Ҫ����Ч  ֹͣ��ͬ���͵�

        }
        /// <summary>
        /// ����vip��Ϣ
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
        /// ����
        /// </summary>
        public void ShowTitleInvestitive()
        {
           
        }

        //ְҵ
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
        //PKģʽ
        private int m_nPkModle = -1;
        public virtual int PkModle
        {
            get { return m_nPkModle; }
            set { m_nPkModle = value; }
        }
        //�Ƿ������ǵķ����б���
        private bool m_bIsInMainPlayerPKList = false;
        public bool IsInMainPlayerPKList
        {
            get { return m_bIsInMainPlayerPKList; }
            set { m_bIsInMainPlayerPKList = value; }
        }
        /// <summary>
        /// ��ȡ���������ɫ
        /// </summary>
        /// <returns></returns>
        public  Color GetNameBoardColor()
        {
            //İ���˰�ɫ
            //������ϵ����������ɫ

            //�Է�����ɱ¾ģʽ ����δ���������� ����


            return new Color();
        }
        /// <summary>
        /// PKģʽ�ı�
        /// </summary>
        public virtual void OptChangPKModle()
        {
            //��������������ɫ
        }
        public class GC_BROADCAST_ATTR
        {

        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="packet"></param>
        public  void UpdateAttrBroadcastPackt(GC_BROADCAST_ATTR packet)//override
        {
            //����������ְҵ  ����id ���� ����
           
        }
        public class Obj_Mount
        {

        }
        /// <summary>
        ///  �������
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
        /// ��ȡ�����߶�
        /// </summary>
        /// <returns></returns>
        public float GetMountNameBoardHeight()
        {
           //�����ȡ��������

            return 0;
        }

        /// <summary>
        /// �������� ͳһ�ӿ�
        /// </summary>
        /// <param name="nMountID"></param>
        public virtual void RideOrUnMount(int nMountID)
        {
           
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="nMountID"></param>
        private void RideMount(int nMountID)
        {
            //�����ı�
            //������
        }

        /// <summary>
        /// ����
        /// </summary>
        private void UnMount()
        {
            //����ͳһ�Ľӿ�������
        }
        /// <summary>
        /// //���ֱ仯��Ĳ���
        /// </summary>
        public  void OptNameChange()//override
        {
            //չʾ�������
        }
        /// <summary>
        /// //�����仯��Ĳ���
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
        /// Obj����ʱ�����
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
        ///  ֽ����ϵͳ��װ
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

        // �ż���ʱ��װ��Ҫ�ȴ�
        private bool m_UpdateModelWait = false;
        private bool m_UpdateWeaponWait = false;
        private bool m_UpdateWeaponGemWait = false;
        /// <summary>
        /// ���¼���ǰ
        /// </summary>
        public void UpdateVisualAfterSkill()
        {
            //�����������ģʽ ������� ��Ч
        }

        //����Ṧ���ִ���
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
        /// ��ʼ�Ṧ
        /// </summary>
        /// <param name="_event"></param>
        public virtual void BeginQingGong(GameEvent _event)
        {

            //�õ�Ŀ�������
            //�Ṧbool״̬�ı�
            //�����赲ǰ��
            //��¼����ע�������߹켣��UpdateQingGong����λ�Ʋ�������ʹ��ϵͳMoveTo
            FaceTo(m_QingGongDst);

            //���ݲ�ͬ����ģ����·�͵�����ҽǶ�
            if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.PARABOLA)
            {
                //������������ƶ�
                CurObjAnimState = GameDefine_Globe.OBJ_ANIMSTATE.STATE_JUMP;

                //������ʼ���Ŀ�����㱾���Ṧ�˶�ʱ��
                float fTreckDistance = Vector3.Distance(m_QingGongSrc, m_QingGongDst);
                if (m_fMoveSpeed > 0)
                {
                    m_fQingGongTime = fTreckDistance / m_fMoveSpeed;
                }

                //��¼�Ṧ��ʼʱ��
                m_fQingGongBeginTime = Time.time;
            }
            else if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.TURN_LEFT)
            {
                //����������ƶ�
                CurObjAnimState = GameDefine_Globe.OBJ_ANIMSTATE.STATE_FASTRUN_LEFT;

                //ֱ���ƶ���ʹ�õײ�MoveTo����
                MoveTo(m_QingGongDst, null, 0.0f);
            }
            else if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.TURN_RIGHT)
            {
                //����������ƶ�
                CurObjAnimState = GameDefine_Globe.OBJ_ANIMSTATE.STATE_FASTRUN_RIGHT;

                //ֱ���ƶ���ʹ�õײ�MoveTo����
                MoveTo(m_QingGongDst, null, 0.0f);
            }

            //�����Ṧ��Ч
            if (null != ObjEffectLogic)
            {
                ObjEffectLogic.PlayEffect(62);
            }
        }
        /// <summary>
        /// �Ṧ����
        /// </summary>
        public virtual void EndQingGong()
        {
            //�����ƶ� �Ṧ״̬�ı�
           
            //�ָ����� Ѱ·�ָ�
            //�ƶ��ٶ�Ϊ�����ٶ�
            //���ò���
        }

        public virtual void UpdateQingGong()
        {
            if (false == m_bQingGongState)
            {
                return;
            }

            //����Ŀ�ĵأ��Ṧ����
            if (Vector3.Distance(m_ObjTransform.position, m_QingGongDst) < 0.4f)
            {
                EndQingGong();
            }

            //����������߹켣���������߶Ƚ��������߹켣����
            if (m_nQingGongType == (int)GameDefine_Globe.QINGGONG_TRAIL_TYPE.PARABOLA)
            {
                //������Ṧ��ʼ������������ʱ��
                float fElapseTime = Time.time - m_fQingGongBeginTime;

                //����Ṧ����ʱ�������Ҳ�����Ṧ
                //if (fElapseTime >= m_fQingGongTime)
                //{
                //    EndQingGong();
                //}

                //�����˶��켣
                Vector3 fMoveDirection = (m_QingGongDst - m_QingGongSrc).normalized;

                //��ǰ��
                Vector3 curPos = m_QingGongSrc + fMoveDirection * m_fMoveSpeed * fElapseTime;

                if (m_fQingGongMaxHeight > 0 && m_fQingGongTime > 0)
                {
                    //��õ�ǰʱ�����Ṧ���г��е�·������
                    float fRate = fElapseTime / m_fQingGongTime;

                    float fHeightRefix = 0.0f;
                    //�����߷�ǰ��κͺ��Σ��ֱ����������½�
                    if (fRate < 0.5f)
                    {
                        fHeightRefix = m_fQingGongMaxHeight * (fRate / 0.5f);
                    }
                    else
                    {
                        fHeightRefix = m_fQingGongMaxHeight * ((1 - fRate) / 0.5f);
                    }

                    //����MainPlayer�ĸ߶�
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
        /// �������
        /// </summary>
        /// <param name="history"></param>
        public void ShowChatBubble(ChatHistoryItem history)
        {
            //ͷ��Ϊ��  չʾ��������
          
        }
        /// <summary>
        /// ���ÿɼ�
        /// </summary>
        /// <param name="bVisible"></param>
        public virtual void SetVisible(bool bVisible)
        {
            //�ı���Ҷ���ת̨
            //�Ҹ�����
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
            // ��������
           
            return new Tab_WeaponModel();
        }

        /// <summary>
        /// �ϲ�����·��
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
