﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace XCLCMS.Data.DAL
{
    /// <summary>
    /// 数据访问类:Merchant
    /// </summary>
    public partial class Merchant : XCLCMS.Data.DAL.Common.BaseDAL
    {
        public Merchant()
        { }

        #region Method

        /// <summary>
        ///  增加一条数据
        /// </summary>
        public bool Add(XCLCMS.Data.Model.Merchant model)
        {
            Database db = base.CreateDatabase();
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Merchant_ADD");
            db.AddInParameter(dbCommand, "MerchantID", DbType.Int64, model.MerchantID);
            db.AddInParameter(dbCommand, "MerchantName", DbType.String, model.MerchantName);
            db.AddInParameter(dbCommand, "MerchantType", DbType.AnsiString, model.MerchantType);
            db.AddInParameter(dbCommand, "Domain", DbType.AnsiString, model.Domain);
            db.AddInParameter(dbCommand, "LogoURL", DbType.AnsiString, model.LogoURL);
            db.AddInParameter(dbCommand, "ContactName", DbType.String, model.ContactName);
            db.AddInParameter(dbCommand, "Tel", DbType.AnsiString, model.Tel);
            db.AddInParameter(dbCommand, "Landline", DbType.AnsiString, model.Landline);
            db.AddInParameter(dbCommand, "Email", DbType.AnsiString, model.Email);
            db.AddInParameter(dbCommand, "QQ", DbType.AnsiString, model.QQ);
            db.AddInParameter(dbCommand, "PassType", DbType.AnsiString, model.PassType);
            db.AddInParameter(dbCommand, "PassNumber", DbType.AnsiString, model.PassNumber);
            db.AddInParameter(dbCommand, "Address", DbType.String, model.Address);
            db.AddInParameter(dbCommand, "OtherContact", DbType.String, model.OtherContact);
            db.AddInParameter(dbCommand, "MerchantRemark", DbType.String, model.MerchantRemark);
            db.AddInParameter(dbCommand, "RegisterTime", DbType.DateTime, model.RegisterTime);
            db.AddInParameter(dbCommand, "MerchantState", DbType.AnsiString, model.MerchantState);
            db.AddInParameter(dbCommand, "Remark", DbType.AnsiString, model.Remark);
            db.AddInParameter(dbCommand, "RecordState", DbType.AnsiString, model.RecordState);
            db.AddInParameter(dbCommand, "CreateTime", DbType.DateTime, model.CreateTime);
            db.AddInParameter(dbCommand, "CreaterID", DbType.Int64, model.CreaterID);
            db.AddInParameter(dbCommand, "CreaterName", DbType.String, model.CreaterName);
            db.AddInParameter(dbCommand, "UpdateTime", DbType.DateTime, model.UpdateTime);
            db.AddInParameter(dbCommand, "UpdaterID", DbType.Int64, model.UpdaterID);
            db.AddInParameter(dbCommand, "UpdaterName", DbType.String, model.UpdaterName);

            db.AddOutParameter(dbCommand, "ResultCode", DbType.Int32, 4);
            db.AddOutParameter(dbCommand, "ResultMessage", DbType.String, 1000);
            db.ExecuteNonQuery(dbCommand);

            var result = XCLCMS.Data.DAL.Common.Common.GetProcedureResult(dbCommand.Parameters);
            if (result.IsSuccess)
            {
                return true;
            }
            else
            {
                throw new Exception(result.ResultMessage);
            }
        }

        /// <summary>
        ///  更新一条数据
        /// </summary>
        public bool Update(XCLCMS.Data.Model.Merchant model)
        {
            Database db = base.CreateDatabase();
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Merchant_Update");
            db.AddInParameter(dbCommand, "MerchantID", DbType.Int64, model.MerchantID);
            db.AddInParameter(dbCommand, "MerchantName", DbType.String, model.MerchantName);
            db.AddInParameter(dbCommand, "MerchantType", DbType.AnsiString, model.MerchantType);
            db.AddInParameter(dbCommand, "Domain", DbType.AnsiString, model.Domain);
            db.AddInParameter(dbCommand, "LogoURL", DbType.AnsiString, model.LogoURL);
            db.AddInParameter(dbCommand, "ContactName", DbType.String, model.ContactName);
            db.AddInParameter(dbCommand, "Tel", DbType.AnsiString, model.Tel);
            db.AddInParameter(dbCommand, "Landline", DbType.AnsiString, model.Landline);
            db.AddInParameter(dbCommand, "Email", DbType.AnsiString, model.Email);
            db.AddInParameter(dbCommand, "QQ", DbType.AnsiString, model.QQ);
            db.AddInParameter(dbCommand, "PassType", DbType.AnsiString, model.PassType);
            db.AddInParameter(dbCommand, "PassNumber", DbType.AnsiString, model.PassNumber);
            db.AddInParameter(dbCommand, "Address", DbType.String, model.Address);
            db.AddInParameter(dbCommand, "OtherContact", DbType.String, model.OtherContact);
            db.AddInParameter(dbCommand, "MerchantRemark", DbType.String, model.MerchantRemark);
            db.AddInParameter(dbCommand, "RegisterTime", DbType.DateTime, model.RegisterTime);
            db.AddInParameter(dbCommand, "MerchantState", DbType.AnsiString, model.MerchantState);
            db.AddInParameter(dbCommand, "Remark", DbType.AnsiString, model.Remark);
            db.AddInParameter(dbCommand, "RecordState", DbType.AnsiString, model.RecordState);
            db.AddInParameter(dbCommand, "CreateTime", DbType.DateTime, model.CreateTime);
            db.AddInParameter(dbCommand, "CreaterID", DbType.Int64, model.CreaterID);
            db.AddInParameter(dbCommand, "CreaterName", DbType.String, model.CreaterName);
            db.AddInParameter(dbCommand, "UpdateTime", DbType.DateTime, model.UpdateTime);
            db.AddInParameter(dbCommand, "UpdaterID", DbType.Int64, model.UpdaterID);
            db.AddInParameter(dbCommand, "UpdaterName", DbType.String, model.UpdaterName);

            db.AddOutParameter(dbCommand, "ResultCode", DbType.Int32, 4);
            db.AddOutParameter(dbCommand, "ResultMessage", DbType.String, 1000);
            db.ExecuteNonQuery(dbCommand);

            var result = XCLCMS.Data.DAL.Common.Common.GetProcedureResult(dbCommand.Parameters);
            if (result.IsSuccess)
            {
                return true;
            }
            else
            {
                throw new Exception(result.ResultMessage);
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XCLCMS.Data.Model.Merchant GetModel(long MerchantID)
        {
            Database db = base.CreateDatabase();
            DbCommand dbCommand = db.GetSqlStringCommand("select * from Merchant where MerchantID=@MerchantID");
            db.AddInParameter(dbCommand, "MerchantID", DbType.Int64, MerchantID);
            DataSet ds = db.ExecuteDataSet(dbCommand);
            var lst = XCLNetTools.Generic.ListHelper.DataTableToList<XCLCMS.Data.Model.Merchant>(ds.Tables[0]);
            return null != lst && lst.Count > 0 ? lst[0] : null;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM Merchant ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            Database db = DatabaseFactory.CreateDatabase();
            return db.ExecuteDataSet(CommandType.Text, strSql.ToString());
        }

        #endregion Method

        #region MethodEx

        /// <summary>
        /// 分页数据列表
        /// </summary>
        public List<XCLCMS.Data.Model.Merchant> GetPageList(XCLNetTools.Entity.PagerInfo pageInfo, string strWhere, string fieldName, string fieldKey, string fieldOrder)
        {
            DataTable dt = XCLCMS.Data.DAL.Common.Common.GetPageList("Merchant", pageInfo, strWhere, fieldName, fieldKey, fieldOrder);
            return XCLNetTools.Generic.ListHelper.DataTableToList<XCLCMS.Data.Model.Merchant>(dt) as List<XCLCMS.Data.Model.Merchant>;
        }

        #endregion MethodEx
    }
}