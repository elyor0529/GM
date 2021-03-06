﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GM.BLL.Dto;
using GM.BLL.Services;
using GM.DAL.Entity;
using GM.DAL.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace GM.Api.Controllers
{
    [Route("reports")]
    public class ReportController : Controller
    {
        private readonly IGenericRepository<Map> _gameModeRepository;
        private readonly IGenericRepository<Map> _mapRepository;
        private readonly IGenericRepository<Matche> _matcheRepository;
        private readonly IGenericRepository<Player> _playerRepository;
        private readonly IGenericRepository<Scoreboard> _scoreboardRepository;
        private readonly IGenericRepository<Server> _serverRepository;
        private readonly IReportService _service;

        public ReportController(IReportService service, IGenericRepository<Server> serverRepository,
            IGenericRepository<Scoreboard> scoreboardRepository, IGenericRepository<Player> playerRepository,
            IGenericRepository<Matche> matcheRepository, IGenericRepository<Map> mapRepository,
            IGenericRepository<Map> gameModeRepository)
        {
            _service = service;
            _serverRepository = serverRepository;
            _scoreboardRepository = scoreboardRepository;
            _playerRepository = playerRepository;
            _matcheRepository = matcheRepository;
            _mapRepository = mapRepository;
            _gameModeRepository = gameModeRepository;
        }

        // recent-matches[/<count>] GET
        [HttpGet("recent-matches/{count:int:range(1,50)}")]
        public async Task<IEnumerable<RecentMatche>> GetRecentMatches(int count = 50)
        {
            return await _service.GetRecentMatches(count);
        }

        // best-players[/<count>] GET
        [HttpGet("best-players/{count:int:range(1,50)}")]
        public async Task<IEnumerable<BestPlayer>> GetBestPlayers(int count = 50)
        {
            return await _service.GetBestPlayers(count);
        }

        // best-players[/<count>] GET
        [HttpGet("popular-servers/{count:int:range(1,50)}")]
        public async Task<IEnumerable<PopularServer>> GetPopularServers(int count=50)
        {
            return await _service.GetPopularServers(count);
        }
    }
}