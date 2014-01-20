using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS3.Domain.Model
{
    public class Menu
    {
        #region 构造函数
        /// <summary>
        /// 初始化一个菜单构造函数
        /// </summary>
        public Menu()
        {
        }
        #endregion

        #region 属性
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MENUNAME { get; set; }

        /// <summary>
        /// 事件(可以使用CSMS2.Presentation.XiTongPZ.FrmYuanGongXX?YuanGongFL=4)
        /// 也可以反射dllCSMS.KeHuGX.FrmGISShuiBiaoXXLR,CSMS.KeHuGX.dll
        /// </summary>
        public string EVENT { get; set; }
        
        /// <summary>
        /// 隶属上级菜单
        /// </summary>
        public int BELONGID { get; set; }
        
        /// <summary>
        /// 显示顺序
        /// </summary>
        public int DISPLAYINDEX { get; set; }
        
        /// <summary>
        /// 权限点编号
        /// </summary>
        public string PERMISSIONID { get; set; }

        /// <summary>
        /// 图片地址(相对路径ICO\银行接口\代扣\代扣回盘.png)
        /// </summary>
        public string IMAGELINK { get; set; }
        
        /// <summary>
        /// 图片模式（大图片还是小图片）
        /// </summary>
        public int? PICMODE { get; set; }
        
        /// <summary>
        /// 状态(激活还是不激活)
        /// </summary>
        public int? STATUS { get; set; }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string REMARK { get; set; }

        /// <summary>
        /// 窗体状态(不用，不显示、小图片、大图片)
        /// </summary>
        public int? WINDOWSTATE { get; set; }

        /// <summary>
        /// 窗体模式(不用，正常、最小化、最大化)
        /// </summary>
        public int? WINDOWMODE { get; set; }

        /// <summary>
        /// 子窗体(不用)
        /// </summary>
        public int? MDICHILDFORM { get; set; }
        

        /// <summary>
        /// 身份证(不用)
        /// </summary>
        public string CODE { get; set; }
        
        /// <summary>
        /// 菜单宽度(不用)
        /// </summary>
        public int? MENUWIDTH { get; set; }
        
        /// <summary>
        /// 菜单高度(不用)
        /// </summary>
        public int? MENUHEIGHT { get; set; }
        #endregion 
    }
}
