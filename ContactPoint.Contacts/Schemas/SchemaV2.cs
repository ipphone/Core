﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactPoint.Contacts.Schemas
{
    internal class SchemaV2 : SchemaV1
    {
        public override int Version
        {
            get { return 2; }
        }

        public override void Upgrade(System.Data.SQLite.SQLiteConnection connection, DatabaseSchema currentSchema)
        {
            base.Upgrade(connection, currentSchema);

            if (currentSchema.Version < Version)
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
alter table contact_infos add column is_deleted int(1) not null default 0;
alter table tags add column is_deleted int(1) not null default 0;

update info set value_int = 2 where name = 'db_version';
";

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
