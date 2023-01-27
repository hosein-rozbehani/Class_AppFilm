using System;

namespace Class_AppFilme { };
/// <summary>
/// کلاس برنامه فیلم
/// </summary>

public class Program : Object
{
    #region constructor 
    /// <summary>
    /// انتخاب
    /// </summary>
    /// <param name="zhanr">ژانر کتاب</param>
    /// <param name="nevisandeh">نویسنده</param>
    public Program(string zhanr, string bazigar) : base()
    {

        this.zhanr = zhanr;
        this.bazigar = bazigar;
    }

    #endregion /constructor

    #region properties

    #region public int? salsakht { get; set; }
    /// <summary>
    /// سال ساخت
    /// </summary>
    public int? salsakht { get; set; }
    #endregion public int? salsakht { get; set; }

    #region  public int? IMDB { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int? IMDB { get; set; }
    #endregion  public int? IMDB { get; set; }

    #region public string zhanr { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string zhanr { get; set; }
    #endregion public string zhanr { get; set; }

    #region public string kargardan { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string kargardan { get; set; }
    #endregion public string kargardan { get; set; }

    #region public string bazigar { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string bazigar { get; set; }
    #endregion public string bazigar { get; set; }

    #endregion /properties
}
