﻿using Umbraco.Cms.Core.Composing;

using uSync.Migrations.Configuration.Models;
using uSync.Migrations.Models;

namespace uSync.Migrations.Validation;

public interface ISyncMigrationValidator : IDiscoverable
{
    IEnumerable<MigrationMessage> Validate(MigrationOptions options);
}
