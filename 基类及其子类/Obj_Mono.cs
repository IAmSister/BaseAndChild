using Games.GlobeDefine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_Mono : MonoBehaviour
{
    public Obj_Mono()
    {
        m_ObjType = GameDefine_Globe.OBJ_TYPE.OBJ;
    }
    void Awake()
    {
        m_ObjTransform = transform;
    }
    public GameDefine_Globe.OBJ_TYPE m_ObjType;  //Obj类型
    private Shader m_OldShader = null;

    public GameDefine_Globe.OBJ_TYPE ObjType
    {
        get { return m_ObjType; }
    }
    protected bool m_bCanLogic = false;             //是否可以进行逻辑操作
    public bool CanLogic
    {
        get { return m_bCanLogic; }
        set { m_bCanLogic = value; }
    }

    protected int m_ServerID;                       //Obj的ServerID
    public int ServerID
    {
        get { return m_ServerID; }
        set { m_ServerID = value; }
    }

    protected int m_ModelID;                        //Obj的模型ID,在CharModel表中定义
    public int ModelID
    {
        get { return m_ModelID; }
        set { m_ModelID = value; }
    }

    private GameObject m_ModelNode = null;           //暂存Model节点
    public UnityEngine.GameObject ModelNode
    {
        get { return m_ModelNode; }
        set { m_ModelNode = value; }
    }
    ///常用基础方法属性接口
    protected Transform m_ObjTransform = null;        //缓存Transform，提高运行效率,必须在Awake的时候就进行赋值
    public Transform ObjTransform
    {
        get { return m_ObjTransform; }
    }
    public Vector3 Position
    {
        get { return m_ObjTransform.localPosition; }
        set
        {
            //value.y = 0;
            m_ObjTransform.localPosition = value;
        }
    }
    public Quaternion Rotation
    {
        get { return m_ObjTransform.localRotation; }
        set { m_ObjTransform.localRotation = value; }
    }
    public Vector3 Scale
    {
        get { return m_ObjTransform.localScale; }
        set { m_ObjTransform.localScale = value; }
    }
    public string GameObjectName
    {
        get { return this.gameObject.name; }
        set { this.gameObject.name = value; }
    }
    public void SetScale(float fScale)
    {
        if (null != this.gameObject)
        {
            m_ObjTransform.localScale = Vector3.one * fScale;
        }
    }
    /// <summary>
    /// 判断物体是否在自己前方
    /// </summary>
    /// <param name="targetObj">目标物体</param>
    /// <returns>是否在前方</returns>
    public bool IsInFront(Obj_Mono targetObj)
    {
        if (null == targetObj)
        {
            return false;
        }

        //获得从当前Obj到目标Obj的方向，然后求和当前Obj的朝向夹角。
        Vector2 tarPos = new Vector2(targetObj.ObjTransform.position.x, targetObj.ObjTransform.position.z);
        Vector2 myPos = new Vector2(ObjTransform.position.x, ObjTransform.position.z);
        Vector2 mydir = new Vector2(ObjTransform.forward.x, ObjTransform.forward.z);
        Vector2 dir = tarPos - myPos;
        float angle = Vector2.Angle(mydir.normalized, dir.normalized);
        if (angle < 90.0f)
        {
            return true;
        }

        return false;
    }
    #region 材质
    ///材质相关数据缓存
    protected List<Material> m_WeaponMaterialList = new List<Material>();//!!!缓存武器材质信息 使用前记得判空防止出现丢失的情况
    protected List<Material> m_BodyMaterialList = new List<Material>();//!!!缓存身体材质信息 使用前记得判空防止出现丢失的情况
    protected Dictionary<string, Color> m_BodyInitColorDic = new Dictionary<string, Color>(); //!!!缓存身体材质的颜色 使用前记得判空防止出现丢失的情况
    protected Dictionary<string, Color> m_WeaponInitColorDic = new Dictionary<string, Color>(); //!!!缓存武器材质的颜色 使用前记得判空防止出现丢失的情况
    protected Dictionary<string, Shader> m_BodyInitShaderDic = new Dictionary<string, Shader>(); //!!!缓存身体材质的shader 使用前记得判空防止出现丢失的情况
    protected Dictionary<string, Shader> m_WeaponInitShaderDic = new Dictionary<string, Shader>(); //!!!缓存武器材质的shader 使用前记得判空防止出现丢失的情况
    protected bool m_bIsPlayDissolve = false;//是否开始播放溶解效果
    protected float m_fPlayDissolveSpeed = 2.0f;//是否开始播放溶解效果
    protected float m_fPlayDissolveDelay = 0.5f;//延迟时间
    protected bool m_bIsPlayUnDissolve = false;//是否开始播放反溶解效果
    protected float m_fPlayUnDissolveSpeed = 2.0f;//是否开始播放溶解效果
    protected float m_fPlayUnDissolveDelay = 0.5f;//延迟时间

    /// <summary>
    /// 初始化材质信息
    /// </summary>
    public void InitMaterialInfo()
    {
        /// <summary>
        /// 数据缓存清空
        /// </summary>
        m_BodyMaterialList.Clear();
        m_WeaponMaterialList.Clear();
        m_BodyInitColorDic.Clear();
        m_WeaponInitColorDic.Clear();
        m_BodyInitShaderDic.Clear();
        m_WeaponInitShaderDic.Clear();
        m_bIsPlayDissolve = false;
        //找材质节点
        Transform _modleTransform = gameObject.transform.Find("Model");
        if (_modleTransform == null)
        {
            return;
        }
        GameObject _modle = _modleTransform.gameObject;
        if (_modle != null)
        {
            //找节点下渲染器
            Renderer[] renderers = _modle.GetComponentsInChildren<Renderer>();
            if (renderers != null)
            {
                for (int i = 0; i < renderers.Length; ++i)
                {
                    if (null != renderers[i] && null != renderers[i].material)
                    {
                        //身体部分
                        if (IsBodyRenderer(renderers[i]) && m_BodyMaterialList.Contains(renderers[i].material) == false)
                        {
                            //缓存材质信息
                            m_BodyMaterialList.Add(renderers[i].material);
                            //缓存材质颜色信息
                            if (renderers[i].material.HasProperty("_Color") && m_BodyInitColorDic.ContainsKey(renderers[i].material.name) == false)
                            {
                                m_BodyInitColorDic.Add(renderers[i].material.name, renderers[i].material.GetColor("_Color"));
                            }
                            //缓存材质shader信息
                            if (m_BodyInitShaderDic.ContainsKey(renderers[i].material.name) == false)
                            {
                                m_BodyInitShaderDic.Add(renderers[i].material.name, renderers[i].material.shader);
                            }
                        }
                        //武器部分
                        if (IsWeaponRenderer(renderers[i]) && m_WeaponMaterialList.Contains(renderers[i].material) == false)
                        {
                            m_WeaponMaterialList.Add(renderers[i].material);
                            //缓存材质颜色信息
                            if (renderers[i].material.HasProperty("_Color") && m_WeaponInitColorDic.ContainsKey(renderers[i].material.name) == false)
                            {
                                m_WeaponInitColorDic.Add(renderers[i].material.name, renderers[i].material.GetColor("_Color"));
                            }
                            //缓存材质shader信息
                            if (m_WeaponInitShaderDic.ContainsKey(renderers[i].material.name) == false)
                            {
                                m_WeaponInitShaderDic.Add(renderers[i].material.name, renderers[i].material.shader);
                            }
                        }
                    }
                }
                OptAfterInitMaterialInfo();
                m_OldShader = Shader.Find(m_BodyMaterialList[0].shader.name);
            }
        }
    }
    /// <summary>
    /// 初始化武器材质
    /// </summary>
    public void InitWeaponMaterialInfo()
    {
        ///  有关武器缓存初始化
        m_WeaponMaterialList.Clear();
        m_WeaponInitColorDic.Clear();
        m_WeaponInitShaderDic.Clear();
        m_bIsPlayDissolve = false;
        ///找节点
        Transform _modleTransform = gameObject.transform.Find("Model");
        if (_modleTransform == null)
        {
            return;
        }
        GameObject _modle = _modleTransform.gameObject;
        if (_modle != null)
        {
            Renderer[] renderers = _modle.GetComponentsInChildren<Renderer>();
            if (renderers != null)
            {
                for (int i = 0; i < renderers.Length; ++i)
                {
                    if (null != renderers[i] && null != renderers[i].material)
                    {
                        //武器部分
                        if (IsWeaponRenderer(renderers[i]) && m_WeaponMaterialList.Contains(renderers[i].material) == false)
                        {
                            //缓存材质信息
                            m_WeaponMaterialList.Add(renderers[i].material);
                            //缓存材质颜色信息
                            if (renderers[i].material.HasProperty("_Color") && m_WeaponInitColorDic.ContainsKey(renderers[i].material.name) == false)
                            {
                                m_WeaponInitColorDic.Add(renderers[i].material.name, renderers[i].material.GetColor("_Color"));
                            }
                            //缓存材质shader信息
                            if (m_WeaponInitShaderDic.ContainsKey(renderers[i].material.name) == false)
                            {
                                m_WeaponInitShaderDic.Add(renderers[i].material.name, renderers[i].material.shader);
                            }
                        }
                    }
                }
                //  OptAfterInitMaterialInfo();
            }
        }
    }
    /// <summary>
    /// 初始化材质后操作
    /// </summary>
    public virtual void OptAfterInitMaterialInfo()
    {
        //有变色的话 换装得加上 
        //if (ObjEffectLogic != null && ObjEffectLogic.IsHaveChangeColorEffct())
        //{
        //    SetMaterialColor(GlobeVar.BLUEMATERIAL_R, GlobeVar.BLUEMATERIAL_G, GlobeVar.BLUEMATERIAL_B);
        //}
    }
    /// <summary>
    /// 是否是身体渲染
    /// </summary>
    /// <param name="_Renderer"></param>
    /// <returns></returns>
    public bool IsBodyRenderer(Renderer _Renderer)
    {
        //渲染器存在并且父级是指定的节点
        if (_Renderer && _Renderer.transform.parent)
        {
            if (_Renderer.transform.parent.name == "Model")
            {
                return true;
            }
        }
        return false;
    }
    public bool IsWeaponRenderer(Renderer _Renderer)
    {
        if (_Renderer && _Renderer.transform.parent)
        {
            //武器挂载点是两个
            if (_Renderer.transform.parent.name == "HH_weaponHandLf" ||
                _Renderer.transform.parent.name == "HH_weaponHandRt")
            {
                return true;
            }
        }
        return false;
    }
    #endregion
    #region 材质变色
    public void SetMaterialInitColor()
    {
        Material _material = null;
        for (int i = 0; i < m_BodyMaterialList.Count; i++)
        {
            _material = m_BodyMaterialList[i];
            if (_material != null)
            {
                if (_material.HasProperty("_Color") && m_BodyInitColorDic.ContainsKey(_material.name))
                {
                    Color _initcolor = m_BodyInitColorDic[_material.name];
                    SetMaterialColor(_material, _initcolor.r, _initcolor.g, _initcolor.b);
                }
            }

        }
        //替换武器材质
        for (int i = 0; i < m_WeaponMaterialList.Count; ++i)
        {
            _material = m_WeaponMaterialList[i];
            if (null != _material)
            {
                if (_material.HasProperty("_Color") && m_WeaponInitColorDic.ContainsKey(_material.name))
                {
                    Color _initcolor = m_WeaponInitColorDic[_material.name];
                    SetMaterialColor(_material, _initcolor.r, _initcolor.g, _initcolor.b);
                }
            }
        }
    }
    /// <summary>
    /// 设置模型材质颜色
    /// </summary>
    /// <param name="_material">指定材质</param>
    /// <param name="red">三色值</param>
    /// <param name="green"></param>
    /// <param name="blue"></param>
    public void SetMaterialColor(Material _material, float red, float green, float blue)
    {
        if (_material && _material.HasProperty("_Color"))
        {
            Color c = _material.GetColor("_Color");
            c.r = red;
            c.g = green;
            c.b = blue;
            _material.color = c;
        }
    }
    /// <summary>
    /// 设置模型材质颜色
    /// </summary>
    /// <param name="red"></param>
    /// <param name="green"></param>
    /// <param name="blue"></param>
    public void SetMaterialColor(float red, float green, float blue)
    {
        Material _material = null;
        //替换身体材质
        for (int i = 0; i < m_BodyMaterialList.Count; ++i)
        {
            _material = m_BodyMaterialList[i];
            if (_material)
            {
                if (_material.HasProperty("_Color"))
                {
                    SetMaterialColor(_material, red, green, blue);
                }
            }

        }
        //替换武器材质
        for (int i = 0; i < m_WeaponMaterialList.Count; ++i)
        {
            _material = m_WeaponMaterialList[i];
            if (_material)
            {
                if (_material.HasProperty("_Color"))
                {
                    SetMaterialColor(_material, red, green, blue);
                }
            }

        }
    }
    #endregion
    private bool m_bOutLine = false;
    public virtual bool OutLine
    {
        get { return m_bOutLine; }
        set { m_bOutLine = value; }
    }
    private bool m_bShanBai = false;
    private int m_shanbai = 0;
    /// <summary>
    /// 设置闪白
    /// </summary>
    public void SetShanBai()
    {
        m_bShanBai = true;

    }
    /// <summary>
    /// 更新
    /// </summary>
    public void UpdateShanBai()
    {

        if (m_bShanBai == true)
        {
            if (m_shanbai == 0)
            {
                m_BodyMaterialList[0].SetFloat("_whiteColor", 1.0f);
                m_shanbai = 1;
                Invoke("CanselShanBai", 0.2f);
            }
        }


    }
    /// <summary>
    /// 取消
    /// </summary>
    public void CanselShanBai()
    {
        m_bShanBai = false;
        m_BodyMaterialList[0].SetFloat("_whiteColor", 0.0f);
        m_shanbai = 0;
        CancelInvoke("CanselShanBai");
    }
    /// <summary>
    /// 描边
    /// </summary>
    public void SetOutLine()
    {
        // m_BodyMaterialList[0].shader = GameManager.m_ShaderOutLine;
        //m_WeaponMaterialList[0].shader = GameManager.m_ShaderOutLine;
        m_BodyMaterialList[0].SetColor("_Emission", new Color(0.6f, 0.6f, 0.6f, 0.0f));
        m_BodyMaterialList[0].SetColor("_OutlineColor", new Color(1, 1, 0, 0.3f));
        m_BodyMaterialList[0].SetColor("__EmissionColor", new Color(0.6f, 0.6f, 0.6f, 1.0f));
        //m_WeaponMaterialList [0].SetColor ("_OutlineColor",new Color(1,1,0,0.1f));
        m_BodyMaterialList[0].SetFloat("_Outline", 0.002f);
    }
    /// <summary>
    /// 取消描边
    /// </summary>
    public void CancelOutLine()
    {

        return;

    }
    public void SetDissolve()
    {
        //获取shader 通过路径进行图片   设置材质值
    }
    /// <summary>
    /// 取消
    /// </summary>
    public void CancelDissolve()
    {
        m_BodyMaterialList[0].shader = m_OldShader;

    }
    #region 隐身设置

    private int m_nStealthLev = 0;
    public virtual int StealthLev
    {
        get { return m_nStealthLev; }
        set { m_nStealthLev = value; }
    }
   /// <summary>
   /// 设置隐身状态
   /// </summary>
    public void SetStealthState()
    {
        //替换身体材质
       
        //替换武器材质
    }

    /// <summary>
    /// 取消隐身状态
    /// </summary>
    public void CancelStealthState()
    {
        //替换身体材质

        //替换武器材质
     
    }
    #endregion
    #region 溶解效果
    /// <summary>
    /// 更新溶解效果
    /// </summary>
    public void UpdateDissolve()
    {
        //计时
        //身体部分 设置属性
        //武器部分
      
    }

    /// <summary>
    /// 溶解效果
    /// </summary>
    /// <param name="_Speed"></param>
    /// <param name="_delaytime"></param>
    public void PlayDissolve(float _Speed, float _delaytime)
    {
        m_bIsPlayDissolve = true;
        m_fPlayDissolveSpeed = _Speed;
        m_fPlayDissolveDelay = _delaytime;
        SetDissolve();
    }

    /// <summary>
    /// 反溶解效果
    /// </summary>
    /// <param name="_Speed"></param>
    /// <param name="_delaytime"></param>
    public void PlayUnDissolve(float _Speed, float _delaytime)
    {

        m_bIsPlayUnDissolve = true;
        m_fPlayUnDissolveSpeed = _Speed;
        m_fPlayUnDissolveDelay = _delaytime;
        //身体部分
        for (int i = 0; i < m_BodyMaterialList.Count; ++i)
        {
            if (null != m_BodyMaterialList[i])
            {
                if (m_BodyMaterialList[i].HasProperty("_Amount"))
                {
                    m_BodyMaterialList[i].SetFloat("_Amount", 1.0f);
                }
            }
        }
        //武器部分
        for (int i = 0; i < m_WeaponMaterialList.Count; ++i)
        {
            if (null != m_WeaponMaterialList[i])
            {
                if (m_WeaponMaterialList[i].HasProperty("_Amount"))
                {
                    m_WeaponMaterialList[i].SetFloat("_Amount", 1.0f);
                }
            }
        }
        CancelDissolve();
    }

    /// <summary>
    /// 显示溶解的NPC
    /// </summary>
    public void ShowDissolveNPC()
    {
        if (m_BodyMaterialList != null)
        {
            //身体部分
            for (int i = 0; i < m_BodyMaterialList.Count; ++i)
            {
                if (null != m_BodyMaterialList[i])
                {
                    if (m_BodyMaterialList[i].HasProperty("_Amount"))
                    {
                        m_BodyMaterialList[i].SetFloat("_Amount", 0.0f);
                    }
                }
            }
        }

        if (m_WeaponMaterialList != null)
        {
            //武器部分
            for (int i = 0; i < m_WeaponMaterialList.Count; ++i)
            {
                if (null != m_WeaponMaterialList[i])
                {
                    if (m_WeaponMaterialList[i].HasProperty("_Amount"))
                    {
                        m_WeaponMaterialList[i].SetFloat("_Amount", 0.0f);
                    }
                }
            }
        }
    }

    #endregion
    #region 隐身设置

    private bool m_bianshen = false;
    public bool BianShen
    {
        get { return m_bianshen; }
        set { m_bianshen = value; }
    }
    private Color oldColor = Color.white;
    private Color oldWeaponColor = Color.white;
    public void SetBianshen(Color col)
    {//替换身体材质
     //替换武器材质
    }

    /// <summary>
    /// 取消变身
    /// </summary>
    public void CancelBianshen()
    {
        Material _material = null;
        //替换身体材质
        if (oldColor == null)
            return;
        for (int i = 0; i < m_BodyMaterialList.Count; ++i)
        {
            _material = m_BodyMaterialList[i];
            if (_material)
            {
                if (m_BodyInitShaderDic.ContainsKey(_material.name))
                {
                    _material.shader = m_BodyInitShaderDic[_material.name];
                    if (_material.HasProperty("_Color"))
                    {
                        Color c = _material.GetColor("_Color");
                        c = oldColor;
                        _material.color = c;
                    }
                }
            }
        }
        //替换武器材质
        for (int i = 0; i < m_WeaponMaterialList.Count; ++i)
        {
            _material = m_WeaponMaterialList[i];
            if (_material)
            {
                if (m_WeaponInitShaderDic.ContainsKey(_material.name))
                {
                    _material.shader = m_WeaponInitShaderDic[_material.name];
                    if (_material.HasProperty("_Color"))
                    {
                        Color c = _material.GetColor("_Color");
                        if (oldWeaponColor != null)
                            c = oldWeaponColor;
                        _material.color = c;
                    }
                }
            }
        }
    }
    #endregion
    #region 效果逻辑
    private EffectLogic m_objEffectLogic = null;
    public EffectLogic ObjEffectLogic
    {
        get { return m_objEffectLogic; }
        set { m_objEffectLogic = value; }
    }

    public void InitEffect()
    {
        if (m_objEffectLogic)
        {
            m_objEffectLogic.InitEffect(this.gameObject);
        }
        else
        {
           // LogModule.ErrorLog("m_objEffectLogic is Null");
        }
    }

    public void PlayEffect(int effectID, EffectLogic.PlayEffectDelegate delPalyEffect = null, object param = null)
    {
        if (m_objEffectLogic)
        {
            m_objEffectLogic.PlayEffect(effectID, delPalyEffect, param);
        }
    }
    public void StopEffect(int effectID, bool bStopAll = true)
    {
        if (m_objEffectLogic)
        {
            m_objEffectLogic.StopEffect(effectID, bStopAll);
        }
    }
    public bool IsHaveBindPoint(string strPoint)
    {
        if (m_objEffectLogic)
        {
            return m_objEffectLogic.IsHaveBindPoint(strPoint);
        }
        return false;
    }
    public int GetEffectCountById(int id)
    {
        if (m_objEffectLogic)
        {
            return m_objEffectLogic.GetEffectCountById(id);
        }
        return 0;
    }
    #endregion
}
