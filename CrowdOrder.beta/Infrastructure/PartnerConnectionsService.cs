using CrowdOrder.beta.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Infrastructure
{
    public class PartnerConnectionsService
    {
        private readonly PartnerConnectionRepository _partnerConnection;
        private readonly Cache _cache;
        private readonly ILogger<PartnerConnectionsService> _logger;
        public PartnerConnectionsService(ILogger<PartnerConnectionsService> logger,
            PartnerConnectionRepository partnerConnection,
            Cache cache)
        {

            _partnerConnection = partnerConnection;
            _cache = cache;
        }
        public bool IsUserAlreadyConnected(string userId, int serviceId)
        {
            var data = GetConnectionsForUser(Guid.Parse(userId)).Where(x => x.Service.Id == serviceId).FirstOrDefault();
            return data != null;
        }

        public List<PartnerConnection> GetConnectionsForUser(Guid userId)
        {
            //cache connections for user
            var connections = _cache.Memoize($"Connections.{userId}",
                                () =>
                                {
                                    var data = _partnerConnection.GetByUserId(userId);
                                    return data;
                                },
                                DateTime.UtcNow.TimeToMidnight()
                                );

            return connections;

        }
        public void SetConnectionToCache(PartnerConnection model)
        {
            var data = GetConnectionsForUser(model.UserId);
            data.Add(model);
            _cache.Remove($"Connections.{model.UserId}");
            _cache.Memoize($"Connections.{model.UserId}", () => { return data; }, DateTime.UtcNow.TimeToMidnight());
        }
    }
}
