using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Global.Data
{
    public class DynamoDBServicesContext
    {
        IAmazonDynamoDB dynamoDBClient { get; set; }

        public DynamoDBServicesContext(IAmazonDynamoDB dynamoDBClient)
        {
            this.dynamoDBClient = dynamoDBClient;
        }
    }
}
