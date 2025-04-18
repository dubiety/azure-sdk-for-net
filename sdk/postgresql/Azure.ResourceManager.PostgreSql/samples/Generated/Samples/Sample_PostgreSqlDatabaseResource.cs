// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.Samples
{
    public partial class Sample_PostgreSqlDatabaseResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_DatabaseGet()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/DatabaseGet.json
            // this example is just showing the usage of "Databases_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlDatabaseResource created on azure
            // for more information of creating PostgreSqlDatabaseResource, please refer to the document of PostgreSqlDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier postgreSqlDatabaseResourceId = PostgreSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            PostgreSqlDatabaseResource postgreSqlDatabase = client.GetPostgreSqlDatabaseResource(postgreSqlDatabaseResourceId);

            // invoke the operation
            PostgreSqlDatabaseResource result = await postgreSqlDatabase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DatabaseDelete()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/DatabaseDelete.json
            // this example is just showing the usage of "Databases_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlDatabaseResource created on azure
            // for more information of creating PostgreSqlDatabaseResource, please refer to the document of PostgreSqlDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier postgreSqlDatabaseResourceId = PostgreSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            PostgreSqlDatabaseResource postgreSqlDatabase = client.GetPostgreSqlDatabaseResource(postgreSqlDatabaseResourceId);

            // invoke the operation
            await postgreSqlDatabase.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_DatabaseCreate()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/DatabaseCreate.json
            // this example is just showing the usage of "Databases_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlDatabaseResource created on azure
            // for more information of creating PostgreSqlDatabaseResource, please refer to the document of PostgreSqlDatabaseResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "TestGroup";
            string serverName = "testserver";
            string databaseName = "db1";
            ResourceIdentifier postgreSqlDatabaseResourceId = PostgreSqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            PostgreSqlDatabaseResource postgreSqlDatabase = client.GetPostgreSqlDatabaseResource(postgreSqlDatabaseResourceId);

            // invoke the operation
            PostgreSqlDatabaseData data = new PostgreSqlDatabaseData
            {
                Charset = "UTF8",
                Collation = "English_United States.1252",
            };
            ArmOperation<PostgreSqlDatabaseResource> lro = await postgreSqlDatabase.UpdateAsync(WaitUntil.Completed, data);
            PostgreSqlDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
