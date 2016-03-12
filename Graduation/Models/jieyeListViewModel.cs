using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Graduation.Models
{
    public class jieyeListViewModel
    {
        /// <summary>
        /// 学院
        /// </summary>
        public string aca { get; set; }

        /// <summary>
        /// 系
        /// </summary>
        public string dep { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        public string major { get; set; }

        /// <summary>
        /// 总人数
        /// </summary>
        public int totalNumber { get; set; }

        /// <summary>
        /// 签约人数
        /// </summary>
        public int signNumber { get; set; }

        /// <summary>
        /// 合同就业人数
        /// </summary>
        public int hetongNumber { get; set; }

        /// <summary>
        /// 升学人数
        /// </summary>
        public int upschoolNumber { get; set; }

        /// <summary>
        /// 出国人数
        /// </summary>
        public int abroadNumber { get; set; }
    }
}