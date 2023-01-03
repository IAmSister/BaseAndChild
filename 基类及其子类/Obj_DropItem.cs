
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
        public float fActiveRadius = 5; //拾取范围
        private bool bIsDrop = true; //是否可以捡取
        private float m_fDropTimeSecond = Time.realtimeSinceStartup;

        private bool bIsSendDrop = true; //延迟发送
        private float m_fSendDropTimeSecond = Time.realtimeSinceStartup;

        private float m_fUpdateTimeSecond = Time.realtimeSinceStartup + 0.3f;    //1秒钟执行一次掉落捡取,以防止不停刷背包已满.第一次没有限制

        public float m_fMoveSecond = 0.2f; //移动速度

        public float m_fSpeed = 4; //移动时长

        public float m_fStop = 0.2f; //停顿时间

        public float m_fScaling = 2; //放大陪数
        private Vector3 m_localScale;
        private float m_lifetime = 30.0f;//如果30s内不捡，删除
        private bool m_isbackfull = false;//背包是否已满
        private float m_firstdroptime = 0.0f;//包掉落时间
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
            //暂时 写死了 后面再用服务器

            //初始化特效
           
            return true;
        }

        void OnTriggerEnter(Collider other)
        {
            //CG_ASK_PICKUP_ITEM  掉落物品
           
        }
        //更新Obj_DropItem逻辑数据
        void FixedUpdate()
        {
            //不要频繁发包,5秒发一次
            //延迟发送
            //更新拾取
            // 挂机中自动拾取
            
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
          
            //播放拾取声音
           
            //通知人物头顶Pop拾取文字
 
        }

        protected int m_nDropType;        //掉落类型
        public int DropType
        {
            get { return m_nDropType; }
            set { m_nDropType = value; }
        }

        protected int m_nItemId;        //物品Id
        public int ItemId
        {
            get { return m_nItemId; }
            set { m_nItemId = value; }
        }
        protected int m_nItemCount;     //物品数量
        public int ItemCount
        {
            get { return m_nItemCount; }
            set { m_nItemCount = value; }
        }
        protected UInt64 m_OwnerGuid;   //归属者Guild
        public UInt64 OwnerGuid
        {
            get { return m_OwnerGuid; }
            set { m_OwnerGuid = value; }
        }

        public UILabel m_NameBoard;            // 物品名字
        public UISprite m_ItemSprite;           // 物品图片

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
