﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GM.BLL.Dto;
using GM.BLL.Infrastructure;
using GM.DAL.Entity;

namespace GM.BLL.Services
{
    public interface IServerService : IServiceFactory
    {
        Task<IEnumerable<ServerInfo>> GetInfos();

        Task<MatcheResult> GetMatche(string endpoint,string timestamp);

        Task<ServerInfo> GetInfo(string endpoint);

        Task<ServerState> GetState(string endpoint);
    }
}