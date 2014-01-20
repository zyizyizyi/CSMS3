using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS3.Domain.Model
{
    /// <summary>
    /// 表示用户信息的对象。
    /// </summary>
    public class YongHuXX : AggregateRoot
    {
        #region 构造函数
        /// <summary>
        /// 初始化一个<c>用户信息</c>类型的实例。
        /// </summary>
        public YongHuXX() { }
        #endregion

        #region 属性
        /// <summary>
        /// 账号（唯一索引）按规则生成(新装)
        /// </summary>
        public string S_CID { get; set; }

        /// <summary>
        /// 站点(新装)
        /// </summary>
        public string S_ST { get; set; }

        /// <summary>
        /// 第二站点（用户词语表1）
        /// </summary>
        public string S_ST2 { get; set; }

        /// <summary>
        /// 册本号(新装)
        /// </summary>
        public string S_CH { get; set; }

        /// <summary>
        /// 册内序号（表卡调动或册内序号排序时修改）
        /// </summary>
        public int I_CENEIXH { get; set; }

        /// <summary>
        /// 入册日期
        /// </summary>
        public DateTime? D_RUCE { get; set; }

        /// <summary>
        /// 表卡状态（系统词语表8）
        /// </summary>
        public int I_BIAOKAZT { get; set; }

        /// <summary>
        /// 用户表卡打印日期
        /// </summary>
        public DateTime? D_BIAOKADYRQ { get; set; }

        /// <summary>
        /// 户名
        /// </summary>
        public string S_HM { get; set; }

        /// <summary>
        /// 催缴部门
        /// </summary>
        public int I_CUIJIAOBM { get; set; }


        /// <summary>
        /// 客户编号（对应客户信息表的客户Id )(新装)
        /// </summary>
        public string S_KEHUID { get; set; }

        /// <summary>
        /// 付费用户名(默认空）
        /// </summary>
        public string S_FUFEIYHM { get; set; }
        /// <summary>
        /// 用水地址(新装)
        /// </summary>
        public string S_DZ { get; set; }
        /// <summary>
        /// 行政区（系统词语表14）
        /// </summary>
        public string S_XINGZHENGQ { get; set; }
        /// <summary>
        /// 所属街道名称
        /// </summary>
        public string S_JIEDAO { get; set; }
        /// <summary>
        /// 所属社区名称
        /// </summary>
        public string S_SHEQU { get; set; }
        /// <summary>
        /// 小区名称
        /// </summary>
        public string S_XIAOQU { get; set; }
        /// <summary>
        /// 小区地址
        /// </summary>
        public string S_XIAOQUDZ { get; set; }
        /// <summary>
        /// 物业/居委
        /// </summary>
        public string S_WUYE { get; set; }
        /// <summary>
        /// 物业/居委联系电话
        /// </summary>
        public string S_WUYEDH { get; set; }
        /// <summary>
        /// 户数
        /// </summary>
        public int? I_HUSHU { get; set; }
        /// <summary>
        /// 人口数（默认0）
        /// </summary>
        public decimal? N_RENKOUS { get; set; }
        /// <summary>
        /// 主联系人和电话
        /// </summary>
        public string S_LIANXIRHDH { get; set; }
        /// <summary>
        /// 收费方式（系统词语表1）
        /// </summary>
        public int I_SFFS { get; set; }
        /// <summary>
        /// 托收号（按规则生成，默认为空）
        /// </summary>
        public string S_TUOSHOUHTH { get; set; }
        /// <summary>
        /// 开户名称
        /// </summary>
        public string S_KAIHUMC { get; set; }
        /// <summary>
        /// 付款授权合同号
        /// </summary>
        public string S_SHOUQUANHTH { get; set; }
        /// <summary>
        /// 签约日期
        /// </summary>
        public DateTime? D_QIANYUERQ { get; set; }
        /// <summary>
        /// 签约备注
        /// </summary>
        public string S_QIANYUEBZ { get; set; }
        /// <summary>
        /// 简号(新装)
        /// </summary>
        public string S_JH { get; set; }
        /// <summary>
        /// 涉水对象代码
        /// </summary>
        public string S_SHESHUIID { get; set; }
        /// <summary>
        /// 水资源四级区
        /// </summary>
        public string S_SHUIZIYQ { get; set; }
        /// <summary>
        /// 用水折扣率（默认1）
        /// </summary>
        public decimal N_YONGSHUIZKL { get; set; }
        /// <summary>
        /// 排水折扣率（默认0.9）
        /// </summary>
        public decimal N_PAISHUIZKL { get; set; }
        /// <summary>
        /// 垃圾费折扣率（默认1）
        /// </summary>
        public decimal N_LAJIFZKL { get; set; }
        /// <summary>
        /// 折扣率1（默认1）
        /// </summary>
        public decimal? N_ZHEKOUL1 { get; set; }
        /// <summary>
        /// 折扣率2（默认1）
        /// </summary>
        public decimal? N_ZHEKOUL2 { get; set; }
        /// <summary>
        /// 折扣率3（默认1）
        /// </summary>
        public decimal? N_ZHEKOUL3 { get; set; }
        /// <summary>
        /// 价格类别（系统词语表13）
        /// </summary>
        public string S_JIAGELB { get; set; }
        /// <summary>
        /// 混合用水的有效期
        /// </summary>
        public DateTime? D_HUNHEYSYXQ { get; set; }
        /// <summary>
        /// 位置分类（用户词语表10）用户类型（高层室内/室外、多层室内/室外）
        /// </summary>
        public string S_WEIZHIFL { get; set; }
        /// <summary>
        /// 水表安装位置
        /// </summary>
        public string S_ANZHUANGWZ { get; set; }
        /// <summary>
        /// 开账分类(系统词语表4)
        /// </summary>
        public string S_KAIZHANGFL { get; set; }
        /// <summary>
        /// 水表总类（用户词语表17）
        /// </summary>
        public int? I_SHUIBIAOZL { get; set; }
        /// <summary>
        /// 用途分类（用户词语表16）
        /// </summary>
        public string S_SHUIBIAOFL { get; set; }
        /// <summary>
        /// 水表功能分类（系统词语表23）
        /// </summary>
        public int I_GONGNENGFL { get; set; }
        /// <summary>
        /// 水表使用状态（-1:拆表;-2报废;0新表;1在用）
        /// </summary>
        public int I_SHIYONGZT { get; set; }
        /// <summary>
        /// 水表倍率（用户词语表11）
        /// </summary>
        public int I_SHUIBIAOBL { get; set; }
        /// <summary>
        /// 分摊方式（系统词语表76）
        /// </summary>
        public int I_FENTANFS { get; set; }
        /// <summary>
        /// 分摊量
        /// </summary>
        public decimal N_FENTANL { get; set; }
        /// <summary>
        /// 用水类别（用户词语表27）
        /// </summary>
        public int? I_YONGSHUILB { get; set; }
        /// <summary>
        /// 总表账号
        /// </summary>
        public string S_ZONGBIAOCID { get; set; }
        /// <summary>
        /// 监控表账号
        /// </summary>
        public string S_JIANKONGID { get; set; }
        /// <summary>
        /// 校对编号
        /// </summary>
        public string S_JIAODUIZBBH { get; set; }
        /// <summary>
        /// 水表条形码(新装)
        /// </summary>
        public string S_SHUIBIAOTXM { get; set; }
        /// <summary>
        /// 水表编号(钢印号)
        /// </summary>
        public string S_SHUIBIAOGYH { get; set; }
        /// <summary>
        /// 水表厂家ID（用户词语表9）
        /// </summary>
        public string S_SHUIBIAOCJID { get; set; }
        /// <summary>
        /// 表型ID（用户词语表12）
        /// </summary>
        public string S_BIAOXINGID { get; set; }
        /// <summary>
        /// 口径编号：对应口径表(新装)
        /// </summary>
        public string S_KOUJINGBH { get; set; }
        /// <summary>
        /// 口径
        /// </summary>
        public int? I_KOUJING { get; set; }
        /// <summary>
        /// 水表量程
        /// </summary>
        public int? I_LIANGCHENG { get; set; }
        /// <summary>
        /// 水表归属：(0:水司-默认;1:个人)
        /// </summary>
        public int I_SHUIBIAOGS { get; set; }
        /// <summary>
        /// 远传表编号
        /// </summary>
        public string S_YUANCHUANID { get; set; }
        /// <summary>
        /// 设备号（远传表）该字段不使用，适用S_YUANCHUANID
        /// </summary>
        public string S_SHEBEIH { get; set; }
        /// <summary>
        /// 终端号（远传表）
        /// </summary>
        public string S_ZHONGDUANH { get; set; }
        /// <summary>
        /// SIM卡号（远传表）
        /// </summary>
        public string S_SIMKAH { get; set; }
        /// <summary>
        /// 远传表所属(1:申水;2:山科;3:三高)(用户词语表27)
        /// </summary>
        public int? I_YUANCHUANBSS { get; set; }
        /// <summary>
        /// 自动采集(1是 0 否 )
        /// </summary>
        public int? I_ZIDONGCJ { get; set; }
        /// <summary>
        /// 水表拆表盒
        /// </summary>
        public string S_SHUIBIAOCBH { get; set; }
        /// <summary>
        /// 封印（有、无，默认有）
        /// </summary>
        public string S_FENYIN { get; set; }
        /// <summary>
        /// 表箱类型
        /// </summary>
        public string S_BIAOXIANGLX { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string S_X { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string S_Y { get; set; }
        /// <summary>
        /// GIS-X
        /// </summary>
        public string S_X1 { get; set; }
        /// <summary>
        /// GIS-Y
        /// </summary>
        public string S_Y1 { get; set; }
        /// <summary>
        /// 换表方式（S_WORDS 278）
        /// </summary>
        public int I_HUANBIAOFS { get; set; }
        /// <summary>
        /// 换表回填确认时间(默认null）
        /// </summary>
        public DateTime? D_HUANBIAOHTQRSJ { get; set; }
        /// <summary>
        /// 最近换表日期（默认装表日期）
        /// </summary>
        public DateTime? D_HUANBIAO { get; set; }
        /// <summary>
        /// 新表底码(新装)
        /// </summary>
        public int I_XINBIAODM { get; set; }
        /// <summary>
        /// 旧表抄码
        /// </summary>
        public int? I_JIUBIAOCM { get; set; }
        /// <summary>
        /// 注册号（报装）
        /// </summary>
        public string S_ZHUCEH { get; set; }
        /// <summary>
        /// 接水编号(新装)
        /// </summary>
        public string S_JIESHUIBH { get; set; }
        /// <summary>
        /// 立户日期(新装)
        /// </summary>
        public DateTime D_LIHU { get; set; }
        /// <summary>
        /// 装表日期(新装)
        /// </summary>
        public DateTime? D_ZHUANGBIAO { get; set; }
        /// <summary>
        /// 块号(新装)
        /// </summary>
        public string S_KUAIHAO { get; set; }
        /// <summary>
        /// 供水合同号(新装)
        /// </summary>
        public string S_GONGSHUIHTH { get; set; }
        /// <summary>
        /// 供水合同签订日期
        /// </summary>
        public DateTime? D_GONGSHUIHTQDRQ { get; set; }
        /// <summary>
        /// 供水合同年限
        /// </summary>
        public DateTime? D_GONGSHUIHTNX { get; set; }
        /// <summary>
        /// 协议类别（新增、设施转让、其它）
        /// </summary>
        public int? I_XIEYILB { get; set; }
        /// <summary>
        /// 协议签订日期
        /// </summary>
        public DateTime? D_XIEYIRQ { get; set; }
        /// <summary>
        /// 施工单位
        /// </summary>
        public string S_SHIGONGDW { get; set; }
        /// <summary>
        /// 施工人
        /// </summary>
        public string S_SHIGONGR { get; set; }
        /// <summary>
        /// 验收人
        /// </summary>
        public string S_YANSHOUR { get; set; }
        /// <summary>
        /// 管网分区编号（默认为空）
        /// </summary>
        public string S_GUANWANGFQBH { get; set; }
        /// <summary>
        /// 优惠水量
        /// </summary>
        public int? I_YOUHUISL { get; set; }
        /// <summary>
        /// 定额水量（默认0)
        /// </summary>
        public int I_DINGESL { get; set; }
        /// <summary>
        /// 二次供水标志(0:否;1:是)(默认0）
        /// </summary>
        public int I_ERCIGS { get; set; }
        /// <summary>
        /// 计划用水标志（默认0）
        /// </summary>
        public int I_JIHUAYS { get; set; }
        /// <summary>
        /// 井水与自来水混合(1是 0 否 ) 
        /// </summary>
        public int? I_JINGSHUIHH { get; set; }
        /// <summary>
        /// 是否多路进水(1是0否)
        /// </summary>
        public int? I_DUOLUJS { get; set; }
        /// <summary>
        /// 催缴方式（电话催缴、通知单、其它催缴）未配置
        /// </summary>
        public int? I_CUIJIAOFS { get; set; }
        /// <summary>
        /// 电子账单（系统词语表79）(0:否;1:只有电子账单;2:电子纸质并存)
        /// </summary>
        public int I_DIANZIZD { get; set; }
        /// <summary>
        /// 三来电话（默认空）
        /// </summary>
        public string S_SANLAIDH { get; set; }
        /// <summary>
        /// 断水通知编号
        /// </summary>
        public int I_DUANSHUIID { get; set; }
        /// <summary>
        /// 分客户编号
        /// </summary>
        public string S_FENKEHUBH { get; set; }
        /// <summary>
        /// 分组号（节点类别）
        /// </summary>
        public string S_FENZHUH { get; set; }
        /// <summary>
        /// 首抄抄码
        /// </summary>
        public int? I_SHOUCHAOCM { get; set; }
        /// <summary>
        /// 首抄状态（用户词语表407)
        /// </summary>
        public int? I_SHOUCHAOZT { get; set; }
        /// <summary>
        /// 首抄日期
        /// </summary>
        public DateTime? D_SHOUCHAORQ { get; set; }
        /// <summary>
        /// 首抄备注
        /// </summary>
        public string S_SHOUCHAOBZ { get; set; }
        /// <summary>
        /// 销户日期（默认null）
        /// </summary>
        public DateTime? D_XIAOHU { get; set; }
        /// <summary>
        /// 表卡备注
        /// </summary>
        public string S_BEIZHU { get; set; }
        /// <summary>
        /// 流程编号，如果大于0，说明正在走流程
        /// </summary>
        public int I_KID { get; set; }
        /// <summary>
        /// 流程类型
        /// </summary>
        public int? I_LIUCHENGID { get; set; }
        /// <summary>
        /// 操作人（最后一次）
        /// </summary>
        public string S_CAOZUOR { get; set; }
        /// <summary>
        /// 操作时间（最后一次）
        /// </summary>
        public DateTime D_CAOZUOSJ { get; set; }
        /// <summary>
        /// 备用1(新装施工表使用期限)
        /// </summary>
        public string S_BEIYONG1 { get; set; }
        /// <summary>
        /// 备用2(大用户1是0否)
        /// </summary>
        public string S_BEIYONG2 { get; set; }
        /// <summary>
        /// 备用3(新装接水类别)
        /// </summary>
        public string S_BEIYONG3 { get; set; }
        /// <summary>
        /// 多人口/合用表户籍地址备注
        /// </summary>
        public string S_BEIYONG4 { get; set; }
        /// <summary>
        /// 多人口/合用表方案
        /// </summary>
        public string S_BEIYONG5 { get; set; }
        /// <summary>
        /// 多人口/合用表申请日期
        /// </summary>
        public string S_BEIYONG6 { get; set; }
        /// <summary>
        /// 多人口/合用表有效期限起始日期
        /// </summary>
        public string S_BEIYONG7 { get; set; }
        /// <summary>
        /// 多人口/合用表有效期限截止日期
        /// </summary>
        public string S_BEIYONG8 { get; set; }
        /// <summary>
        /// 合用表标记
        /// </summary>
        public string S_BEIYONG9 { get; set; }
        /// <summary>
        /// 动迁基地编号
        /// </summary>
        public string S_DONGQIANJDBH { get; set; }
        /// <summary>
        /// 自装表开账系数
        /// </summary>
        public decimal? N_ZIZHUANGBKZXS { get; set; }
        /// <summary>
        /// 验收日期
        /// </summary>
        public DateTime? D_YANSHOURQ { get; set; }
        /// <summary>
        /// 水表类型编号
        /// </summary>
        public string S_SHUIBIAOLXBH { get; set; }
        #endregion

        #region 公共方法
        ///// <summary>
        ///// 返回表示当前Object的字符串。
        ///// </summary>
        ///// <returns>表示当前对象的字符串。</returns>
        //public override string ToString()
        //{
        //    return this.S_CID;
        //}
        #endregion
    }
}
