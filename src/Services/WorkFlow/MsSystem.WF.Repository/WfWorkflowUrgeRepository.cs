//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     创建人：wms
//     创建时间：2019/12/1 14:30:13
//     说明：
// </auto-generated>
//------------------------------------------------------------------------------
using JadeFramework.Dapper;
using JadeFramework.Dapper.SqlGenerator;
using MsSystem.WF.IRepository;
using MsSystem.WF.Model;
using System.Data;

namespace MsSystem.WF.Repository
{
    /// <summary>
    /// 催办记录表 仓储
    /// </summary>
    public class WfWorkflowUrgeRepository : DapperRepository<WfWorkflowUrge>, IWfWorkflowUrgeRepository
    {
        public WfWorkflowUrgeRepository(IDbConnection connection, SqlGeneratorConfig config) : base(connection, config)
        {
        }
    }
}
