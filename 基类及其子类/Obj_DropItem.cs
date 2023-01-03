
using UnityEngine;
using Games.GlobeDefine;
using System;
using GCGame.Table;
using Games.Scene;
using GCGame;

namespace Games.LogicObj
{
    public class Obj_DropItem : Obj_Mono
    {
        public float fActiveRadius = 5; //ʰȡ��Χ
        private bool bIsDrop = true; //�Ƿ���Լ�ȡ
        private float m_fDropTimeSecond = Time.realtimeSinceStartup;

        private bool bIsSendDrop = true; //�ӳٷ���
        private float m_fSendDropTimeSecond = Time.realtimeSinceStartup;

        private float m_fUpdateTimeSecond = Time.realtimeSinceStartup + 0.3f;    //1����ִ��һ�ε����ȡ,�Է�ֹ��ͣˢ��������.��һ��û������

        public float m_fMoveSecond = 0.2f; //�ƶ��ٶ�

        public float m_fSpeed = 4; //�ƶ�ʱ��

        public float m_fStop = 0.2f; //ͣ��ʱ��

        public float m_fScaling = 2; //�Ŵ�����
        private Vector3 m_localScale;
        private float m_lifetime = 30.0f;//���30s�ڲ���ɾ��
        private bool m_isbackfull = false;//�����Ƿ�����
        private float m_firstdroptime = 0.0f;//������ʱ��
        // private float m_fSpeed = 0.0f;
        public Obj_DropItem()
        {
            m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ_DROP_ITEM;
        }
        public class Obj_DroopItemData
        {

        }
        public virtual bool Init(Obj_DroopItemData initData)
        {
            //��ʱ д���� �������÷�����

            //��ʼ����Ч
           
            return true;
        }

        void OnTriggerEnter(Collider other)
        {
            //CG_ASK_PICKUP_ITEM  ������Ʒ
           
        }
        //����Obj_DropItem�߼�����
        void FixedUpdate()
        {
            //��ҪƵ������,5�뷢һ��
            //�ӳٷ���
            //����ʰȡ
            // �һ����Զ�ʰȡ
            
        }

        void Start()
        {
            m_fDropTimeSecond = Time.realtimeSinceStartup;
            m_fSendDropTimeSecond = Time.realtimeSinceStartup;
            m_firstdroptime = Time.realtimeSinceStartup;
            ShowNameBoard();
            ShowItemSprite();
        }
        public void SendDropItem()
        {
            //CG_ASK_PICKUP_ITEM
          
            //����ʰȡ����
           
            //֪ͨ����ͷ��Popʰȡ����
 
        }

        protected int m_nDropType;        //��������
        public int DropType
        {
            get { return m_nDropType; }
            set { m_nDropType = value; }
        }

        protected int m_nItemId;        //��ƷId
        public int ItemId
        {
            get { return m_nItemId; }
            set { m_nItemId = value; }
        }
        protected int m_nItemCount;     //��Ʒ����
        public int ItemCount
        {
            get { return m_nItemCount; }
            set { m_nItemCount = value; }
        }
        protected UInt64 m_OwnerGuid;   //������Guild
        public UInt64 OwnerGuid
        {
            get { return m_OwnerGuid; }
            set { m_OwnerGuid = value; }
        }

        public UILabel m_NameBoard;            // ��Ʒ����
        public UISprite m_ItemSprite;           // ��ƷͼƬ

        public void ShowNameBoard()
        {
           
        }
        public void SetNameBoardColor()
        {
            
        }
        //public UISpriteAnimation m_SpriteAnimation;
        public void ShowItemSprite()
        {
            
        }
        public void UpdateMove(float fSpeed)
        {
           
        }
    }
}
