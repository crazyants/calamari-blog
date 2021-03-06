﻿using Microsoft.Extensions.Options;

namespace CB.CMS.SquidexClient
{
    public class SquidexClientFactory : ISquidexClientFactory
    {
        readonly IOptions<SquidexSettings> _config;

        public SquidexClientFactory(IOptions<SquidexSettings> config)
        {
            _config = config;
        }

        public SquidexClient<TEntity, TData> GetClient<TEntity, TData>(string schemaName)
            where TEntity : SquidexEntityBase<TData>
            where TData : class, new()
        {
            return new SquidexClient<TEntity, TData>(_config, schemaName);
        }
    }
}
