﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Infrastructure;
using Squidex.Infrastructure.Commands;

namespace Squidex.Domain.Apps.Entities.Contents.Commands
{
    public abstract class ContentCommand : SquidexCommand, IAggregateCommand
    {
        public DomainId ContentId { get; set; }

        public bool DoNotScript { get; set; }

        DomainId IAggregateCommand.AggregateId
        {
            get { return ContentId; }
        }
    }
}
